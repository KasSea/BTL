using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BUS
{
    public class laylTk {
        LayLaiMatKhauDAL _qmk = new LayLaiMatKhauDAL();
        public string laylaiTk(QuenMatKhau quentaikhoan)
        {
            if (quentaikhoan.emailTk == "")
            {
                return "Email không được để trống";
            }  
            string info = _qmk.lltk(quentaikhoan);
            return info;
        }
    }
    // 
    public class QuenMKBus { 
        QuenMkDAL _qmk = new QuenMkDAL();
        public string QuenTk(QuenMatKhau quentaikhoan)
        {
            if (quentaikhoan.emailTk == "")
            {
                return "Email không được để trống";
            }
            string info = _qmk.QuenMK(quentaikhoan);
            return info;
        }
    }
    // đăng ký tài khoản
    public class DangkyBus {
         DangKyTaiKhoan tk = new DangKyTaiKhoan();
         public string Dangkytk(DangKyTaiKhoan taotaikhoan)
        {
            DangkyTaiKhoanDAL tkDAl= new DangkyTaiKhoanDAL();
            // kiểm tra nghiệp vụ
            if (taotaikhoan.emailTk == "")
            {
                return "Email không được để trống";
            }
            if (taotaikhoan.tenTk == "")
            {
                return "Tên tài khoản không được để trống";

            }
            if(taotaikhoan.matkhauTk == "")
            {
                return "Mật khẩu không được để trống";
            }
            string info = tkDAl.dkTaiKhoanmoi(taotaikhoan);
            return info;
        }
    }

    // check login
    public class TaiKhoanBus
    {
        TaikhoanAccess tkaccess = new TaikhoanAccess();
        public string Checklogin(TaiKhoan taikhoan)
        {
           // kiểm tra nghiệp vụ
           if (taikhoan.tenTk == "") {
                return "Lỗi User";
            }
           if (taikhoan.matkhauTk == "")
            {
                return "Lỗi Password";

            }

           string info = tkaccess.Checklogin(taikhoan);
            return info;
        }
    }
}
