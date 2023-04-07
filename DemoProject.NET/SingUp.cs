using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DTO;
using BUS;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace DemoProject.NET
{
    public partial class frmSignup : Form
    {
        DangKyTaiKhoan taikhoanmoi = new DangKyTaiKhoan();
        DangkyBus dkbus = new DangkyBus();
        public frmSignup()
        {
            InitializeComponent();
        }

     

        private void gunaButton1_Click(object sender, EventArgs e)
        {

           this.Close();
            frmLogin login = new frmLogin();

            // Tìm kiếm form1 trong danh sách các form hiện có của ứng dụng
            Form existingForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.GetType() == login.GetType());

            // Nếu form1 đã được mở, hiển thị lại form1
            if (existingForm != null)
            {
                existingForm.Show();
            }

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

            frmLogin frmLogin = new frmLogin();
            Form existingForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.GetType() == frmLogin.GetType());

            // Nếu form1 đã được mở, hiển thị lại form1
            if (existingForm != null)
            {
                existingForm.Show();
            }
        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void lbldangnhap_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();

            // Tìm kiếm form1 trong danh sách các form hiện có của ứng dụng
            Form existingForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.GetType() == login.GetType());

            // Nếu form1 đã được mở, hiển thị lại form1
            if (existingForm != null)
            {
                existingForm.Show();
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtRetypepassword_TextChanged(object sender, EventArgs e)
        {
            txtRetypepassword.PasswordChar = '*';
        }

        private void btnhide1_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
            }else
            {
                txtPassword.PasswordChar = '*';
            }    
        }

        private void btnhide2_Click(object sender, EventArgs e)
        {
            if (txtRetypepassword.PasswordChar == '*')
            {
                txtRetypepassword.PasswordChar = '\0';
            }
            else
            {
                txtRetypepassword.PasswordChar = '*';
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            taikhoanmoi.emailTk = txtemail.Text;
            taikhoanmoi.tenTk = txtuser.Text;

            // kiểm tra user không bị trùng chưa sử dụng được
            //if (IsUsernameExist(txtuser.Text))
            //{
            //    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên đăng nhập khác.");
            //}
            //else
            //{
            //    // Đăng ký tài khoản mới
            //}

            taikhoanmoi.matkhauTk = txtPassword.Text;
            string getuser = dkbus.Dangkytk(taikhoanmoi);
            
            switch (getuser)
            {
                case "Email không được để trống":
                    MessageBox.Show("Email không được để trống");
                    return;
                case "Tên tài khoản không được để trống":
                    MessageBox.Show("Tên tài khoản không được để trống");
                    return;
                case "Mật khẩu không được để trống":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
            }
            if (txtPassword.Text != txtRetypepassword.Text)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác!");
                return;
            }
           
                DialogResult = MessageBox.Show("Bạn đã đăng ký tài khoản thành công!\n có muốn quay lại trang đăng nhập","Comfirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                
                if (DialogResult == DialogResult.Yes)
                {
                    frmLogin lg = new frmLogin();
                    this.Close();
                    lg.ShowDialog();

            }


        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {
            frmQuenMk frmQuenMk = new frmQuenMk();
            this.Hide();
            frmQuenMk.ShowDialog();
        }
        // kiểm tra user name 
        //public bool IsUsernameExist(string username)
        //{
        //    string connectionString = @"Data Source=TIENANH\SQLEXPRESS;Initial Catalog=QuanLyTTHPT;User ID=TienAnh;Password=Tienanh@123;Encrypt = false";
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        string query = "SELECT COUNT(*) FROM lblTaikhoan WHERE TenTk = @TenTk";
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@TenTk", username);
        //            int count = (int)command.ExecuteScalar();
        //            return (count > 0);
        //        }
        //    }
        //}
    }
}
