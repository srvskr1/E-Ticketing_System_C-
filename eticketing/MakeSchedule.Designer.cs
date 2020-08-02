namespace eticketing
{
    partial class MakeSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cmbDparttime = new MetroFramework.Controls.MetroLabel();
            this.mgr = new MetroFramework.Controls.MetroGrid();
            this.departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transportation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.journeydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departuretime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbdpart = new System.Windows.Forms.ComboBox();
            this.cmbdesti = new System.Windows.Forms.ComboBox();
            this.cmbtrans = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbdepartime = new System.Windows.Forms.ComboBox();
            this.Create = new MetroFramework.Controls.MetroButton();
            this.cmbArrivalTime = new MetroFramework.Controls.MetroLabel();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.btnDelet = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.mgr)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Departure";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(41, 89);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Destination";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 137);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(93, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Transportation";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(41, 179);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Date";
            // 
            // cmbDparttime
            // 
            this.cmbDparttime.AutoSize = true;
            this.cmbDparttime.Location = new System.Drawing.Point(41, 219);
            this.cmbDparttime.Name = "cmbDparttime";
            this.cmbDparttime.Size = new System.Drawing.Size(102, 19);
            this.cmbDparttime.TabIndex = 4;
            this.cmbDparttime.Text = "Departure Time";
            // 
            // mgr
            // 
            this.mgr.AllowUserToAddRows = false;
            this.mgr.AllowUserToDeleteRows = false;
            this.mgr.AllowUserToResizeRows = false;
            this.mgr.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mgr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgr.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departure,
            this.destination,
            this.transportation,
            this.journeydate,
            this.departuretime});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgr.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgr.EnableHeadersVisualStyles = false;
            this.mgr.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgr.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgr.Location = new System.Drawing.Point(-1, 309);
            this.mgr.Name = "mgr";
            this.mgr.ReadOnly = true;
            this.mgr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgr.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgr.Size = new System.Drawing.Size(823, 212);
            this.mgr.TabIndex = 5;
            // 
            // departure
            // 
            this.departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departure.DataPropertyName = "departure";
            this.departure.HeaderText = "Departure";
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            // 
            // destination
            // 
            this.destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.destination.DataPropertyName = "destination";
            this.destination.HeaderText = "Destination";
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            // 
            // transportation
            // 
            this.transportation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.transportation.DataPropertyName = "transportation";
            this.transportation.HeaderText = "Transportation";
            this.transportation.Name = "transportation";
            this.transportation.ReadOnly = true;
            // 
            // journeydate
            // 
            this.journeydate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.journeydate.DataPropertyName = "date";
            this.journeydate.HeaderText = "Journey Date";
            this.journeydate.Name = "journeydate";
            this.journeydate.ReadOnly = true;
            // 
            // departuretime
            // 
            this.departuretime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departuretime.DataPropertyName = "departuretime";
            this.departuretime.HeaderText = "Departure Time";
            this.departuretime.Name = "departuretime";
            this.departuretime.ReadOnly = true;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(729, 538);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(72, 29);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Back";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbdpart
            // 
            this.cmbdpart.FormattingEnabled = true;
            this.cmbdpart.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong"});
            this.cmbdpart.Location = new System.Drawing.Point(152, 48);
            this.cmbdpart.Name = "cmbdpart";
            this.cmbdpart.Size = new System.Drawing.Size(204, 21);
            this.cmbdpart.TabIndex = 7;
            this.cmbdpart.SelectedIndexChanged += new System.EventHandler(this.cmbdpart_SelectedIndexChanged);
            // 
            // cmbdesti
            // 
            this.cmbdesti.FormattingEnabled = true;
            this.cmbdesti.Items.AddRange(new object[] {
            "Dhaka",
            "Chittagong"});
            this.cmbdesti.Location = new System.Drawing.Point(152, 89);
            this.cmbdesti.Name = "cmbdesti";
            this.cmbdesti.Size = new System.Drawing.Size(204, 21);
            this.cmbdesti.TabIndex = 8;
            // 
            // cmbtrans
            // 
            this.cmbtrans.FormattingEnabled = true;
            this.cmbtrans.Items.AddRange(new object[] {
            "Bus",
            "Train"});
            this.cmbtrans.Location = new System.Drawing.Point(152, 137);
            this.cmbtrans.Name = "cmbtrans";
            this.cmbtrans.Size = new System.Drawing.Size(204, 21);
            this.cmbtrans.TabIndex = 9;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(152, 179);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(204, 22);
            this.dtpDate.TabIndex = 10;
            // 
            // cmbdepartime
            // 
            this.cmbdepartime.FormattingEnabled = true;
            this.cmbdepartime.Items.AddRange(new object[] {
            "08:00:00",
            "09:00:00",
            "12:00:00",
            "14:00:00",
            "16:00:00",
            "17:00:00"});
            this.cmbdepartime.Location = new System.Drawing.Point(152, 219);
            this.cmbdepartime.Name = "cmbdepartime";
            this.cmbdepartime.Size = new System.Drawing.Size(204, 21);
            this.cmbdepartime.TabIndex = 11;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(436, 260);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 12;
            this.Create.Text = "Create";
            this.Create.UseSelectable = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // cmbArrivalTime
            // 
            this.cmbArrivalTime.AutoSize = true;
            this.cmbArrivalTime.Location = new System.Drawing.Point(41, 260);
            this.cmbArrivalTime.Name = "cmbArrivalTime";
            this.cmbArrivalTime.Size = new System.Drawing.Size(80, 19);
            this.cmbArrivalTime.TabIndex = 13;
            this.cmbArrivalTime.Text = "Arrival Time";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "08:00:00",
            "09:00:00",
            "12:00:00",
            "14:00:00",
            "16:00:00",
            "17:00:00"});
            this.comboBox5.Location = new System.Drawing.Point(152, 260);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(204, 21);
            this.comboBox5.TabIndex = 14;
            // 
            // btnDelet
            // 
            this.btnDelet.Location = new System.Drawing.Point(543, 260);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(69, 23);
            this.btnDelet.TabIndex = 15;
            this.btnDelet.Text = "Delete";
            this.btnDelet.UseSelectable = true;
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
            // 
            // MakeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 573);
            this.Controls.Add(this.btnDelet);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.cmbArrivalTime);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.cmbdepartime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbtrans);
            this.Controls.Add(this.cmbdesti);
            this.Controls.Add(this.cmbdpart);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.mgr);
            this.Controls.Add(this.cmbDparttime);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "MakeSchedule";
            this.Load += new System.EventHandler(this.MakeSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel cmbDparttime;
        private MetroFramework.Controls.MetroGrid mgr;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ComboBox cmbdpart;
        private System.Windows.Forms.ComboBox cmbdesti;
        private System.Windows.Forms.ComboBox cmbtrans;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbdepartime;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn transportation;
        private System.Windows.Forms.DataGridViewTextBoxColumn journeydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn departuretime;
        private MetroFramework.Controls.MetroButton Create;
        private MetroFramework.Controls.MetroLabel cmbArrivalTime;
        private System.Windows.Forms.ComboBox comboBox5;
        private MetroFramework.Controls.MetroButton btnDelet;
    }
}