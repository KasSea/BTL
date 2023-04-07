using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TimKiemTLDAL
    {
        private static TimKiemTLDAL instance;

        public static TimKiemTLDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new TimKiemTLDAL();
                return instance;
            }
        }

        private TimKiemTLDAL() { }

        public List<QuanLyTaiLieu> Xem(string name)
        {
            List<QuanLyTaiLieu> timkiemTailieus = new List<QuanLyTaiLieu>();

            using (SqlConnection conn = SqlconnectionData.Connect())
            {
                // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục
                using (SqlCommand command = new SqlCommand("TimkiemTLtheoTen", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@taiLieumon", name);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Tạo bảng tạm trong bộ nhớ để chứa dữ liệu
                    while (reader.Read())
                    {
                        string maTl = reader["maTl"].ToString();
                        string tenTl = reader["tenTl"].ToString();
                        string tlMon = reader["taiLieumon"].ToString();
                        DateTime ngayxuatBan = (DateTime)reader["ngayXuatban"];
                        QuanLyTaiLieu tktl = new QuanLyTaiLieu(maTl, tenTl, tlMon, ngayxuatBan);

                        timkiemTailieus.Add(tktl);
                    }
                    reader.Close();


                    // Gán bảng này cho DataGridView để hiển thị dữ liệu

                }

            }



            return timkiemTailieus;
        }

    }
}
