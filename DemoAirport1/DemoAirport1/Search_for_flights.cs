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
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoAirport1
{
    public partial class Search_for_flights : Form
    {
        private Function function = new Function();
        private decimal totalCost = 0;
        public Search_for_flights()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;

        }
        private void Search_for_flights_Load(object sender, EventArgs e)
        {
            LoadComboBoxData(); // Load data for ComboBoxes when the form loads
        }

        //Load dữ liệu cho Comboboxx
        public void LoadComboBoxData()
        {
            // Load data for ComboBox1
            String query1 = "SELECT IATAcode FROM Airports";
            var comboBoxdata1 = function.getForCombo(query1);
            while (comboBoxdata1.Read())
            {
                cb1.Items.Add(comboBoxdata1["IATAcode"].ToString());
            }
            comboBoxdata1.Close();
            // Load data for ComboBox2
            String query2 = "SELECT IATAcode FROM Airports";
            var comboBoxdata2 = function.getForCombo(query2);
            while (comboBoxdata2.Read())
            {
                cb2.Items.Add(comboBoxdata2["IATAcode"].ToString());
            }
            comboBoxdata2.Close();
            // Load data for ComboBox3
            String query3 = "SELECT NAME FROM CabinTypes";
            var comboBoxdata3 = function.getForCombo(query3);
            while (comboBoxdata3.Read())
            {
                cb3.Items.Add(comboBoxdata3["Name"].ToString());
            }

            comboBoxdata3.Close();
            // Set default selection for ComboBox3
            cb3.SelectedItem = "Economy";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            // Check if ComboBoxes and DateTimePickers are selected
            if (cb1.SelectedItem == null || cb2.SelectedItem == null || cb3.SelectedItem == null || dateTimePicker1.Value >= dateTimePicker2.Value)
            {
                MessageBox.Show("Please select both departure and arrival airports, ensuring that the departure date is before the arrival date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get selected values from ComboBoxes and DateTimePickers
            string fromAirport = cb1.SelectedItem.ToString();
            string toAirport = cb2.SelectedItem.ToString();
            string cabin = cb3.SelectedItem.ToString();
            DateTime departureDate = dateTimePicker1.Value;
            DateTime arrivalDate = dateTimePicker2.Value;
            // Perform flight search for one-way flights
            DataTable searchResultsOneWay = SearchFlightsOneWay(fromAirport, toAirport, cabin, departureDate, arrivalDate);
            // Perform flight search for both one-way and return flights
            DataTable searchResultsFull = SearchFlightsReturn(fromAirport, toAirport, cabin, departureDate, arrivalDate);

            // Check if there are any search results for one-way flights
            if (searchResultsOneWay.Rows.Count == 0)
            {
                MessageBox.Show("No one-way flights found for the selected route within the specified dates.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            // Clear DataGridViews before adding new data
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();

            // Add data to DataGridView1 (outbound flights)
            foreach (DataRow row in searchResultsOneWay.Rows)
            {
                DateTime date = (DateTime)row["Date"];
                string dateString = date.ToShortDateString();
                dataGridView1.Rows.Add(row["From"], row["To"], dateString, row["Time"], row["FlightNumber"], row["EconomyPrice"], row["Number of stops"]);
            }
            // Check if the "Return" checkbox is checked and there are search results for return flights
            if (Return.Checked && searchResultsFull.Rows.Count > 0)
            {
                // Add data to DataGridView2 (return flights)
                foreach (DataRow row in searchResultsFull.Rows)
                {
                    DateTime date = (DateTime)row["Date"];
                    string dateString = date.ToShortDateString();
                    dataGridView2.Rows.Add(row["From"], row["To"], dateString, row["Time"], row["FlightNumber"], row["EconomyPrice"], row["Number of stops"]);
                }
            }
         
        }
        private DataTable SearchFlightsOneWay(string fromAirport, string toAirport, string cabin, DateTime departureDate, DateTime arrivalDate)
        {
       
            // Build SQL query with parameters for one-way flight
            string oneWayQuery = @"
        SELECT DISTINCT
            Airports.IATAcode AS [From], 
            Airports_1.IATAcode AS [To], 
            Schedules.Date, 
            Schedules.Time,
            Schedules.FlightNumber,
            CASE 
                WHEN CabinTypes.Name = 'Economy' THEN ROUND(Schedules.EconomyPrice, 0) -- Giá tiết kiệm không thay đổi
                WHEN CabinTypes.Name = 'Business' THEN ROUND(Schedules.EconomyPrice * 1.35, 0) -- Giá thương gia tăng 35%
                WHEN CabinTypes.Name = 'First Class' THEN ROUND(Schedules.EconomyPrice * 1.65, 0) -- Giá hạng nhất tăng 65%
            END AS EconomyPrice,
            (SELECT COUNT(*) FROM Routes WHERE Routes.DepartureAirportID = Airports.ID AND Routes.ArrivalAirportID = Airports_1.ID) AS [Number of stops]
        FROM 
            Schedules
            INNER JOIN Routes ON Schedules.RouteID = Routes.ID
            INNER JOIN Airports ON Routes.DepartureAirportID = Airports.ID
            INNER JOIN Airports AS Airports_1 ON Routes.ArrivalAirportID = Airports_1.ID
            INNER JOIN Tickets ON Schedules.ID = Tickets.ScheduleID
            INNER JOIN CabinTypes ON Tickets.CabinTypeID = CabinTypes.ID
        WHERE 
            CabinTypes.Name= '" + cabin + @"' AND
            Airports.IATAcode = '" + fromAirport + @"' 
            AND Airports_1.IATAcode = '" + toAirport + @"' 
            AND Schedules.Date >= '" + departureDate.ToString("yyyy-MM-dd") + @"' 
            AND Schedules.Date <= '" + arrivalDate.ToString("yyyy-MM-dd") + @"' ";

            // Execute the query for one-way flights and return the result as a DataTable
            return function.ExecuteQuery(oneWayQuery);
        }

        private DataTable SearchFlightsReturn(string fromAirport, string toAirport, string cabin, DateTime departureDate, DateTime arrivalDate)
        {
            // Build SQL query with parameters for both one-way and return flights
            string fullQuery = @"
        SELECT DISTINCT
            Airports.IATAcode AS [From], 
            Airports_1.IATAcode AS [To], 
            Schedules.Date, 
            Schedules.Time,
            Schedules.FlightNumber,
            CASE 
                WHEN CabinTypes.Name = 'Economy' THEN ROUND(Schedules.EconomyPrice, 0) -- Giá tiết kiệm không thay đổi
                WHEN CabinTypes.Name = 'Business' THEN ROUND(Schedules.EconomyPrice * 1.35, 0) -- Giá thương gia tăng 35%
                WHEN CabinTypes.Name = 'First Class' THEN ROUND(Schedules.EconomyPrice * 1.65, 0) -- Giá hạng nhất tăng 65%
              
            END AS EconomyPrice,
            (SELECT COUNT(*) FROM Routes WHERE Routes.DepartureAirportID = Airports.ID AND Routes.ArrivalAirportID = Airports_1.ID) AS [Number of stops]
        FROM 
            Schedules
            INNER JOIN Routes ON Schedules.RouteID = Routes.ID
            INNER JOIN Airports ON Routes.DepartureAirportID = Airports.ID
            INNER JOIN Airports AS Airports_1 ON Routes.ArrivalAirportID = Airports_1.ID
            INNER JOIN Tickets ON Schedules.ID = Tickets.ScheduleID
            INNER JOIN CabinTypes ON Tickets.CabinTypeID = CabinTypes.ID
   WHERE 
            CabinTypes.Name= '" + cabin + @"' AND
            Airports.IATAcode = '" + toAirport + @"' 
            AND Airports_1.IATAcode = '" + fromAirport + @"' 
            AND Schedules.Date >= '" + departureDate.ToString("yyyy-MM-dd") + @"' 
            AND Schedules.Date <= '" + arrivalDate.ToString("yyyy-MM-dd") + @"'";

            // Execute the query for both one-way and return flights and return the result as a DataTable
            return function.ExecuteQuery(fullQuery);
        }

        private void Return_CheckedChanged(object sender, EventArgs e)
        {
            if (Return.Checked)
            {
                // Kích hoạt DateTimePicker cho ngày về
                dateTimePicker2.Enabled = true;

                // Hiển thị dataGridView2 và ẩn dataGridView1
                dataGridView1.Visible = true;
                dataGridView2.Visible = true;

            }
            else
            {
                // Vô hiệu hóa DateTimePicker cho ngày về
                dateTimePicker2.Enabled = false;
                // Hiển thị dataGridView1 và ẩn dataGridView2
                dataGridView1.Visible = true;
                dataGridView2.Visible = false;
            }
        }
        private void Oneway_CheckedChanged(object sender, EventArgs e)
        {
            if (Oneway.Checked)
            {
                dateTimePicker2.Enabled = false; // Vô hiệu hóa DateTimePicker cho ngày về
                dataGridView2.Visible = false;
            }
            else
            {
                dateTimePicker2.Enabled = true; // Kích hoạt DateTimePicker cho ngày về
            }
        }
        private void Comfirm_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dataGridView1.SelectedRows.Count > 0 || dataGridView2.SelectedRows.Count > 0)
            {
                // Tạo một đối tượng Booking_confirmation
                Booking_confirmation confirm = new Booking_confirmation();

                // Lấy thông tin của dòng được chọn từ DataGridView1
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string from = selectedRow.Cells["From"].Value.ToString();
                    string to = selectedRow.Cells["To"].Value.ToString();
                    string date = selectedRow.Cells["Date"].Value.ToString();
                    string cabin = cb3.Text.ToString();
                    string flightnumber = selectedRow.Cells["flight"].Value.ToString();

                    // Truyền thông tin của chuyến bay đi qua form Booking_confirmation
                    totalCost += Convert.ToDecimal(selectedRow.Cells["cabin"].Value);
                    confirm.UpdateFlightInfo(from, to, date, cabin, flightnumber);
                }


                // Lấy thông tin của dòng được chọn từ DataGridView2
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow2 = dataGridView2.SelectedRows[0];
                    string from2 = selectedRow2.Cells["From2"].Value.ToString();
                    string to2 = selectedRow2.Cells["To2"].Value.ToString();
                    string date2 = selectedRow2.Cells["Date2"].Value.ToString();
                    string cabin = cb3.Text.ToString();
                    string flightnumber2 = selectedRow2.Cells["flight2"].Value.ToString();
            
                    // Truyền thông tin của chuyến bay về qua form Booking_confirmation
                    confirm.UpdateReturnFlightInfo(from2, to2, date2, cabin, flightnumber2);
                }

                // Cập nhật tổng chi phí và hiển thị form Booking_confirmation
                confirm.TotalCost = totalCost;
                confirm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a flight before confirming.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
