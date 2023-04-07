namespace DemoProject.NET
{
    partial class frmQuenMk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDragControl1 = new Guna.UI.WinForms.GunaDragControl(this.components);
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnXacnhan = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.lblDangNhap = new Guna.UI.WinForms.GunaLabel();
            this.lblDangKy = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.gunaControlBox1 = new Guna.UI.WinForms.GunaControlBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDragControl1
            // 
            this.gunaDragControl1.TargetControl = this;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::DemoProject.NET.Properties.Resources.logo2;
            this.gunaPictureBox1.Location = new System.Drawing.Point(324, -4);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(354, 109);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(164, 23);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Quên Mật Khẩu ?";
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.AnimationHoverSpeed = 0.07F;
            this.btnXacnhan.AnimationSpeed = 0.03F;
            this.btnXacnhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacnhan.BaseColor = System.Drawing.Color.DarkOrchid;
            this.btnXacnhan.BorderColor = System.Drawing.Color.Black;
            this.btnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacnhan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXacnhan.FocusedColor = System.Drawing.Color.Empty;
            this.btnXacnhan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Image = null;
            this.btnXacnhan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXacnhan.Location = new System.Drawing.Point(22, 161);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.OnHoverBaseColor = System.Drawing.Color.DarkOrchid;
            this.btnXacnhan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXacnhan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXacnhan.OnHoverImage = null;
            this.btnXacnhan.OnPressedColor = System.Drawing.Color.Black;
            this.btnXacnhan.Radius = 6;
            this.btnXacnhan.Size = new System.Drawing.Size(391, 42);
            this.btnXacnhan.TabIndex = 3;
            this.btnXacnhan.Text = "Xác Nhận";
            this.btnXacnhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(100, 227);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(147, 20);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Bạn đã có tài khoản?";
            // 
            // lblDangNhap
            // 
            this.lblDangNhap.AutoSize = true;
            this.lblDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDangNhap.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblDangNhap.Location = new System.Drawing.Point(253, 227);
            this.lblDangNhap.Name = "lblDangNhap";
            this.lblDangNhap.Size = new System.Drawing.Size(86, 20);
            this.lblDangNhap.TabIndex = 5;
            this.lblDangNhap.Text = "Đăng nhập!";
            this.lblDangNhap.Click += new System.EventHandler(this.lblDangNhap_Click);
            // 
            // lblDangKy
            // 
            this.lblDangKy.AutoSize = true;
            this.lblDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDangKy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDangKy.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblDangKy.Location = new System.Drawing.Point(142, 258);
            this.lblDangKy.Name = "lblDangKy";
            this.lblDangKy.Size = new System.Drawing.Size(162, 20);
            this.lblDangKy.TabIndex = 6;
            this.lblDangKy.Text = "Đăng ký tài khoản mới!";
            this.lblDangKy.Click += new System.EventHandler(this.lblDangKy_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.Menu;
            this.gunaPanel1.Controls.Add(this.txtEmail);
            this.gunaPanel1.Controls.Add(this.gunaLabel5);
            this.gunaPanel1.Controls.Add(this.btnXacnhan);
            this.gunaPanel1.Controls.Add(this.lblDangKy);
            this.gunaPanel1.Controls.Add(this.lblDangNhap);
            this.gunaPanel1.Controls.Add(this.gunaLabel2);
            this.gunaPanel1.Controls.Add(this.gunaButton2);
            this.gunaPanel1.Location = new System.Drawing.Point(214, 135);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(450, 294);
            this.gunaPanel1.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderRadius = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(66, 90);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(347, 42);
            this.txtEmail.TabIndex = 7;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(17, 15);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(416, 56);
            this.gunaLabel5.TabIndex = 0;
            this.gunaLabel5.Text = "Nhập địa chỉ email của bạn và chúng tôi sẽ  gửi lại bạn mật khẩu.";
            this.gunaLabel5.Click += new System.EventHandler(this.gunaLabel5_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.LightGray;
            this.gunaButton2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = global::DemoProject.NET.Properties.Resources.email12312312;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(22, 90);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.LightGray;
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Gainsboro;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 6;
            this.gunaButton2.Size = new System.Drawing.Size(48, 42);
            this.gunaButton2.TabIndex = 3;
            // 
            // gunaControlBox1
            // 
            this.gunaControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox1.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox1.AnimationSpeed = 0.03F;
            this.gunaControlBox1.IconColor = System.Drawing.Color.Black;
            this.gunaControlBox1.IconSize = 15F;
            this.gunaControlBox1.Location = new System.Drawing.Point(836, 2);
            this.gunaControlBox1.Name = "gunaControlBox1";
            this.gunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox1.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox1.Size = new System.Drawing.Size(45, 29);
            this.gunaControlBox1.TabIndex = 8;
            this.gunaControlBox1.Click += new System.EventHandler(this.gunaControlBox1_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gunaLabel3.Location = new System.Drawing.Point(465, 47);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(52, 28);
            this.gunaLabel3.TabIndex = 9;
            this.gunaLabel3.Text = "Null";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.DarkOrchid;
            this.gunaLabel4.Location = new System.Drawing.Point(426, 22);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(54, 60);
            this.gunaLabel4.TabIndex = 10;
            this.gunaLabel4.Text = "K";
            // 
            // frmQuenMk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(883, 494);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaControlBox1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQuenMk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel lblDangKy;
        private Guna.UI.WinForms.GunaLabel lblDangNhap;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton btnXacnhan;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaDragControl gunaDragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
    }
}