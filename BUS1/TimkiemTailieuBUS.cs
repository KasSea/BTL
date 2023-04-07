using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class TimkiemTailieuBUS
    {
        private static TimkiemTailieuBUS instance;

        public static TimkiemTailieuBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TimkiemTailieuBUS();
                return instance;
            }
        }

        private TimkiemTailieuBUS() { }
        public List<QuanLyTaiLieu> Xem(string name)
        {
            return TimKiemTLDAL.Instance.Xem(name);
        }
    }
}
