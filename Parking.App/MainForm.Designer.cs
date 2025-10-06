namespace Parking_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Entrybutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.Situationbutton = new System.Windows.Forms.Button();
            this.Reportbutton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PriceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entrybutton
            // 
            this.Entrybutton.BackColor = System.Drawing.Color.Transparent;
            this.Entrybutton.Location = new System.Drawing.Point(711, 12);
            this.Entrybutton.Name = "Entrybutton";
            this.Entrybutton.Size = new System.Drawing.Size(75, 23);
            this.Entrybutton.TabIndex = 2;
            this.Entrybutton.Text = "ورود";
            this.Entrybutton.UseVisualStyleBackColor = false;
            this.Entrybutton.Click += new System.EventHandler(this.EntryNewCar_Click);
            // 
            // Exitbutton
            // 
            this.Exitbutton.BackColor = System.Drawing.Color.Transparent;
            this.Exitbutton.Location = new System.Drawing.Point(630, 12);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(75, 23);
            this.Exitbutton.TabIndex = 2;
            this.Exitbutton.Text = "خروج";
            this.Exitbutton.UseVisualStyleBackColor = false;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // Situationbutton
            // 
            this.Situationbutton.BackColor = System.Drawing.Color.Transparent;
            this.Situationbutton.Location = new System.Drawing.Point(549, 12);
            this.Situationbutton.Name = "Situationbutton";
            this.Situationbutton.Size = new System.Drawing.Size(75, 23);
            this.Situationbutton.TabIndex = 3;
            this.Situationbutton.Text = "وضعیت کل";
            this.Situationbutton.UseVisualStyleBackColor = false;
            this.Situationbutton.Click += new System.EventHandler(this.Situationbutton_Click);
            // 
            // Reportbutton
            // 
            this.Reportbutton.BackColor = System.Drawing.Color.Transparent;
            this.Reportbutton.Location = new System.Drawing.Point(468, 12);
            this.Reportbutton.Name = "Reportbutton";
            this.Reportbutton.Size = new System.Drawing.Size(75, 23);
            this.Reportbutton.TabIndex = 4;
            this.Reportbutton.Text = "گزارش";
            this.Reportbutton.UseVisualStyleBackColor = false;
            this.Reportbutton.Click += new System.EventHandler(this.Reportbutton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "pngtree-some-classic-cars-in-a-parking-lot-picture-image_2694649.jpg");
            // 
            // PriceButton
            // 
            this.PriceButton.BackColor = System.Drawing.Color.Transparent;
            this.PriceButton.Location = new System.Drawing.Point(387, 12);
            this.PriceButton.Name = "PriceButton";
            this.PriceButton.Size = new System.Drawing.Size(75, 23);
            this.PriceButton.TabIndex = 5;
            this.PriceButton.Text = "نرخ پارکینگ";
            this.PriceButton.UseVisualStyleBackColor = false;
            this.PriceButton.Click += new System.EventHandler(this.PriceButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 419);
            this.Controls.Add(this.PriceButton);
            this.Controls.Add(this.Reportbutton);
            this.Controls.Add(this.Situationbutton);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Entrybutton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Entrybutton;
        private System.Windows.Forms.Button Exitbutton;
        private System.Windows.Forms.Button Situationbutton;
        private System.Windows.Forms.Button Reportbutton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button PriceButton;
    }
}