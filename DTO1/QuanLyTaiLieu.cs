using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyTaiLieu
    {
        private string maTL;

        public string MaTL { get => maTL; set => maTL = value; }
        public string TenTl { get => tenTl; set => tenTl = value; }
        public string TlMon { get => tlMon; set => tlMon = value; }
        public DateTime NgayXuatBan { get => ngayXuatBan; set => ngayXuatBan = value; }

        private string tenTl;

        private string tlMon;

        private DateTime ngayXuatBan;

        // constructor
        public QuanLyTaiLieu(string maTL,string tenTL, string tlMon,DateTime ngayXuatBan)
        {
            this.maTL = maTL;
            this.tenTl = tenTL;
            this.tlMon = tlMon;
            this.ngayXuatBan=ngayXuatBan;
        }
    }
}
