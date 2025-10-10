namespace Parking.App
{
    partial class frmExitCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExitCar));
            this.label1 = new System.Windows.Forms.Label();
            this.CarInformation = new System.Windows.Forms.Label();
            this.ExitDate = new System.Windows.Forms.Label();
            this.ExitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.LBLCost = new System.Windows.Forms.Label();
            this.txtNumberPlate = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.BTNCalculate = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.LBLNumberPlate = new System.Windows.Forms.Label();
            this.LBLOwnerName = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generalInformationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.parking_DBDataSet1 = new Parking.App.Parking_DBDataSet1();
            this.generalInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LBLDuration = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator3 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator4 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.LBLPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.generalInformationTableAdapter = new Parking.App.Parking_DBDataSet1TableAdapters.GeneralInformationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalInformationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalInformationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // CarInformation
            // 
            this.CarInformation.AutoSize = true;
            this.CarInformation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CarInformation.Location = new System.Drawing.Point(381, 9);
            this.CarInformation.Name = "CarInformation";
            this.CarInformation.Size = new System.Drawing.Size(111, 18);
            this.CarInformation.TabIndex = 1;
            this.CarInformation.Text = "مشخصات خوردو";
            this.CarInformation.Click += new System.EventHandler(this.CarInformation_Click);
            // 
            // ExitDate
            // 
            this.ExitDate.AutoSize = true;
            this.ExitDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitDate.Location = new System.Drawing.Point(421, 125);
            this.ExitDate.Name = "ExitDate";
            this.ExitDate.Size = new System.Drawing.Size(71, 18);
            this.ExitDate.TabIndex = 8;
            this.ExitDate.Text = "زمان خروج";
            // 
            // ExitDateTimePicker
            // 
            this.ExitDateTimePicker.Location = new System.Drawing.Point(12, 125);
            this.ExitDateTimePicker.Name = "ExitDateTimePicker";
            this.ExitDateTimePicker.Size = new System.Drawing.Size(390, 21);
            this.ExitDateTimePicker.TabIndex = 9;
            // 
            // LBLCost
            // 
            this.LBLCost.AutoSize = true;
            this.LBLCost.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLCost.Location = new System.Drawing.Point(438, 194);
            this.LBLCost.Name = "LBLCost";
            this.LBLCost.Size = new System.Drawing.Size(42, 18);
            this.LBLCost.TabIndex = 10;
            this.LBLCost.Text = "هزینه";
            // 
            // txtNumberPlate
            // 
            this.txtNumberPlate.Location = new System.Drawing.Point(12, 59);
            this.txtNumberPlate.Name = "txtNumberPlate";
            this.txtNumberPlate.Size = new System.Drawing.Size(390, 21);
            this.txtNumberPlate.TabIndex = 7;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(12, 191);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(390, 21);
            this.txtCost.TabIndex = 11;
            this.txtCost.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // BTNCalculate
            // 
            this.BTNCalculate.BackColor = System.Drawing.Color.Moccasin;
            this.BTNCalculate.Location = new System.Drawing.Point(12, 157);
            this.BTNCalculate.Name = "BTNCalculate";
            this.BTNCalculate.Size = new System.Drawing.Size(75, 23);
            this.BTNCalculate.TabIndex = 12;
            this.BTNCalculate.Text = "محاسبه";
            this.BTNCalculate.UseVisualStyleBackColor = false;
            this.BTNCalculate.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.BackColor = System.Drawing.Color.Moccasin;
            this.BTNExit.Location = new System.Drawing.Point(12, 218);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(75, 23);
            this.BTNExit.TabIndex = 13;
            this.BTNExit.Text = "خروج";
            this.BTNExit.UseVisualStyleBackColor = false;
            this.BTNExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LBLNumberPlate
            // 
            this.LBLNumberPlate.AutoSize = true;
            this.LBLNumberPlate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLNumberPlate.Location = new System.Drawing.Point(410, 62);
            this.LBLNumberPlate.Name = "LBLNumberPlate";
            this.LBLNumberPlate.Size = new System.Drawing.Size(82, 18);
            this.LBLNumberPlate.TabIndex = 14;
            this.LBLNumberPlate.Text = "شماره پلاک";
            // 
            // LBLOwnerName
            // 
            this.LBLOwnerName.AutoSize = true;
            this.LBLOwnerName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLOwnerName.Location = new System.Drawing.Point(431, 35);
            this.LBLOwnerName.Name = "LBLOwnerName";
            this.LBLOwnerName.Size = new System.Drawing.Size(61, 18);
            this.LBLOwnerName.TabIndex = 15;
            this.LBLOwnerName.Text = "نام مالک";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(12, 32);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(390, 21);
            this.txtOwnerName.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.generalInformationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.Size = new System.Drawing.Size(405, 150);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumn1.HeaderText = "نام و نام خانوادگی";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "تلفن همراه";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NumberPlate";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره پلاک";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VehicleType";
            this.dataGridViewTextBoxColumn4.HeaderText = "نوع خودرو";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "EntryDate";
            this.dataGridViewTextBoxColumn5.HeaderText = "تاریخ ورودی";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 62;
            // 
            // generalInformationBindingSource1
            // 
            this.generalInformationBindingSource1.DataMember = "GeneralInformation";
            this.generalInformationBindingSource1.DataSource = this.parking_DBDataSet1;
            // 
            // parking_DBDataSet1
            // 
            this.parking_DBDataSet1.DataSetName = "Parking_DBDataSet1";
            this.parking_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LBLDuration
            // 
            this.LBLDuration.AutoSize = true;
            this.LBLDuration.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLDuration.Location = new System.Drawing.Point(421, 162);
            this.LBLDuration.Name = "LBLDuration";
            this.LBLDuration.Size = new System.Drawing.Size(76, 18);
            this.LBLDuration.TabIndex = 19;
            this.LBLDuration.Text = "مدت حضور";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(174, 159);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(228, 21);
            this.txtDuration.TabIndex = 20;
            this.txtDuration.TextChanged += new System.EventHandler(this.txtDuration_TextChanged);
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtOwnerName;
            this.requiredFieldValidator1.ErrorMessage = null;
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.txtNumberPlate;
            this.requiredFieldValidator2.ErrorMessage = null;
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // requiredFieldValidator3
            // 
            this.requiredFieldValidator3.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator3.ControlToValidate = this.ExitDateTimePicker;
            this.requiredFieldValidator3.ErrorMessage = null;
            this.requiredFieldValidator3.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator3.Icon")));
            // 
            // requiredFieldValidator4
            // 
            this.requiredFieldValidator4.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator4.ControlToValidate = this.txtCost;
            this.requiredFieldValidator4.ErrorMessage = null;
            this.requiredFieldValidator4.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator4.Icon")));
            // 
            // LBLPhoneNumber
            // 
            this.LBLPhoneNumber.AutoSize = true;
            this.LBLPhoneNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPhoneNumber.Location = new System.Drawing.Point(410, 97);
            this.LBLPhoneNumber.Name = "LBLPhoneNumber";
            this.LBLPhoneNumber.Size = new System.Drawing.Size(77, 18);
            this.LBLPhoneNumber.TabIndex = 21;
            this.LBLPhoneNumber.Text = "تلفن همراه";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(14, 94);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(390, 21);
            this.txtPhoneNumber.TabIndex = 22;
            // 
            // generalInformationTableAdapter
            // 
            this.generalInformationTableAdapter.ClearBeforeFill = true;
            // 
            // frmExitCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(492, 414);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.LBLPhoneNumber);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.LBLDuration);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.LBLOwnerName);
            this.Controls.Add(this.LBLNumberPlate);
            this.Controls.Add(this.BTNExit);
            this.Controls.Add(this.BTNCalculate);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.LBLCost);
            this.Controls.Add(this.ExitDateTimePicker);
            this.Controls.Add(this.ExitDate);
            this.Controls.Add(this.txtNumberPlate);
            this.Controls.Add(this.CarInformation);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmExitCar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم خروج";
            this.Load += new System.EventHandler(this.frmExitCar_Load);
            this.Click += new System.EventHandler(this.frmExitCar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalInformationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parking_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generalInformationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CarInformation;
        private System.Windows.Forms.Label ExitDate;
        private System.Windows.Forms.DateTimePicker ExitDateTimePicker;
        private System.Windows.Forms.Label LBLCost;
        private System.Windows.Forms.TextBox txtNumberPlate;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button BTNCalculate;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.Label LBLNumberPlate;
        private System.Windows.Forms.Label LBLOwnerName;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.BindingSource generalInformationBindingSource;

        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator3;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator4;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberPlateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LBLDuration;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label LBLPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private Parking_DBDataSet1 parking_DBDataSet1;
        private System.Windows.Forms.BindingSource generalInformationBindingSource1;
        private Parking_DBDataSet1TableAdapters.GeneralInformationTableAdapter generalInformationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}