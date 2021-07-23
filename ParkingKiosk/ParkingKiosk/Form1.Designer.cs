namespace ParkingKiosk
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.customerOrStaff = new System.Windows.Forms.GroupBox();
            this.rbCustomer = new System.Windows.Forms.RadioButton();
            this.rbStaff = new System.Windows.Forms.RadioButton();
            this.bMoveToHours = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.HoursParked = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelParkingInfo = new System.Windows.Forms.Label();
            this.labelParkingAmount = new System.Windows.Forms.Label();
            this.bCalculate = new System.Windows.Forms.Button();
            this.customerOrStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(220, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "NO ONE CAN PARK HERE FOR MORE THAN 24 HOURS";
            // 
            // customerOrStaff
            // 
            this.customerOrStaff.Controls.Add(this.rbStaff);
            this.customerOrStaff.Controls.Add(this.rbCustomer);
            this.customerOrStaff.Location = new System.Drawing.Point(257, 193);
            this.customerOrStaff.Name = "customerOrStaff";
            this.customerOrStaff.Size = new System.Drawing.Size(718, 102);
            this.customerOrStaff.TabIndex = 1;
            this.customerOrStaff.TabStop = false;
            this.customerOrStaff.Text = "Select One";
            // 
            // rbCustomer
            // 
            this.rbCustomer.AutoSize = true;
            this.rbCustomer.Location = new System.Drawing.Point(36, 46);
            this.rbCustomer.Name = "rbCustomer";
            this.rbCustomer.Size = new System.Drawing.Size(135, 29);
            this.rbCustomer.TabIndex = 0;
            this.rbCustomer.TabStop = true;
            this.rbCustomer.Text = "Customer";
            this.rbCustomer.UseVisualStyleBackColor = true;
            // 
            // rbStaff
            // 
            this.rbStaff.AutoSize = true;
            this.rbStaff.Location = new System.Drawing.Point(436, 46);
            this.rbStaff.Name = "rbStaff";
            this.rbStaff.Size = new System.Drawing.Size(87, 29);
            this.rbStaff.TabIndex = 1;
            this.rbStaff.TabStop = true;
            this.rbStaff.Text = "Staff";
            this.rbStaff.UseVisualStyleBackColor = true;
            // 
            // bMoveToHours
            // 
            this.bMoveToHours.Location = new System.Drawing.Point(533, 320);
            this.bMoveToHours.Name = "bMoveToHours";
            this.bMoveToHours.Size = new System.Drawing.Size(164, 46);
            this.bMoveToHours.TabIndex = 2;
            this.bMoveToHours.Text = "Next";
            this.bMoveToHours.UseVisualStyleBackColor = true;
            this.bMoveToHours.Click += new System.EventHandler(this.bMoveToHours_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(865, 367);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(164, 46);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // HoursParked
            // 
            this.HoursParked.AutoSize = true;
            this.HoursParked.Location = new System.Drawing.Point(285, 553);
            this.HoursParked.Name = "HoursParked";
            this.HoursParked.Size = new System.Drawing.Size(143, 25);
            this.HoursParked.TabIndex = 5;
            this.HoursParked.Text = "Hours Parked";
            // 
            // tbHours
            // 
            this.tbHours.Enabled = false;
            this.tbHours.Location = new System.Drawing.Point(499, 550);
            this.tbHours.MaxLength = 2;
            this.tbHours.Name = "tbHours";
            this.tbHours.Size = new System.Drawing.Size(215, 31);
            this.tbHours.TabIndex = 6;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(984, 718);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(199, 65);
            this.bExit.TabIndex = 7;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Parking Amount";
            // 
            // labelParkingInfo
            // 
            this.labelParkingInfo.AutoSize = true;
            this.labelParkingInfo.Location = new System.Drawing.Point(285, 378);
            this.labelParkingInfo.Name = "labelParkingInfo";
            this.labelParkingInfo.Size = new System.Drawing.Size(0, 25);
            this.labelParkingInfo.TabIndex = 10;
            // 
            // labelParkingAmount
            // 
            this.labelParkingAmount.AutoSize = true;
            this.labelParkingAmount.Location = new System.Drawing.Point(577, 675);
            this.labelParkingAmount.Name = "labelParkingAmount";
            this.labelParkingAmount.Size = new System.Drawing.Size(0, 25);
            this.labelParkingAmount.TabIndex = 11;
            // 
            // bCalculate
            // 
            this.bCalculate.Enabled = false;
            this.bCalculate.Location = new System.Drawing.Point(523, 599);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(155, 46);
            this.bCalculate.TabIndex = 12;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.bCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 795);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.labelParkingAmount);
            this.Controls.Add(this.labelParkingInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tbHours);
            this.Controls.Add(this.HoursParked);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bMoveToHours);
            this.Controls.Add(this.customerOrStaff);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Parking Kiosk";
            this.customerOrStaff.ResumeLayout(false);
            this.customerOrStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox customerOrStaff;
        private System.Windows.Forms.RadioButton rbStaff;
        private System.Windows.Forms.RadioButton rbCustomer;
        private System.Windows.Forms.Button bMoveToHours;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label HoursParked;
        private System.Windows.Forms.TextBox tbHours;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelParkingInfo;
        private System.Windows.Forms.Label labelParkingAmount;
        private System.Windows.Forms.Button bCalculate;
    }
}

