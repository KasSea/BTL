using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoDiemSo
    {
        private string maHP;
        private string tenHp;
        private string maHs;
        private string tenHs;
        private DateTime ngaysinh;
        private double diemso;

        public BaoCaoDiemSo(string maHP, string tenHp, string maHs, string tenHs, DateTime ngaysinh, double diemso)
        {
            MaHP = maHP;
            TenHp = tenHp;
            MaHs = maHs;
            TenHs = tenHs;
            Ngaysinh = ngaysinh;
            Diemso = diemso;
        }

        public string MaHP { get => maHP; set => maHP = value; }
        public string TenHp { get => tenHp; set => tenHp = value; }
        public string MaHs { get => maHs; set => maHs = value; }
        public string TenHs { get => tenHs; set => tenHs = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public double Diemso { get => diemso; set => diemso = value; }
    }
}
