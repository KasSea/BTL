using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Web.UI.WebControls;

namespace DemoProject.NET
{
    public partial class frmHome : Form
    {
        public GunaButton previousButton = null;

        public frmHome()
        {
            InitializeComponent();
            btnTailieu.PerformClick();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnMenu.Visible = true;
            gunaElipsePanel1.Visible = false;
            
            

        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //picHome.Visible = true;
           
        }


        
        private void btnTailieu_Click(object sender, EventArgs e)
        {
            //picHome.Visible = true;
            btnMenu.Visible = true;

            if (previousButton != null && previousButton != btnTailieu)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnTailieu.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnTailieu;

            dtgvHienThiTL.Visible = true;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            picHome.Visible = true;
        }

        private void menuChoice_Opening(object sender, CancelEventArgs e)
        {
         
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
          

        }

        private void menuThem_Click(object sender, EventArgs e)
        {

        }

        private void menuChoi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            dtgvHienThiTL.Visible = true;

            btnMenu.Visible = true;
            if (previousButton != null && previousButton != btnDiem)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnDiem.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnDiem;
            
        }

        private void btnHocsinh_Click(object sender, EventArgs e)
        {
            dtgvHienThiTL.Visible = true;

            btnMenu.Visible = true;

            if (previousButton != null && previousButton != btnHocsinh)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnHocsinh.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnHocsinh;
        }

        private void btnGiaovien_Click(object sender, EventArgs e)
        {
            dtgvHienThiTL.Visible = true;

            btnMenu.Visible = true;
            if (previousButton != null && previousButton != btnGiaovien)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnGiaovien.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnGiaovien;
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            dtgvHienThiTL.Visible = true;

            if (previousButton != null && previousButton != btnLopHoc)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnLopHoc.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnLopHoc;
        }

        private void btnThoikhoabieu_Click(object sender, EventArgs e)
        {
            dtgvHienThiTL.Visible = true;

            if (previousButton != null && previousButton != btnThoikhoabieu)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnThoikhoabieu.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnThoikhoabieu;
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            dtgvHienThiTL.Visible = true;

            if (previousButton != null && previousButton != btnTaikhoan)
            {
                previousButton.BaseColor = Color.FromArgb(45, 50, 56);
            }
            // Đặt màu sắc mới cho button hiện tại
            btnTaikhoan.BaseColor = Color.Gray;
            // Lưu button hiện tại là button trước đó
            previousButton = btnTaikhoan;
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
          
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            btnTk.ContextMenuStrip = menuTK;
            btnTk.ContextMenuStrip.Show(btnTk, new Point(0, btnTk.Height));

        }

        private void menuTK_Opening(object sender, CancelEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void mnstChoice_Opening(object sender, CancelEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
           if (gunaElipsePanel1.Visible == false)
            {
                gunaElipsePanel1.Visible = true;

            }
            else
            {
                gunaElipsePanel1.Visible = false;

            }
        }

        private void gunaControlBox3_Click(object sender, EventArgs e)
        {

        }

        private void dtgHienThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXemTL_Click(object sender, EventArgs e)
        {
            QuanLyTaiLieuBUS.Instance.Xem(dtgvHienThiTL);
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string name = txtTimKiem.Text;
            
            dtgvHienThiTL.DataSource = TimkiemTailieuBUS.Instance.Xem(name);
        }

        private void gunaLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvHienThiTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gunaLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel6_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnMenuchoice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuTK_Opening_1(object sender, CancelEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
