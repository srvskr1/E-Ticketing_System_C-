namespace eticketing
{
    partial class CalculateFareTrain
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbDeparture = new System.Windows.Forms.ComboBox();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbAge = new System.Windows.Forms.ComboBox();
            this.cmbNoOfSeat = new System.Windows.Forms.ComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTFare = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Departure";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(47, 124);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Destination";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(49, 165);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Class";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 205);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(33, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Age";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(49, 246);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "No Of Seat";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(164, 294);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(121, 23);
            this.metroButton1.TabIndex = 5;
            this.metroButton1.Text = "Calculate Fare";
            this.metroButton1.UseSelectable = true;
            // 
            // cmbDeparture
            // 
            this.cmbDeparture.FormattingEnabled = true;
            this.cmbDeparture.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Khulna",
            "Barishal",
            "Mymensingh",
            "Rajshahi",
            "Sylhe",
            "Rangpur"});
            this.cmbDeparture.Location = new System.Drawing.Point(164, 82);
            this.cmbDeparture.Name = "cmbDeparture";
            this.cmbDeparture.Size = new System.Drawing.Size(121, 21);
            this.cmbDeparture.TabIndex = 16;
            // 
            // cmbDestination
            // 
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong",
            "Khulna",
            "Barishal",
            "Mymensingh",
            "Rajshahi",
            "Sylhe",
            "Rangpur"});
            this.cmbDestination.Location = new System.Drawing.Point(164, 124);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(121, 21);
            this.cmbDestination.TabIndex = 17;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Items.AddRange(new object[] {
            "1st Class",
            "AC",
            "Non Ac"});
            this.cmbClass.Location = new System.Drawing.Point(164, 163);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 18;
            // 
            // cmbAge
            // 
            this.cmbAge.FormattingEnabled = true;
            this.cmbAge.Items.AddRange(new object[] {
            "Adult",
            "Child"});
            this.cmbAge.Location = new System.Drawing.Point(164, 203);
            this.cmbAge.Name = "cmbAge";
            this.cmbAge.Size = new System.Drawing.Size(121, 21);
            this.cmbAge.TabIndex = 19;
            // 
            // cmbNoOfSeat
            // 
            this.cmbNoOfSeat.FormattingEnabled = true;
            this.cmbNoOfSeat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbNoOfSeat.Location = new System.Drawing.Point(164, 244);
            this.cmbNoOfSeat.Name = "cmbNoOfSeat";
            this.cmbNoOfSeat.Size = new System.Drawing.Size(121, 21);
            this.cmbNoOfSeat.TabIndex = 20;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(49, 340);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(65, 19);
            this.metroLabel6.TabIndex = 21;
            this.metroLabel6.Text = "Total Fare";
            // 
            // txtTFare
            // 
            // 
            // 
            // 
            this.txtTFare.CustomButton.Image = null;
            this.txtTFare.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtTFare.CustomButton.Name = "";
            this.txtTFare.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTFare.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTFare.CustomButton.TabIndex = 1;
            this.txtTFare.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTFare.CustomButton.UseSelectable = true;
            this.txtTFare.CustomButton.Visible = false;
            this.txtTFare.Lines = new string[0];
            this.txtTFare.Location = new System.Drawing.Point(164, 340);
            this.txtTFare.MaxLength = 32767;
            this.txtTFare.Name = "txtTFare";
            this.txtTFare.PasswordChar = '\0';
            this.txtTFare.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTFare.SelectedText = "";
            this.txtTFare.SelectionLength = 0;
            this.txtTFare.SelectionStart = 0;
            this.txtTFare.ShortcutsEnabled = true;
            this.txtTFare.Size = new System.Drawing.Size(121, 23);
            this.txtTFare.TabIndex = 22;
            this.txtTFare.UseSelectable = true;
            this.txtTFare.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTFare.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Train Fare Calculation";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(652, 407);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(62, 26);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CalculateFareTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 456);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTFare);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.cmbNoOfSeat);
            this.Controls.Add(this.cmbAge);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.cmbDestination);
            this.Controls.Add(this.cmbDeparture);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "CalculateFareTrain";
            this.Tag = "tdt,gchv";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ComboBox cmbDeparture;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbAge;
        private System.Windows.Forms.ComboBox cmbNoOfSeat;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTFare;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton btnBack;
    }
}