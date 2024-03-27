using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAirport1
{
    public partial class Booking_report : Form
    {
        private Function function = new Function();

        public Booking_report()
        {
            InitializeComponent();
        }

        private void btMake_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã nhập đủ thông tin hay chưa
            if (string.IsNullOrWhiteSpace(tb5.Text) || string.IsNullOrWhiteSpace(tbDate.Text))
            {
                MessageBox.Show("Please enter both Flight Number and Date.", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Lấy thông tin từ các control
            string flightNumber = tb5.Text;
            string dateString = tbDate.Text;
            // Chuyển đổi định dạng của ngày tháng từ "dd-MM-yyyy" sang "yyyy-MM-dd"
            if (!DateTime.TryParseExact(dateString, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Invalid Date format. Please enter a valid date in 'dd-MM-yyyy' format.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển đổi lại thành định dạng "yyyy-MM-dd"
            dateString = date.ToString("yyyy-MM-dd");


            // Chuỗi truy vấn SQL
            string query = @"
            SELECT 
                CONCAT(U.FirstName, ' ', U.LastName) AS [Name],
                T.BookingReference AS [Booking Ref],
                S.EconomyPrice AS [Economy Price],
                S.Date AS [Date]
            FROM 
                Schedules S
            INNER JOIN 
                Tickets T ON S.ID = T.ScheduleID
            INNER JOIN 
                Users U ON T.UserID = U.ID
            WHERE 
                FlightNumber = '" + flightNumber + @"'
                AND Date = '" + dateString + @"'";


   
            // Chuỗi truy vấn SQL để lấy thông tin về số lượng hành khách và tổng số tiền
            string query2 = @"
    SELECT 
        COUNT(T.ID) AS [Number of Passengers],
        SUM(S.EconomyPrice) AS [Total Amount]
    FROM 
        Schedules S
    INNER JOIN 
        Tickets T ON S.ID = T.ScheduleID
    INNER JOIN 
        Users U ON T.UserID = U.ID
    WHERE 
        S.FlightNumber = '" + flightNumber + @"'
        AND S.Date = '" + dateString + @"'";
            // Thực thi truy vấn và lấy dữ liệu
            DataTable result = function.ExecuteQuery(query);
            DataTable result2 = function.ExecuteQuery(query2);
            // Kiểm tra kết quả truy vấn
            if (result.Rows.Count > 0)
            {
                // Hiển thị kết quả lên giao diện
                dataGridView1.DataSource = result;
                // Hiển thị kết quả lên giao diện
                label3.Text = result2.Rows[0]["Number of Passengers"].ToString();
                label2.Text = result2.Rows[0]["Total Amount"].ToString();
            }
            else
            {
                // Nếu không có kết quả, hiển thị thông báo
                MessageBox.Show("No data found for the provided Flight Number and Date.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         
        }

    }
}
