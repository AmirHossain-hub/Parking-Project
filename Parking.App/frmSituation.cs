using Parking.DataLayer;
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
    public partial class frmSituation : Form
    {
        UnitofWork db = new UnitofWork();
        GeneralInformation general = new GeneralInformation();

        public frmSituation()
        {
            InitializeComponent();
        }

        private void frmSituation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parking_DBDataSet.GeneralInformation' table. You can move, or remove it, as needed.
            //this.generalInformationTableAdapter.Fill(this.parking_DBDataSet.GeneralInformation);
            try
            {
                using (UnitofWork db = new UnitofWork())
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
            catch (Exception ex)
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
