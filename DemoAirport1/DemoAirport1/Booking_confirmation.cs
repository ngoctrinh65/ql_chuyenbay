using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DemoAirport1
{
    public partial class Booking_confirmation : Form
    {
        public decimal TotalCost { get; set; }
        private Function function = new Function();
        public Booking_confirmation()
        {
            InitializeComponent();
            // Set DateTimePicker format to display only date
            BD.Format = DateTimePickerFormat.Short;
            dataGridView3.ReadOnly = true;
         

        }

        private void Booking_confirmation_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
        

        }
        public void LoadComboBoxData()
        {
            string query4 = "SELECT Name FROM countries";
            var Country = function.getForCombo(query4);
            while (Country.Read())
            {
                Countries.Items.Add(Country["Name"].ToString());
            }
            Country.Close();
        }
        private void Outbound_Enter(object sender, EventArgs e)
        {

        }
        public void UpdateFlightInfo(string from, string to, string date, string cabin,string flightnumber)
        {
            label11.Text = "From: " + from;
            label12.Text = "To: " + to;
            label13.Text = "Date: " + date;
            label14.Text = "Time: " + cabin;
            label15.Text = "FlightNumber: " + flightnumber;
        }
        public void UpdateReturnFlightInfo(string from2, string to2, string date2, string cabin, string flightnumber2)
        {
            label16.Text = "From: " + from2;
            label17.Text = "To: " + to2;
            label18.Text = "Date: " + date2;
            label19.Text = "Time: " + cabin;
            label20.Text = "FlightNumber: " + flightnumber2;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ các TextBox
            string firstName = Firstnamebook.Text;
            string lastName = Lastnamebook.Text;
            // Lấy ngày sinh từ DateTimePicker
            DateTime birthday = (DateTime)BD.Value;
            string passportNumber = Passportbook.Text;
            string passportCountry = Countries.Text;
            string phone = Phonebook.Text;
            // Kiểm tra xem có trường nào bị trống không
            if (string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(passportNumber) || string.IsNullOrWhiteSpace(passportCountry) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Thêm dữ liệu vào DataGridView
            dataGridView3.Rows.Add(lastName, firstName, birthday, passportNumber, passportCountry, phone);
            // Xóa nội dung của các TextBox sau khi thêm thành công
            ClearTextBoxes();
        }


        private void ClearTextBoxes()
        {
            // Xóa nội dung của các TextBox
            Firstnamebook.Text = "";
            Lastnamebook.Text = "";
            Birthday.Text = "";
            Passportbook.Text = "";
            Countries.Text = "";
            Phonebook.Text = "";
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        
        }


        private void Remove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView3.SelectedRows)
            {
                // Remove the row from the DataGridView
                dataGridView3.Rows.Remove(row);
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Billing_confirmation bill = new Billing_confirmation();
            bill.TotalCost = TotalCost;
            bill.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
