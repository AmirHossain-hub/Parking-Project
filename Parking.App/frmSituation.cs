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
        public frmSituation()
        {
            InitializeComponent();
        }

        private void frmSituation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parking_DBDataSet.GeneralInformation' table. You can move, or remove it, as needed.
            this.generalInformationTableAdapter.Fill(this.parking_DBDataSet.GeneralInformation);

        }
    }
}
