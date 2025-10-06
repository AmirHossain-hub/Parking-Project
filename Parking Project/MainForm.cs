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

        private void button6_Click(object sender, EventArgs e)
        {
            Price price = new Price();
            price.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile("background.jpg");
            this.Controls.Add(pictureBox1);

            Button button1 = new Button();
            button1.Text = "Button 1";
            button1.Location = new Point(100, 100);
            this.Controls.Add(button1);

            Button button2 = new Button();
            button2.Text = "Button 2";
            button2.Location = new Point(200, 200);
            this.Controls.Add(button2);
        }
    }
}
