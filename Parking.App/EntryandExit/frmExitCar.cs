using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.DataLayer;
using Parking.Business;
using Parking.DataLayer.Context;
using Parking.DataLayer.Repositories;
using Parking.ViewModels.Globalization;
using Parking.Utility.Convertor;

namespace Parking.App
{
    public partial class frmExitCar : Form
    {
        public decimal _currentCost;
        private Repository _repository;
        private string _vehicleType;
        private DateTime _entryTime;
        private string _selectedNumberPlate;
        UnitofWork db = new UnitofWork();
        GeneralInformation general = new GeneralInformation();
        public frmExitCar(string vehicleType, DateTime entryTime)
        {
            InitializeComponent();
            _vehicleType = vehicleType;
            _entryTime = general.EntryDate;
            _repository = new Repository(new Parking_DBEntities3());
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _selectedNumberPlate = general.NumberPlate;
        }
       
        private void frmExitCar_Load(object sender, EventArgs e)
        {
            this.generalInformationTableAdapter.Fill(this.parking_DBDataSet1.GeneralInformation);
            LoadVehicleData();
        }
        private void LoadActiveParkings()
        {
            try
            {
                UnitofWork db = new UnitofWork();
            }
            catch (Exception ex)
            {
                RtlMessageBox.Show($"خطا در راه‌اندازی پایگاه داده: {ex.Message}");
                this.Close(); 
            }
        }

        private void CarInformation_Click(object sender, EventArgs e)
        {

        }
        
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            List<DataLayer.CarInformation> carInformation = new List<CarInformation>();
            CalculateViewModel calculate = new CalculateViewModel();
            if ((txtOwnerName.Text == null || txtNumberPlate.Text == null) || txtNumberPlate.Text == null || ExitDateTimePicker.Value == null)
            {
                MessageBox.Show("لطفا تمام فیلدهای مورد نظر را پر کنید", "هشدار",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (UnitofWork db = new UnitofWork())
                {
                    var vehicle = db.GenericRepository.GetAllInfo().FirstOrDefault(v => v.NumberPlate == txtNumberPlate.Text);

                    if (vehicle == null)
                    {
                        MessageBox.Show("وسیله نقلیه انتخاب شده یافت نشد", "خطا",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DateTime entryTime = vehicle.EntryDate;

                    DateTime exitTime = ExitDateTimePicker.Value;

                    TimeSpan duration = exitTime - entryTime;

                    double totalHours = duration.TotalHours;
                    
                    if (duration.TotalHours < 0)
                    {
                        MessageBox.Show("زمان خروج نمی تواند قبل از زمان ورود ورود باشد!");
                        return;
                    }
                    else
                    {
                        txtDuration.Text = $"{duration.TotalHours:F1} ساعت";
                    }

                    try
                    {
                        CostCalculation calculator = new CostCalculation();
                        _currentCost = calculator.CalculateParkingFee(vehicle.VehicleType, duration, vehicle.NumberPlate, db);

                        string englishFormatted = _currentCost.ToString("N0");

                        PersianDigit persianDigit = new PersianDigit();
                        string persianFormatted = persianDigit.ConvertToPersianDigits(englishFormatted);

                        decimal? storedValue = vehicle.Fee; 
                        string displayValue = persianDigit.ConvertToPersianDigits(_currentCost.ToString("N0"));

                        txtCost.Text = $"{persianFormatted} تومان";
                        txtCost.RightToLeft = RightToLeft.Yes;

                        vehicle.Fee = _currentCost; 
                        db.GenericRepository.Update(vehicle);
                        db.Save();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show($"خطا در محاسبه:\n\n{ex.GetType().Name}:{ex.Message}\n\nStack Trace:\n{ex.StackTrace}","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در محاسبه هزینه:\n\n{ex.GetType().Name}: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                   "خطا",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);

                System.Diagnostics.Debug.WriteLine($"EXCEPTION: {ex}");
            }
        }

        private void LoadVehicleData()
        {
            try
            {
                using (UnitofWork db = new UnitofWork())
                {
                    var vehicles = db.GenericRepository.GetAllInfo().Where(v => v.ExitDate == null).ToList();
                    dataGridView1.DataSource = vehicles;
                }
                MessageBox.Show("با موفقیت وارد شدید");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در بارگیری اطلاعات وسایل نقلیه: {ex.Message}", "خطا",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                using (UnitofWork db = new UnitofWork())
                {
                    var vehicle = db.GenericRepository.GetAllInfo()
                        .FirstOrDefault(v => v.NumberPlate == _selectedNumberPlate);

                    if (vehicle != null)
                    {
                        // Update vehicle
                        vehicle.CarSituation = "خروجی";
                        vehicle.Fee = _currentCost;
                        vehicle.ExitDate = ExitDateTimePicker.Value;

                        db.GenericRepository.Update(vehicle);

                        if (db.Save())
                        {
                            DialogResult = DialogResult.OK;
                            MessageBox.Show("خروج وسیله نقلیه با موفقیت ثبت شد", "موفقیت",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("خطا در ذخیره اطلاعات در پایگاه داده", "خطا",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("وسیله نقلیه مورد نظر یافت نشد", "هشدار",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"خطا در ثبت خروج: {ex.Message}", "خطا",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnitofWork db = new UnitofWork();
            db?.Dispose();
            ////base.OnFormClosing(e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
           this.Text = _currentCost.ToString("N0") + " تومان";
        }

        private void txtDuration_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmExitCar_Click(object sender, EventArgs e)
        {

        }

        //private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0) // Make sure a row is clicked, not header
        //    {
        //        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        //        // Get the NumberPlate from the selected row
        //        _selectedNumberPlate = row.Cells["NumberPlate"].Value?.ToString();

        //        // Also populate the text boxes with the selected vehicle's data
        //        if (!string.IsNullOrEmpty(_selectedNumberPlate))
        //        {
        //            txtNumberPlate.Text = _selectedNumberPlate;

        //            // Optionally load other details
        //            using (UnitofWork db = new UnitofWork())
        //            {
        //                var vehicle = db.GenericRepository.GetAllInfo()
        //                    .FirstOrDefault(v => v.NumberPlate == _selectedNumberPlate);

        //                if (vehicle != null)
        //                {
        //                    txtOwnerName.Text = vehicle.FullName;
        //                    // Set other fields as needed
        //                }
        //            }
        //        }

        //        MessageBox.Show($"شماره پلاک انتخاب شده: {_selectedNumberPlate}");
        //    }
        //}
    }
}
