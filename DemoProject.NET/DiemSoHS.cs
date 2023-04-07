using BUS;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProject.NET
{
    public partial class DiemSoHS : Form
    {
        private BaoCaoDiemSoBUS databus;
        public DiemSoHS()
        {
            InitializeComponent();
            databus = new BaoCaoDiemSoBUS();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
           

        }
    }
}
