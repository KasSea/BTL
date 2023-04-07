using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.BaoCaoDiemSoDAL;

namespace BUS
{
    public class BaoCaoDiemSoBUS
    {
        private static BaoCaoDiemSoBUS instance;

        public static BaoCaoDiemSoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new BaoCaoDiemSoBUS();
                return instance;
            }
        }

       

        private BaocaodiemsoDAL data;

        public BaoCaoDiemSoBUS() 
        {
            data = new BaocaodiemsoDAL();
        }

        public DataTable GetScoreReportData()
        {
            return data.Xem();
        }
    }
}
