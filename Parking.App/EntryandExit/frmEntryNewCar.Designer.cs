namespace Parking.App.EntryandExit
{
    partial class frmEntryNewCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntryNewCar));
            this.btnSubmit = new System.Windows.Forms.Button();
            this.CarInformationlabel = new System.Windows.Forms.Label();
            this.OwnerInformationLable = new System.Windows.Forms.Label();
            this.NumberPlatelabel = new System.Windows.Forms.Label();
            this.TypeCarlabel = new System.Windows.Forms.Label();
            this.NumberPlatetextBox = new System.Windows.Forms.TextBox();
            this.FullNamelabel = new System.Windows.Forms.Label();
            this.PhoneNumberlabel = new System.Windows.Forms.Label();
            this.DateTimePickerlabel = new System.Windows.Forms.Label();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FullNametextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberMaskedtextBox = new System.Windows.Forms.MaskedTextBox();
            this.cmbVehicleType = new System.Windows.Forms.ComboBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator5 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.Location = new System.Drawing.Point(15, 326);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CarInformationlabel
            // 
            this.CarInformationlabel.AutoSize = true;
            this.CarInformationlabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInformationlabel.Location = new System.Drawing.Point(290, 20);
            this.CarInformationlabel.Name = "CarInformationlabel";
            this.CarInformationlabel.Size = new System.Drawing.Size(111, 18);
            this.CarInformationlabel.TabIndex = 1;
            this.CarInformationlabel.Text = "مشخصات خودرو";
            // 
            // OwnerInformationLable
            // 
            this.OwnerInformationLable.AutoSize = true;
            this.OwnerInformationLable.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwnerInformationLable.Location = new System.Drawing.Point(290, 203);
            this.OwnerInformationLable.Name = "OwnerInformationLable";
            this.OwnerInformationLable.Size = new System.Drawing.Size(107, 18);
            this.OwnerInformationLable.TabIndex = 2;
            this.OwnerInformationLable.Text = "مشخصات مالک";
            // 
            // NumberPlatelabel
            // 
            this.NumberPlatelabel.AutoSize = true;
            this.NumberPlatelabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberPlatelabel.Location = new System.Drawing.Point(306, 67);
            this.NumberPlatelabel.Name = "NumberPlatelabel";
            this.NumberPlatelabel.Size = new System.Drawing.Size(82, 18);
            this.NumberPlatelabel.TabIndex = 3;
            this.NumberPlatelabel.Text = "شماره پلاک";
            this.NumberPlatelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeCarlabel
            // 
            this.TypeCarlabel.AutoSize = true;
            this.TypeCarlabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCarlabel.Location = new System.Drawing.Point(306, 111);
            this.TypeCarlabel.Name = "TypeCarlabel";
            this.TypeCarlabel.Size = new System.Drawing.Size(68, 18);
            this.TypeCarlabel.TabIndex = 6;
            this.TypeCarlabel.Text = "نوع خودرو";
            // 
            // NumberPlatetextBox
            // 
            this.NumberPlatetextBox.Location = new System.Drawing.Point(15, 64);
            this.NumberPlatetextBox.Name = "NumberPlatetextBox";
            this.NumberPlatetextBox.Size = new System.Drawing.Size(259, 21);
            this.NumberPlatetextBox.TabIndex = 7;
            // 
            // FullNamelabel
            // 
            this.FullNamelabel.AutoSize = true;
            this.FullNamelabel.BackColor = System.Drawing.Color.Transparent;
            this.FullNamelabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNamelabel.Location = new System.Drawing.Point(280, 245);
            this.FullNamelabel.Name = "FullNamelabel";
            this.FullNamelabel.Size = new System.Drawing.Size(121, 18);
            this.FullNamelabel.TabIndex = 8;
            this.FullNamelabel.Text = "نام و نام خانوادگی";
            this.FullNamelabel.Click += new System.EventHandler(this.FullNamelabel_Click);
            // 
            // PhoneNumberlabel
            // 
            this.PhoneNumberlabel.AutoSize = true;
            this.PhoneNumberlabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberlabel.Location = new System.Drawing.Point(286, 280);
            this.PhoneNumberlabel.Name = "PhoneNumberlabel";
            this.PhoneNumberlabel.Size = new System.Drawing.Size(88, 18);
            this.PhoneNumberlabel.TabIndex = 9;
            this.PhoneNumberlabel.Text = "شماره تماس";
            // 
            // DateTimePickerlabel
            // 
            this.DateTimePickerlabel.AutoSize = true;
            this.DateTimePickerlabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerlabel.Location = new System.Drawing.Point(306, 154);
            this.DateTimePickerlabel.Name = "DateTimePickerlabel";
            this.DateTimePickerlabel.Size = new System.Drawing.Size(65, 18);
            this.DateTimePickerlabel.TabIndex = 10;
            this.DateTimePickerlabel.Text = "تاریخ ورود";
            this.DateTimePickerlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(15, 154);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(259, 21);
            this.DateTimePicker.TabIndex = 11;
            this.DateTimePicker.Value = new System.DateTime(2025, 5, 6, 16, 7, 25, 0);
            this.DateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // FullNametextBox
            // 
            this.FullNametextBox.Location = new System.Drawing.Point(12, 242);
            this.FullNametextBox.Name = "FullNametextBox";
            this.FullNametextBox.Size = new System.Drawing.Size(262, 21);
            this.FullNametextBox.TabIndex = 13;
            // 
            // PhoneNumberMaskedtextBox
            // 
            this.PhoneNumberMaskedtextBox.Location = new System.Drawing.Point(15, 281);
            this.PhoneNumberMaskedtextBox.Name = "PhoneNumberMaskedtextBox";
            this.PhoneNumberMaskedtextBox.Size = new System.Drawing.Size(259, 21);
            this.PhoneNumberMaskedtextBox.TabIndex = 14;
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.Items.AddRange(new object[] {
            "سواری",
            "موتورسیکلت",
            "سنگین"});
            this.cmbVehicleType.Location = new System.Drawing.Point(15, 112);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbVehicleType.Size = new System.Drawing.Size(259, 21);
            this.cmbVehicleType.TabIndex = 18;
            this.cmbVehicleType.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleType_SelectedIndexChanged);
            this.cmbVehicleType.DropDownStyleChanged += new System.EventHandler(this.cmbVehicleType_DropDownStyleChanged);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.NumberPlatetextBox;
            this.requiredFieldValidator1.ErrorMessage = null;
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.cmbVehicleType;
            this.requiredFieldValidator2.ErrorMessage = null;
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.DateTimePicker;
            this.requiredFieldValidator3.ErrorMessage = null;
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.FullNametextBox;
            this.requiredFieldValidator4.ErrorMessage = null;
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // requiredFieldValidator5
            // 
            this.requiredFieldValidator5.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator5.ControlToValidate = this.PhoneNumberMaskedtextBox;
            this.requiredFieldValidator5.ErrorMessage = null;
            this.requiredFieldValidator5.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator5.Icon")));
            // 
            // frmEntryNewCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(401, 364);
            this.Controls.Add(this.cmbVehicleType);
            this.Controls.Add(this.PhoneNumberMaskedtextBox);
            this.Controls.Add(this.FullNametextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DateTimePickerlabel);
            this.Controls.Add(this.PhoneNumberlabel);
            this.Controls.Add(this.FullNamelabel);
            this.Controls.Add(this.NumberPlatetextBox);
            this.Controls.Add(this.TypeCarlabel);
            this.Controls.Add(this.NumberPlatelabel);
            this.Controls.Add(this.OwnerInformationLable);
            this.Controls.Add(this.CarInformationlabel);
            this.Controls.Add(this.btnSubmit);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmEntryNewCar";
            this.Text = "frmEntryNewCar";
            this.Load += new System.EventHandler(this.frmEntryNewCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label CarInformationlabel;
        private System.Windows.Forms.Label OwnerInformationLable;
        private System.Windows.Forms.Label NumberPlatelabel;
        private System.Windows.Forms.Label TypeCarlabel;
        private System.Windows.Forms.TextBox NumberPlatetextBox;
        private System.Windows.Forms.Label FullNamelabel;
        private System.Windows.Forms.Label PhoneNumberlabel;
        private System.Windows.Forms.Label DateTimePickerlabel;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox FullNametextBox;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator5;
        private System.Windows.Forms.MaskedTextBox PhoneNumberMaskedtextBox;
        private System.Windows.Forms.ComboBox cmbVehicleType;
    }
}