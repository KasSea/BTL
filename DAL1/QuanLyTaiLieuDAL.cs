using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuanLyTaiLieuDAL
    {

        private static QuanLyTaiLieuDAL instance;

        public static QuanLyTaiLieuDAL Instance {
            get {if (instance == null)
                    instance = new QuanLyTaiLieuDAL();
                return instance; }
        }

        private QuanLyTaiLieuDAL() { }

        public List<QuanLyTaiLieu> Xem()
        {
            List<QuanLyTaiLieu> quanLyTaiLieus = new List<QuanLyTaiLieu> ();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                    using (SqlCommand command = new SqlCommand("selectallTLGD", conn))
                    {
                    command.CommandType = CommandType.StoredProcedure;
                        conn.Open ();
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo bảng tạm trong bộ nhớ để chứa dữ liệu
                    while (reader.Read())
                    {
                        string maTl = reader["maTl"].ToString();
                        string tenTl = reader["tenTl"].ToString();
                        string tlMon = reader["taiLieumon"].ToString();
                        DateTime ngayxuatBan = (DateTime)reader["ngayXuatban"];
                        QuanLyTaiLieu qltk = new QuanLyTaiLieu(maTl, tenTl, tlMon, ngayxuatBan);

                        quanLyTaiLieus.Add(qltk);
                    }
                    reader.Close();


                    // Gán bảng này cho DataGridView để hiển thị dữ liệu

                }
              
            }



                return quanLyTaiLieus;
        }

    }
}
