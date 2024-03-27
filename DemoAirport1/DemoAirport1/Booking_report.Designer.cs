namespace DemoAirport1
{
    partial class Booking_report
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
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btMake = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb5
            // 
            this.tb5.Location = new System.Drawing.Point(107, 23);
            this.tb5.Name = "tb5";
            this.tb5.Size = new System.Drawing.Size(100, 22);
            this.tb5.TabIndex = 28;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(24, 26);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(53, 16);
            this.label29.TabIndex = 27;
            this.label29.Text = "Flight Id";
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(107, 71);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(100, 22);
            this.tbDate.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Date";
            // 
            // btMake
            // 
            this.btMake.Location = new System.Drawing.Point(274, 44);
            this.btMake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btMake.Name = "btMake";
            this.btMake.Size = new System.Drawing.Size(115, 31);
            this.btMake.TabIndex = 31;
            this.btMake.Text = "Make report";
            this.btMake.UseVisualStyleBackColor = true;
            this.btMake.Click += new System.EventHandler(this.btMake_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(707, 134);
            this.dataGridView1.TabIndex = 36;
           
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(348, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "XXXX";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(342, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "XXXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Total amount";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(178, 342);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(137, 16);
            this.label30.TabIndex = 45;
            this.label30.Text = "Number of passenger";
            // 
            // Booking_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btMake);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.label29);
            this.Name = "Booking_report";
            this.Text = "Booking_report";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMake;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label30;
    }
}