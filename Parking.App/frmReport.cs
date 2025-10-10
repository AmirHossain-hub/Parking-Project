using Parking.DataLayer.Context;
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
using Parking.DataLayer.Services;
using Parking.DataLayer.Repositories;

namespace Parking.App
{
    public partial class frmReport : Form
    {
        UnitofWork db = new UnitofWork();
        GeneralInformation general = new GeneralInformation();


        public frmReport()
        {
            InitializeComponent();
        }
        public frmReport(UnitofWork dbo)
        {
            db = dbo;
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            try
            {
                using(UnitofWork db = new UnitofWork())
                {
                    Console.WriteLine("UnitofWork created"); // Debug line

                    if (db.GenericRepository == null)
                    {
                        MessageBox.Show("GenericRepository is null!");
                        return;
                    }
                    Console.WriteLine("GenericRepository is OK"); // Debug line

                    var alldata = db.Repository.GetAllInfo(general).ToList();
                    Console.WriteLine($"Retrieved {alldata.Count} records");
                    dataGridView1.DataSource = alldata;

                    dataGridView1.Columns["Fee"].DefaultCellStyle.Format = "00";
                    dataGridView1.Columns["EntryDate"].DefaultCellStyle.Format = "yyyy/mm/dd HH:mm";
                    dataGridView1.Columns["ExitDate"].DefaultCellStyle.Format = "yyyy/mm/dd HH:mm";
                }
            }
            catch(Exception ex)
            {
                UnitofWork db = new UnitofWork();
                if (db == null)
                {
                    string errormessage = $"خطا در بارگیری اطلاعات {ex.Message}";
                    if (ex.InnerException != null)
                    {
                        errormessage = $"\nInner Exception: {ex.InnerException.Message}";
                    }
                    MessageBox.Show(errormessage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string errormessage = $"خطا در بارگیری اطلاعات {ex.Message}";

                }
                
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? StartDate = StartdateTimePicker.Value.Date;
                DateTime? EndDate = EnddateTimePicker.Value.Date.AddDays(1).AddSeconds(-1);
                using (UnitofWork db = new UnitofWork())
                {
                    var filterdata = db.GenericRepository.GetAllInfo().Where(v => v.EntryDate >= StartDate && v.ExitDate <= EndDate).ToList();

                    dataGridView1.DataSource = null;
                    dataGridView1.Rows.Clear();

                    if (filterdata.Any())
                    {
                        dataGridView1.DataSource = filterdata;

                        dataGridView1.Columns["Fee"].DefaultCellStyle.Format = "00";
                        dataGridView1.Columns["EntryDate"].DefaultCellStyle.Format = "yyyy/mm/dd HH:mm";
                        dataGridView1.Columns["ExitDate"].DefaultCellStyle.Format = "yyyy/mm/dd HH:mm";
                    }
                    else
                    {
                        RtlMessageBox.Show("رکوردی برای این اطلاعات یافت نشد", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"خطا در یافتن اطلاعات مورد نظر: {ex.Message}";
                if (ex.InnerException != null)
                {
                    errorMessage += $"\nInner Exception: {ex.InnerException.Message}";
                }
                MessageBox.Show(errorMessage, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void StartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
