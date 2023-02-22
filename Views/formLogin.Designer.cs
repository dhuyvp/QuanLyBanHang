namespace QuanLyBanHang.Views
{
    partial class formLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnQuenMatKhau = new System.Windows.Forms.Button();
            this.btnTaoTaiKhoan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(284, 85);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(318, 31);
            this.txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(284, 142);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(318, 31);
            this.txtMatKhau.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDangNhap.Location = new System.Drawing.Point(174, 240);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(365, 39);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDangNhap_KeyDown);
            // 
            // btnQuenMatKhau
            // 
            this.btnQuenMatKhau.Location = new System.Drawing.Point(423, 187);
            this.btnQuenMatKhau.Name = "btnQuenMatKhau";
            this.btnQuenMatKhau.Size = new System.Drawing.Size(179, 28);
            this.btnQuenMatKhau.TabIndex = 4;
            this.btnQuenMatKhau.Text = "Quên mật khẩu?";
            this.btnQuenMatKhau.UseVisualStyleBackColor = true;
            this.btnQuenMatKhau.Click += new System.EventHandler(this.btnQuenMatKhau_Click);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Location = new System.Drawing.Point(174, 296);
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Size = new System.Drawing.Size(365, 39);
            this.btnTaoTaiKhoan.TabIndex = 4;
            this.btnTaoTaiKhoan.Text = "Tạo tài khoản mới";
            this.btnTaoTaiKhoan.UseVisualStyleBackColor = true;
            this.btnTaoTaiKhoan.Click += new System.EventHandler(this.btnTaoTaiKhoan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(571, 296);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 39);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Form đăng nhập hệ thống";
            // 
            // formLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.Customer_Login;
            this.ClientSize = new System.Drawing.Size(706, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQuenMatKhau);
            this.Controls.Add(this.btnTaoTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnQuenMatKhau;
        private System.Windows.Forms.Button btnTaoTaiKhoan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label3;
    }
}