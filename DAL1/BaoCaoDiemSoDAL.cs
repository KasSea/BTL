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
    public class BaoCaoDiemSoDAL 
    {
        private static BaoCaoDiemSoDAL instance;

        public static BaoCaoDiemSoDAL Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoDiemSoDAL();
                return instance;
            }
        }

        private BaoCaoDiemSoDAL() { }

        public class BaocaodiemsoDAL
        {
            public DataTable Xem()
            {

                using (SqlConnection conn = SqlconnectionData.Connect())
                {
                    // Tạo đối tượng SqlDataAdapter để lấy dữ liệu từ thủ tục

                    DataTable dataTable = new DataTable();
                    SqlCommand sqlCommand = new SqlCommand("BaoCaoDiemSO", conn);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                    sqlDataAdapter.Fill(dataTable);
                    return dataTable;
                    //



                    // Gán bảng này cho DataGridView để hiển thị dữ liệ

                }

            }
        }
    }
}
