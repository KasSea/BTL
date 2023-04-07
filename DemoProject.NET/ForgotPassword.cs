using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DemoProject.NET
{
    
    public partial class frmQuenMk : Form
    {
        laylTk lltk = new laylTk();
        QuenMatKhau mk = new QuenMatKhau();
        QuenMKBus QuenMKBus = new QuenMKBus();
        public frmQuenMk()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            
            mk.emailTk = txtEmail.Text;
            string getpassword = lltk.laylaiTk(mk);
            string getUser = QuenMKBus.QuenTk(mk);


            switch (getpassword)
            {
                case "Email không được để trống":
                    MessageBox.Show("Email không được để trống");
                    return;
                case "Email không đúng!":
                    MessageBox.Show("Email không đúng!");
                    return;
                default:
                    MessageBox.Show("Mật Khẩu của bạn là: " + getpassword);
                    return;
            }
            
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            frmLogin newLogin = new frmLogin();
 
            newLogin.ShowDialog();
        }

        private void lblDangNhap_Click(object sender, EventArgs e)
        {
            frmLogin newLogin = new frmLogin();
            this.Hide();
            newLogin.ShowDialog();
        }

        private void lblDangKy_Click(object sender, EventArgs e)
        {
            frmSignup newSignup = new frmSignup();
            this.Hide();
            newSignup.ShowDialog();
        }
    }
}
