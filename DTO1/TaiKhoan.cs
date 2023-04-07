using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan
    {
        public string maTk { get; set; }
        public string tenTk { get; set; }
        public string matkhauTk { get; set; }
        public int Fk_maQuyen { get; set; }
        public string emailTk { get; set; }
    }

  
}
