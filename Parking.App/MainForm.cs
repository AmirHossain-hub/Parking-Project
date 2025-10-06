using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parking_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }


        private void Exitbutton_Click(object sender, EventArgs e)
        {
            try
            {
                Parking.App.frmExitCar frmExitCar = new Parking.App.frmExitCar("Car", DateTime.Now);
                frmExitCar.ShowDialog();
            }
            catch
            {
                MessageBox.Show("خطا در بارگیری اطلاعات");
                this.Close();
            }
        }

        private void Situationbutton_Click(object sender, EventArgs e)
        {
            Parking.App.frmSituation  parkingListSituation = new Parking.App.frmSituation();
            parkingListSituation.ShowDialog();
        }

        private void PriceButtonClick(object sender, EventArgs e)
        {
            Parking.App.frmPrice frmPrice = new Parking.App.frmPrice();
            frmPrice.ShowDialog();
        }

        private void EntryNewCar_Click(object sender, EventArgs e)
        {
            try
            {
                Parking.App.EntryandExit.frmEntryNewCar frmEntryNewCar = new Parking.App.EntryandExit.frmEntryNewCar();
                frmEntryNewCar.ShowDialog();
            }
            catch
            {
                MessageBox.Show("خطا در بارگیری اطلاعات");
                this.Close();
            }
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            Parking.App.frmReport frmReport = new Parking.App.frmReport();
            frmReport.ShowDialog();
        }
    }
}
