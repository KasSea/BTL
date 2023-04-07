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

namespace DemoProject.NET
{
    public partial class frmLogin : Form
    {
        private int PreviousWidth;
        private int PreviousHeight;
        TaiKhoan taiKhoan = new TaiKhoan();
        TaiKhoanBus tkbus = new TaiKhoanBus();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void gunaSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gunaSwitch1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.PreviousWidth = this.Width;
            this.PreviousHeight = this.Height;
           

        } 

        private void gunaButton1_Click(object sender, EventArgs e)
        {  
            taiKhoan.tenTk = txtName.Text;
            taiKhoan.matkhauTk = txtPassword.Text;
            string getUser = tkbus.Checklogin(taiKhoan);
            // thể hiện trả lại nếu nghiệp vụ không đúng
            switch (getUser)
            {
                case "Lỗi User":
                    MessageBox.Show("Tài Khoản không được để trống!");
                    return;
                case "Lỗi Password":
                    MessageBox.Show("Mật khẩu không được để trống!");
                    return;
                case "Tài Khoản mật khẩu không chính xác!":
                    MessageBox.Show("Tài Khoản mật khẩu không chính xác!");
                    return;

            }

            frmHome home = new frmHome();
            this.Hide();

            home.ShowDialog();
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            frmQuenMk qmk = new frmQuenMk();
            this.Hide();
            qmk.ShowDialog();
        }

        private void gunaControlBox1_Click_1(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                control.Scale(new SizeF((float)this.Width / this.PreviousWidth, (float)this.Height / this.PreviousHeight));
            }
            this.PreviousWidth = this.Width;
            this.PreviousHeight = this.Height;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignup frmSignup = new frmSignup();
            this.Hide();

            frmSignup.ShowDialog();
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaControlBox2_Click_1(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void btnhienthipass_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {
            

        }
    }
}
