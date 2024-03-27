namespace DemoAirport1
{
    partial class Booking_confirmation
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
            this.Outbound = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Countries = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.Phonebook = new System.Windows.Forms.TextBox();
            this.BD = new System.Windows.Forms.DateTimePicker();
            this.Passportbook = new System.Windows.Forms.TextBox();
            this.Lastnamebook = new System.Windows.Forms.TextBox();
            this.Firstnamebook = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.Passportcountry = new System.Windows.Forms.Label();
            this.Passportnumber = new System.Windows.Forms.Label();
            this.Birthday = new System.Windows.Forms.Label();
            this.Lastname = new System.Windows.Forms.Label();
            this.Firstame2 = new System.Windows.Forms.Label();
            this.Passengerlist = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Firstnamebook2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastnamebook2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthdate2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passportbook2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Countries2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonebook2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outbound.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // Outbound
            // 
            this.Outbound.Controls.Add(this.label15);
            this.Outbound.Controls.Add(this.label14);
            this.Outbound.Controls.Add(this.label13);
            this.Outbound.Controls.Add(this.label12);
            this.Outbound.Controls.Add(this.label11);
            this.Outbound.Location = new System.Drawing.Point(53, 27);
            this.Outbound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Outbound.Name = "Outbound";
            this.Outbound.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Outbound.Size = new System.Drawing.Size(834, 61);
            this.Outbound.TabIndex = 0;
            this.Outbound.TabStop = false;
            this.Outbound.Text = "Outbound flight details";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(615, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 16);
            this.label15.TabIndex = 9;
            this.label15.Text = "Flight number";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(464, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 16);
            this.label14.TabIndex = 8;
            this.label14.Text = "Time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(284, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(188, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "From";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Countries);
            this.groupBox3.Controls.Add(this.Add);
            this.groupBox3.Controls.Add(this.Phonebook);
            this.groupBox3.Controls.Add(this.BD);
            this.groupBox3.Controls.Add(this.Passportbook);
            this.groupBox3.Controls.Add(this.Lastnamebook);
            this.groupBox3.Controls.Add(this.Firstnamebook);
            this.groupBox3.Controls.Add(this.Phone);
            this.groupBox3.Controls.Add(this.Passportcountry);
            this.groupBox3.Controls.Add(this.Passportnumber);
            this.groupBox3.Controls.Add(this.Birthday);
            this.groupBox3.Controls.Add(this.Lastname);
            this.groupBox3.Controls.Add(this.Firstame2);
            this.groupBox3.Location = new System.Drawing.Point(53, 158);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(834, 138);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger details";
            // 
            // Countries
            // 
            this.Countries.FormattingEnabled = true;
            this.Countries.Location = new System.Drawing.Point(408, 74);
            this.Countries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Countries.Name = "Countries";
            this.Countries.Size = new System.Drawing.Size(128, 24);
            this.Countries.TabIndex = 18;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Lime;
            this.Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Add.Location = new System.Drawing.Point(619, 103);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(210, 35);
            this.Add.TabIndex = 17;
            this.Add.Text = "Add Passenger";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Phonebook
            // 
            this.Phonebook.Location = new System.Drawing.Point(619, 78);
            this.Phonebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Phonebook.Name = "Phonebook";
            this.Phonebook.Size = new System.Drawing.Size(118, 22);
            this.Phonebook.TabIndex = 16;
            // 
            // BD
            // 
            this.BD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.BD.Location = new System.Drawing.Point(619, 28);
            this.BD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(178, 22);
            this.BD.TabIndex = 15;
            // 
            // Passportbook
            // 
            this.Passportbook.Location = new System.Drawing.Point(126, 75);
            this.Passportbook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Passportbook.Name = "Passportbook";
            this.Passportbook.Size = new System.Drawing.Size(118, 22);
            this.Passportbook.TabIndex = 13;
            // 
            // Lastnamebook
            // 
            this.Lastnamebook.Location = new System.Drawing.Point(408, 27);
            this.Lastnamebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lastnamebook.Name = "Lastnamebook";
            this.Lastnamebook.Size = new System.Drawing.Size(118, 22);
            this.Lastnamebook.TabIndex = 12;
            // 
            // Firstnamebook
            // 
            this.Firstnamebook.Location = new System.Drawing.Point(126, 30);
            this.Firstnamebook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Firstnamebook.Name = "Firstnamebook";
            this.Firstnamebook.Size = new System.Drawing.Size(118, 22);
            this.Firstnamebook.TabIndex = 11;
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(548, 78);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(46, 16);
            this.Phone.TabIndex = 10;
            this.Phone.Text = "Phone";
            // 
            // Passportcountry
            // 
            this.Passportcountry.AutoSize = true;
            this.Passportcountry.Location = new System.Drawing.Point(275, 80);
            this.Passportcountry.Name = "Passportcountry";
            this.Passportcountry.Size = new System.Drawing.Size(107, 16);
            this.Passportcountry.TabIndex = 9;
            this.Passportcountry.Text = "Passport country";
            // 
            // Passportnumber
            // 
            this.Passportnumber.AutoSize = true;
            this.Passportnumber.Location = new System.Drawing.Point(5, 78);
            this.Passportnumber.Name = "Passportnumber";
            this.Passportnumber.Size = new System.Drawing.Size(109, 16);
            this.Passportnumber.TabIndex = 8;
            this.Passportnumber.Text = "Passport number";
            // 
            // Birthday
            // 
            this.Birthday.AutoSize = true;
            this.Birthday.Location = new System.Drawing.Point(548, 34);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(56, 16);
            this.Birthday.TabIndex = 7;
            this.Birthday.Text = "Birthday";
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Location = new System.Drawing.Point(275, 34);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(66, 16);
            this.Lastname.TabIndex = 6;
            this.Lastname.Text = "Lastname";
            // 
            // Firstame2
            // 
            this.Firstame2.AutoSize = true;
            this.Firstame2.Location = new System.Drawing.Point(5, 32);
            this.Firstame2.Name = "Firstame2";
            this.Firstame2.Size = new System.Drawing.Size(66, 16);
            this.Firstame2.TabIndex = 5;
            this.Firstame2.Text = "Firstname";
            // 
            // Passengerlist
            // 
            this.Passengerlist.AutoSize = true;
            this.Passengerlist.Location = new System.Drawing.Point(50, 299);
            this.Passengerlist.Name = "Passengerlist";
            this.Passengerlist.Size = new System.Drawing.Size(92, 16);
            this.Passengerlist.TabIndex = 11;
            this.Passengerlist.Text = "Passenger list";
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(53, 482);
            this.Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(180, 39);
            this.Back.TabIndex = 18;
            this.Back.Text = "Back to search for flights";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(266, 482);
            this.Confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(176, 39);
            this.Confirm.TabIndex = 32;
            this.Confirm.Text = "Confirm booking";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.Crimson;
            this.Remove.Location = new System.Drawing.Point(672, 465);
            this.Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(210, 38);
            this.Remove.TabIndex = 33;
            this.Remove.Text = "Remove Passenger";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Location = new System.Drawing.Point(53, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(834, 61);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return flight details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(615, 26);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(87, 16);
            this.label20.TabIndex = 9;
            this.label20.Text = "Flight number";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(464, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 16);
            this.label19.TabIndex = 8;
            this.label19.Text = "Time";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(284, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "Date";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(188, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "To";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(36, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "From";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstnamebook2,
            this.Lastnamebook2,
            this.Birthdate2,
            this.Passportbook2,
            this.Countries2,
            this.Phonebook2});
            this.dataGridView3.Location = new System.Drawing.Point(53, 318);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 28;
            this.dataGridView3.Size = new System.Drawing.Size(834, 142);
            this.dataGridView3.TabIndex = 34;
            // 
            // Firstnamebook2
            // 
            this.Firstnamebook2.HeaderText = "Firstname";
            this.Firstnamebook2.MinimumWidth = 8;
            this.Firstnamebook2.Name = "Firstnamebook2";
            this.Firstnamebook2.Width = 150;
            // 
            // Lastnamebook2
            // 
            this.Lastnamebook2.HeaderText = "LastName";
            this.Lastnamebook2.MinimumWidth = 8;
            this.Lastnamebook2.Name = "Lastnamebook2";
            this.Lastnamebook2.Width = 150;
            // 
            // Birthdate2
            // 
            this.Birthdate2.HeaderText = "Birthdate";
            this.Birthdate2.MinimumWidth = 8;
            this.Birthdate2.Name = "Birthdate2";
            this.Birthdate2.Width = 150;
            // 
            // Passportbook2
            // 
            this.Passportbook2.HeaderText = "Passport number";
            this.Passportbook2.MinimumWidth = 8;
            this.Passportbook2.Name = "Passportbook2";
            this.Passportbook2.Width = 150;
            // 
            // Countries2
            // 
            this.Countries2.HeaderText = "PassportCountries";
            this.Countries2.MinimumWidth = 8;
            this.Countries2.Name = "Countries2";
            this.Countries2.Width = 150;
            // 
            // Phonebook2
            // 
            this.Phonebook2.HeaderText = "Phone";
            this.Phonebook2.MinimumWidth = 8;
            this.Phonebook2.Name = "Phonebook2";
            this.Phonebook2.Width = 150;
            // 
            // Booking_confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 530);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Passengerlist);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Outbound);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Booking_confirmation";
            this.Text = "Booking_confirmation";
            this.Load += new System.EventHandler(this.Booking_confirmation_Load);
            this.Outbound.ResumeLayout(false);
            this.Outbound.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Outbound;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Passportcountry;
        private System.Windows.Forms.Label Passportnumber;
        private System.Windows.Forms.Label Birthday;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Label Firstame2;
        private System.Windows.Forms.TextBox Phonebook;
        private System.Windows.Forms.DateTimePicker BD;
        private System.Windows.Forms.TextBox Passportbook;
        private System.Windows.Forms.TextBox Lastnamebook;
        private System.Windows.Forms.TextBox Firstnamebook;
        private System.Windows.Forms.Label Passengerlist;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox Countries;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstnamebook2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastnamebook2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthdate2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passportbook2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Countries2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonebook2;
    }
}