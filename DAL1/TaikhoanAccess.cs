using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TaikhoanAccess:DatabaseAccess
    {
        public string Checklogin(TaiKhoan taikhoan)
        {
            string info = CheckloginDTO(taikhoan);
            return info;
        }
    }
}
