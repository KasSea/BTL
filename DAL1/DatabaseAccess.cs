using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace DAL
{
    public class SqlconnectionData {
        public static SqlConnection Connect()
        {
            string stringcon = @"Data Source=TIENANH\SQLEXPRESS;Initial Catalog=QuanLyTTHPT;User ID=TienAnh;Password=Tienanh@123;Encrypt = false";
            SqlConnection conn = new SqlConnection(stringcon);// khởi tạo connection
            return conn;
        }
    }
    public class LayLaiMatKhau
    {
        public static string LayLaiMKDTO(QuenMatKhau forgotpassw)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                string _email = null;
                conn.Open();
                SqlCommand qmk = new SqlCommand("HienTHiMkQuen", conn);
                qmk.CommandType = CommandType.StoredProcedure;
                qmk.Parameters.Add("@email", SqlDbType.NVarChar).Value = forgotpassw.emailTk;
                qmk.Connection = conn;

                SqlDataReader reader = qmk.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _email = reader.GetString(0);
                    }
                    reader.Close();
                    conn.Close();
                }
                else
                {
                    return "Email không đúng!";
                }


                return _email;
            }
        }
    }

    public class QuenMk
    {
        public static string QuenMKDTO(QuenMatKhau forgotpassw)
        {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                conn.Open();

                string _email = null;
                SqlCommand cmd = new SqlCommand("ForgotPw", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = forgotpassw.emailTk;
                
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        _email = reader.GetString(0);      
                    }
                    reader.Close();
                    conn.Close();
                }
                else
                {
                    return "Email không đúng!";
                }
              
  
                return _email;


                //string user = null;
                //SqlConnection conn = SqlconnectionData.Connect(); // connect tới cơ sở dữ liệu
                //conn.Open();
                //// check login
                //SqlCommand cmd = new SqlCommand("ForgotPw", conn);
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@user", taikhoan.tenTk);
                //cmd.Parameters.AddWithValue("@password", taikhoan.matkhauTk);
                //cmd.Connection = conn;
                //SqlDataReader reader = cmd.ExecuteReader();
                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {
                //        user = reader.GetString(0);
                //        return user;
                //    }
                //    reader.Close();
                //    conn.Close();
                //}
                //else
                //{
                //    return "Tài Khoản mật khẩu không chính xác!";
                //}

                //return user;

            }
        }
    } 

    public class DangkyTk
    {   

        public static string TaoTaiKhoanDTO(DangKyTaiKhoan taikhoanmoi) {
            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                string user = null;
                SqlCommand cmd = new SqlCommand("Dangky_Tk", conn);
    
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm các tham số cho thủ tục
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = taikhoanmoi.emailTk;
                cmd.Parameters.Add("@TenTk", SqlDbType.NVarChar).Value = taikhoanmoi.tenTk;
                cmd.Parameters.Add("@matkhauTk", SqlDbType.NVarChar).Value = taikhoanmoi.matkhauTk;
                conn.Open();
             
                cmd.ExecuteNonQuery();
                conn.Close();
                return user;
            }
        }
    }

    public class DatabaseAccess
    {
       public static string CheckloginDTO(TaiKhoan taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlconnectionData.Connect(); // connect tới cơ sở dữ liệu
            conn.Open();
            // check login
            SqlCommand cmd = new SqlCommand("Check_login", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@user",taikhoan.tenTk);
            cmd.Parameters.AddWithValue("@password",taikhoan.matkhauTk);
            cmd.Connection = conn;
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài Khoản mật khẩu không chính xác!";
            }

            return user;

        }
    }
}
