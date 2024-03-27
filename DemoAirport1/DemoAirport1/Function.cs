using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAirport1
{
    internal class Function
    {
        protected SqlConnection getConnection()
        {
            //Tạo đối tượng kết nối 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0564AIM\\MSSQLSERVER01;Initial Catalog=Vothanhtrong;Integrated Security=True;";
            return con;
        }
        
        //public DataSet getData(String query)
        //{
        //    SqlConnection con = getConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    cmd.CommandText = query; 
        //    DataAdapter da = new SqlDataAdapter(cmd);
        //    DataSet ds = new DataSet();    
        //    da.Fill(ds);
        //    return ds;
        //}
        //public void Setdata(String query, SqlParameter[] parameters)
        //{
        //    SqlConnection con = getConnection();
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.Connection = con;
        //    con.Open();
        //    cmd.CommandText = query;
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //}

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection(); //Tạo đối tượng kết nối , gọi phương thức get
            SqlCommand cmd = new SqlCommand();// Tao đối tượng thực thi
            cmd.Connection = con;//thiết lập kết nối
            con.Open();//Mở kết nối đến cơ sở dữ liệu.
            cmd = new SqlCommand(query, con);//Khởi tạo lại đối tượng SqlCommand với câu truy vấn và kết nối đã được mở.
            SqlDataReader sdr = cmd.ExecuteReader(); //Thực thi câu truy vấn và lấy về kết quả vào đối tượng SqlDataReader.
            return sdr;
        }

        public DataTable ExecuteQuery(string query)
        {
            using (SqlConnection con = getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                   
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        internal DataTable ExecuteQuery(string query, object parameters)
        {
            throw new NotImplementedException();
        }
    }
}
