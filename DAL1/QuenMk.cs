using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace DAL
{
    public class QuenMkDAL : QuenMk
    {
        public string QuenMK(QuenMatKhau qmk)
        {
            string QuenMkaccount = QuenMKDTO(qmk);
            return QuenMkaccount;

        }

    }

    public class LayLaiMatKhauDAL : LayLaiMatKhau
    {
        public string lltk(QuenMatKhau qmk)
        {
            string QuenMkaccount = LayLaiMKDTO(qmk);
            return QuenMkaccount;

        }
    }
}
