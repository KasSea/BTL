using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BUS
{
    public class QuanLyTaiLieuBUS
    {

        private static QuanLyTaiLieuBUS instance;

        public static QuanLyTaiLieuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new QuanLyTaiLieuBUS();
                return instance;
            }
        }

        private QuanLyTaiLieuBUS() { }
        public void Xem(DataGridView data)
        {
            data.DataSource = QuanLyTaiLieuDAL.Instance.Xem();
        }
    }
}
