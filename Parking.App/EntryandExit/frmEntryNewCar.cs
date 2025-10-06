using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.App;
using Parking.DataLayer;
using Parking.DataLayer.Context;
using Parking.ViewModels;
using ValidationComponents;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Parking.App.EntryandExit
{
    public partial class frmEntryNewCar : Form
    {
        public UnitofWork db;
        public frmEntryNewCar()
        {
            InitializeComponent();
            if (components == null)
            {
                components = new Container();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmEntryNewCar_Load(object sender, EventArgs e)
        {
            try
            {
                db = new UnitofWork();
            }
            catch (Exception ex)
            {
                //RtlMessageBox.Show($"خطا در راه‌اندازی پایگاه داده: {ex.Message}");
                //this.Close();
                string errorMessage = $"خطا در بارگیری اطلاعات وسایل نقلیه: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void FullNamelabel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumberPlatetextBox.Text) || string.IsNullOrWhiteSpace(FullNametextBox.Text) || string.IsNullOrWhiteSpace(PhoneNumberMaskedtextBox.Text) || cmbVehicleType.SelectedItem == null)
            {
                MessageBox.Show("لطفا تمام فیلدهای ضروری را پر کنید",
                              "هشدار",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Warning);
                return;
            }


            if (BaseValidator.IsFormValid(this.components))
            {
                if (string.IsNullOrWhiteSpace(NumberPlatetextBox.Text) || string.IsNullOrWhiteSpace(FullNametextBox.Text) || string.IsNullOrWhiteSpace(PhoneNumberMaskedtextBox.Text) || cmbVehicleType.SelectedItem == null)
                {
                    MessageBox.Show("لطفا تمام فیلدهای ضروری را پر کنید",
                                  "هشدار",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Warning);
                    return;
                }
                Global.VehicleType = cmbVehicleType?.SelectedItem?.ToString() ?? string.Empty;
                Global.EntryTime = DateTime.Now;

                if (cmbVehicleType.SelectedItem == null)
                {
                    RtlMessageBox.Show("لطفا نوع وسیله نقلیه را انتخاب کنید");
                    return;
                }
                db = new UnitofWork();

                ////
                int retrycount = 0;
                const int Maxretries = 5;
                while(db == null || db.GenericRepository == null)
                {
                    RtlMessageBox.Show($"خطا در اتصال به پایگاه داده.تلاش مجدد شماره{retrycount + 1} از {Maxretries}");
                    db = new UnitofWork();
                    retrycount++;
                    System.Threading.Thread.Sleep(1000);
                }
                if (db == null || db.GenericRepository == null)
                {
                    RtlMessageBox.Show("عدم موفقیت در اتصال به پایگاه داده پس از چندین تلاش.");
                    return;
                }
                
                if (cmbVehicleType.SelectedItem != null)
                {
                    using (db = new UnitofWork())
                    {
                        GeneralInformation general = new GeneralInformation()
                        {
                            NumberPlate = NumberPlatetextBox.Text,
                            EntryDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, 0, 0),
                            FullName = FullNametextBox.Text,
                            PhoneNumber = PhoneNumberMaskedtextBox.Text,
                            VehicleType = cmbVehicleType.SelectedItem.ToString(),
                            CarSituation = "ورودی"
                        };
                        bool exists = db.GenericRepository.GetAllInfo().Any(x => x.NumberPlate == general.NumberPlate);
                        if (cmbVehicleType.SelectedItem != null)
                        {
                            if (exists)
                            {
                                RtlMessageBox.Show("این شماره پلاک قبلا در سیستم ثبت شده است");
                                return;
                            }
                            else
                            {
                                db.GenericRepository.Insert(general);
                                db.Save();
                                db.Dispose();
                                DialogResult = DialogResult.OK;
                                RtlMessageBox.Show("خودروی شما با موفقیت ثبت شد");
                            }
                        }
                        else
                        {
                            RtlMessageBox.Show("لطفا مشخصات را وارد کنید");
                        }
                    }
                };
            }
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbVehicleType_DropDownStyleChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}


       
    








            

    

