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

namespace Parking.App
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parking_DBDataSet2.GeneralInformation' table. You can move, or remove it, as needed.
            this.generalInformationTableAdapter.Fill(this.parking_DBDataSet2.GeneralInformation);

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
    }
}
