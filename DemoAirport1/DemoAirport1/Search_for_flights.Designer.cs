namespace DemoAirport1
{
    partial class Search_for_flights
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.Outbound1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.To1 = new System.Windows.Forms.Label();
            this.From1 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.Oneway = new System.Windows.Forms.RadioButton();
            this.Return = new System.Windows.Forms.RadioButton();
            this.cb3 = new System.Windows.Forms.ComboBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Outbound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Check3 = new System.Windows.Forms.CheckBox();
            this.Return3 = new System.Windows.Forms.Label();
            this.Display2 = new System.Windows.Forms.CheckBox();
            this.booking = new System.Windows.Forms.GroupBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.Passengers = new System.Windows.Forms.Label();
            this.Comfirm = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stops = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.From2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stops2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.booking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(350, 91);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker1.TabIndex = 25;

            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(476, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Return";

            // Outbound1
            // 
            this.Outbound1.AutoSize = true;
            this.Outbound1.Location = new System.Drawing.Point(268, 97);
            this.Outbound1.Name = "Outbound1";
            this.Outbound1.Size = new System.Drawing.Size(65, 16);
            this.Outbound1.TabIndex = 23;
            this.Outbound1.Text = "Outbound";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cabin type";
            // 
            // To1
            // 
            this.To1.AutoSize = true;
            this.To1.Location = new System.Drawing.Point(268, 45);
            this.To1.Name = "To1";
            this.To1.Size = new System.Drawing.Size(24, 16);
            this.To1.TabIndex = 21;
            this.To1.Text = "To";
            // 
            // From1
            // 
            this.From1.AutoSize = true;
            this.From1.Location = new System.Drawing.Point(36, 45);
            this.From1.Name = "From1";
            this.From1.Size = new System.Drawing.Size(38, 16);
            this.From1.TabIndex = 20;
            this.From1.Text = "From";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(667, 85);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(92, 29);
            this.Search.TabIndex = 19;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Oneway
            // 
            this.Oneway.AutoSize = true;
            this.Oneway.Location = new System.Drawing.Point(133, 94);
            this.Oneway.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Oneway.Name = "Oneway";
            this.Oneway.Size = new System.Drawing.Size(80, 20);
            this.Oneway.TabIndex = 18;
            this.Oneway.TabStop = true;
            this.Oneway.Text = "One way";
            this.Oneway.UseVisualStyleBackColor = true;
            this.Oneway.CheckedChanged += new System.EventHandler(this.Oneway_CheckedChanged);
            // 
            // Return
            // 
            this.Return.AutoSize = true;
            this.Return.Location = new System.Drawing.Point(5, 93);
            this.Return.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Return.Name = "Return";
            this.Return.Size = new System.Drawing.Size(67, 20);
            this.Return.TabIndex = 17;
            this.Return.TabStop = true;
            this.Return.Text = "Return";
            this.Return.UseVisualStyleBackColor = true;
            this.Return.CheckedChanged += new System.EventHandler(this.Return_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.FormattingEnabled = true;
            this.cb3.Location = new System.Drawing.Point(572, 38);
            this.cb3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(108, 24);
            this.cb3.TabIndex = 16;
            // 
            // cb2
            // 
            this.cb2.FormattingEnabled = true;
            this.cb2.Location = new System.Drawing.Point(329, 38);
            this.cb2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(108, 24);
            this.cb2.TabIndex = 15;
            // 
            // cb1
            // 
            this.cb1.FormattingEnabled = true;
            this.cb1.Location = new System.Drawing.Point(110, 38);
            this.cb1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(108, 24);
            this.cb1.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Outbound1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.To1);
            this.groupBox1.Controls.Add(this.From1);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.Oneway);
            this.groupBox1.Controls.Add(this.Return);
            this.groupBox1.Controls.Add(this.cb3);
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.cb1);
            this.groupBox1.Location = new System.Drawing.Point(104, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(947, 138);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Parameters";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(533, 91);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker2.TabIndex = 26;
            // 
            // Outbound
            // 
            this.Outbound.AutoSize = true;
            this.Outbound.Location = new System.Drawing.Point(106, 143);
            this.Outbound.Name = "Outbound";
            this.Outbound.Size = new System.Drawing.Size(138, 16);
            this.Outbound.TabIndex = 27;
            this.Outbound.Text = "Outbound flight details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 28;
            // 
            // Check3
            // 
            this.Check3.AutoSize = true;
            this.Check3.Location = new System.Drawing.Point(584, 142);
            this.Check3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check3.Name = "Check3";
            this.Check3.Size = new System.Drawing.Size(238, 20);
            this.Check3.TabIndex = 29;
            this.Check3.Text = "Displays three day before and after";
            this.Check3.UseVisualStyleBackColor = true;
            // 
            // Return3
            // 
            this.Return3.AutoSize = true;
            this.Return3.Location = new System.Drawing.Point(106, 303);
            this.Return3.Name = "Return3";
            this.Return3.Size = new System.Drawing.Size(119, 16);
            this.Return3.TabIndex = 31;
            this.Return3.Text = "Return flight details";
            // 
            // Display2
            // 
            this.Display2.AutoSize = true;
            this.Display2.Location = new System.Drawing.Point(584, 300);
            this.Display2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Display2.Name = "Display2";
            this.Display2.Size = new System.Drawing.Size(190, 20);
            this.Display2.TabIndex = 32;
            this.Display2.Text = "Displays three days before";
            this.Display2.UseVisualStyleBackColor = true;
            // 
            // booking
            // 
            this.booking.Controls.Add(this.txtPass);
            this.booking.Controls.Add(this.Passengers);
            this.booking.Controls.Add(this.Comfirm);
            this.booking.Controls.Add(this.button1);
            this.booking.Location = new System.Drawing.Point(433, 462);
            this.booking.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booking.Name = "booking";
            this.booking.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.booking.Size = new System.Drawing.Size(407, 92);
            this.booking.TabIndex = 34;
            this.booking.TabStop = false;
            this.booking.Text = "Confirm booking for";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(44, 38);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(89, 22);
            this.txtPass.TabIndex = 31;
            // 
            // Passengers
            // 
            this.Passengers.AutoSize = true;
            this.Passengers.Location = new System.Drawing.Point(139, 38);
            this.Passengers.Name = "Passengers";
            this.Passengers.Size = new System.Drawing.Size(80, 16);
            this.Passengers.TabIndex = 27;
            this.Passengers.Text = "Passengers";
            // 
            // Comfirm
            // 
            this.Comfirm.AutoSize = true;
            this.Comfirm.Location = new System.Drawing.Point(274, 35);
            this.Comfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Comfirm.Name = "Comfirm";
            this.Comfirm.Size = new System.Drawing.Size(91, 20);
            this.Comfirm.TabIndex = 30;
            this.Comfirm.Text = "Book flight";
            this.Comfirm.UseVisualStyleBackColor = true;
            this.Comfirm.CheckedChanged += new System.EventHandler(this.Comfirm_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 85);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 19;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Gold;
            this.Exit.Location = new System.Drawing.Point(845, 498);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 29);
            this.Exit.TabIndex = 27;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.From,
            this.To,
            this.Date,
            this.Time,
            this.flight,
            this.cabin,
            this.stops});
            this.dataGridView1.Location = new System.Drawing.Point(104, 162);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(947, 134);
            this.dataGridView1.TabIndex = 35;
    
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 8;
            this.From.Name = "From";
            this.From.Width = 120;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 8;
            this.To.Name = "To";
            this.To.Width = 120;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 8;
            this.Time.Name = "Time";
            this.Time.Width = 120;
            // 
            // flight
            // 
            this.flight.HeaderText = "Flights number";
            this.flight.MinimumWidth = 8;
            this.flight.Name = "flight";
            this.flight.Width = 120;
            // 
            // cabin
            // 
            this.cabin.HeaderText = "Cabin price";
            this.cabin.MinimumWidth = 8;
            this.cabin.Name = "cabin";
            this.cabin.Width = 120;
            // 
            // stops
            // 
            this.stops.HeaderText = "Number of stops";
            this.stops.MinimumWidth = 8;
            this.stops.Name = "stops";
            this.stops.Width = 120;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.From2,
            this.To2,
            this.Date2,
            this.Time2,
            this.flight2,
            this.dataGridViewTextBoxColumn6,
            this.stops2});
            this.dataGridView2.Location = new System.Drawing.Point(104, 324);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(947, 134);
            this.dataGridView2.TabIndex = 36;
            // 
            // From2
            // 
            this.From2.HeaderText = "From";
            this.From2.MinimumWidth = 8;
            this.From2.Name = "From2";
            this.From2.Width = 120;
            // 
            // To2
            // 
            this.To2.HeaderText = "To";
            this.To2.MinimumWidth = 8;
            this.To2.Name = "To2";
            this.To2.Width = 120;
            // 
            // Date2
            // 
            this.Date2.HeaderText = "Date";
            this.Date2.MinimumWidth = 8;
            this.Date2.Name = "Date2";
            this.Date2.Width = 120;
            // 
            // Time2
            // 
            this.Time2.HeaderText = "Time";
            this.Time2.MinimumWidth = 8;
            this.Time2.Name = "Time2";
            this.Time2.Width = 120;
            // 
            // flight2
            // 
            this.flight2.HeaderText = "Flights number";
            this.flight2.MinimumWidth = 8;
            this.flight2.Name = "flight2";
            this.flight2.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cabin price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // stops2
            // 
            this.stops2.HeaderText = "Number of stops";
            this.stops2.MinimumWidth = 8;
            this.stops2.Name = "stops2";
            this.stops2.Width = 120;
            // 
            // Search_for_flights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.booking);
            this.Controls.Add(this.Display2);
            this.Controls.Add(this.Return3);
            this.Controls.Add(this.Check3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Outbound);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Search_for_flights";
            this.Text = "Search_for_flights";
            this.Load += new System.EventHandler(this.Search_for_flights_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.booking.ResumeLayout(false);
            this.booking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Outbound1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label To1;
        private System.Windows.Forms.Label From1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.RadioButton Oneway;
        private System.Windows.Forms.RadioButton Return;
        private System.Windows.Forms.ComboBox cb3;
        private System.Windows.Forms.ComboBox cb2;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Outbound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Check3;
        private System.Windows.Forms.Label Return3;
        private System.Windows.Forms.CheckBox Display2;
        private System.Windows.Forms.GroupBox booking;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label Passengers;
        private System.Windows.Forms.CheckBox Comfirm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabin;
        private System.Windows.Forms.DataGridViewTextBoxColumn stops;
        private System.Windows.Forms.DataGridViewTextBoxColumn From2;
        private System.Windows.Forms.DataGridViewTextBoxColumn To2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time2;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn stops2;
    }
}