using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DemoAirport1
{
    public partial class Purchase_amenities : Form
    {
        // Khai báo các biến

        private Function function = new Function();

        public Purchase_amenities()
        {
            InitializeComponent();
            button4.Click += button4_Click;
        }

        //private void tb5_TextChanged(object sender, EventArgs e)
        //{
        //    string bookingReference = tb5.Text;

        //    string query = "SELECT * FROM Tickets WHERE BookingReference = '" + bookingReference + "'";
        //    DataTable result = function.ExecuteQuery(query);

        //    if (result.Rows.Count > 0)
        //    {
        //        // Hiển thị thông tin đặt chỗ nếu tìm thấy kết quả
        //        DataRow row = result.Rows[0];
        //    }

        //}

        private void btOK_Click(object sender, EventArgs e)
        {

            // Lấy thông tin BookingReference từ textbox tb5
            string bookingReference = tb5.Text;

            // Truy vấn để lấy thông tin về chuyến bay dựa trên BookingReference
            string query = "SELECT ScheduleID FROM Tickets WHERE BookingReference = '" + bookingReference + "'";
            DataTable result = function.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                // Lấy ScheduleID từ kết quả truy vấn
                int scheduleID = Convert.ToInt32(result.Rows[0]["ScheduleID"]);

                // Truy vấn để lấy thông tin về chuyến bay dựa trên ScheduleID và thời gian hiện tại
                string flightQuery = @"SELECT S.FlightNumber, S.Date, R.DepartureAirportID, R.ArrivalAirportID, S.Time
                       FROM Schedules AS S
                       INNER JOIN Routes AS R ON S.RouteID = R.ID
                       WHERE S.ID = " + scheduleID;
                DataTable flightResult = function.ExecuteQuery(flightQuery);

                if (flightResult.Rows.Count > 0)
                {
                    // Hiển thị danh sách các chuyến bay có sẵn đến 24 giờ trước mỗi chuyến bay
                    foreach (DataRow row in flightResult.Rows)
                    {
                        string flightNumber = flightResult.Rows[0]["FlightNumber"].ToString();
                        DateTime date = (DateTime)flightResult.Rows[0]["Date"];
                        TimeSpan time = (TimeSpan)row["Time"];
                        int departureAirportID = Convert.ToInt32(flightResult.Rows[0]["DepartureAirportID"]);
                        int arrivalAirportID = Convert.ToInt32(flightResult.Rows[0]["ArrivalAirportID"]);

                        // Truy vấn để lấy tên sân bay từ ID
                        string departureAirportQuery = "SELECT IATACode FROM Airports WHERE ID = " + departureAirportID;
                        string departureAirport = function.ExecuteQuery(departureAirportQuery).Rows[0]["IATACode"].ToString();

                        string arrivalAirportQuery = "SELECT IATACode FROM Airports WHERE ID = " + arrivalAirportID;
                        string arrivalAirport = function.ExecuteQuery(arrivalAirportQuery).Rows[0]["IATACode"].ToString();

                        // Kiểm tra xem dòng đã tồn tại trong comboBox2 chưa
                        string flightInfo = $"{flightNumber}, {date.ToShortDateString()}, {departureAirport}-{arrivalAirport},{time}";
                        if (!comboBox2.Items.Contains(flightInfo))
                        {
                            // Thêm dòng vào comboBox2 nếu chưa tồn tại
                            comboBox2.Items.Add(flightInfo);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thông tin chuyến bay cho ScheduleID này.");
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin đặt chỗ với số tham chiếu này.");
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            // Xóa danh sách hiện tại trong comboBox2
            comboBox2.Items.Clear();
            // Lấy thông tin BookingReference từ textbox tb5
            string bookingReference = tb5.Text;

            // Truy vấn để lấy thông tin về chuyến bay dựa trên BookingReference
            string query = "SELECT * FROM Tickets WHERE BookingReference = '" + bookingReference + "'";
            DataTable result = function.ExecuteQuery(query);

            if (result.Rows.Count > 0)
            {
                // Hiển thị thông tin đặt chỗ nếu tìm thấy kết quả
               
                string firstName = result.Rows[0]["Firstname"].ToString();
                label3.Text = firstName;

                // Lấy loại cabin dựa trên CabinTypeID
                int cabinTypeID = Convert.ToInt32(result.Rows[0]["CabinTypeID"]);
                string cabinTypeQuery = "SELECT Name FROM CabinTypes WHERE ID = " + cabinTypeID;
                DataTable cabinTypeResult = function.ExecuteQuery(cabinTypeQuery);
                if (cabinTypeResult.Rows.Count > 0)
                {
                    string cabinTypeName = cabinTypeResult.Rows[0]["Name"].ToString();
                    label2.Text = cabinTypeName;
                }
                else
                {
                    label2.Text = "Không có thông tin loại cabin";
                }

                // Hiển thị PassportNumber
                string passportNumber = result.Rows[0]["PassportNumber"].ToString();
                label4.Text = passportNumber;

                // Hiển thị dịch vụ và giá tương ứng
                DisplayServicesForCabin(cabinTypeID);
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin đặt chỗ với số tham chiếu này.");
            }
        }

        // Phương thức để hiển thị dịch vụ và giá tương ứng với CabinTypeID
        private void DisplayServicesForCabin(int cabinTypeID)
        {
            // Truy vấn để lấy danh sách dịch vụ (Service) và giá (Price) cho CabinTypeID này từ bảng Amenities
            string query = "SELECT A.Service, A.Price FROM Amenities A JOIN AmenitiesCabinType ACT ON A.ID = ACT.AmenityID WHERE ACT.CabinTypeID = " + cabinTypeID;
            DataTable amenitiesResult = function.ExecuteQuery(query);

            // Xóa các control hiện có trong groupBox2 để làm mới danh sách dịch vụ
            groupBox1.Controls.Clear();

            // Duyệt qua kết quả trả về và tạo các ô đánh dấu (checkbox) cho mỗi dịch vụ
            int yPos = 20;
            foreach (DataRow row in amenitiesResult.Rows)
            {
                string serviceName = row["Service"].ToString();
                decimal servicePrice = Convert.ToDecimal(row["Price"]);

                System.Windows.Forms.CheckBox checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new Point(20, yPos);
                checkBox.Text = serviceName + " (" + (servicePrice == 0 ? "Free" : servicePrice.ToString("C")) + ")";
                checkBox.Tag = servicePrice; // Lưu giá tiện ích vào Tag của ô đánh dấu
                checkBox.CheckedChanged += CheckBox_CheckedChanged; // Thêm sự kiện CheckedChanged
                groupBox1.Controls.Add(checkBox);

                yPos += 30;
            }
        }

        // Sự kiện CheckedChanged của các checkbox
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            decimal totalAmount = 0;
            decimal taxRate = 0.05m; // Tỉ lệ thuế 5%

            // Tính tổng số tiền phải trả và số tiền thuế
            foreach (Control control in groupBox1.Controls)
            {
                if (control is System.Windows.Forms.CheckBox checkBox && checkBox.Checked)
                {
                    totalAmount += Convert.ToDecimal(checkBox.Tag);
                }
            }

            // Tính số tiền thuế
            decimal taxAmount = totalAmount * taxRate;

            // Hiển thị tổng số tiền phải trả và số tiền thuế
            label6.Text = totalAmount.ToString("C");
            label7.Text = taxAmount.ToString("C");
            label10.Text = (totalAmount + taxAmount).ToString("C");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
