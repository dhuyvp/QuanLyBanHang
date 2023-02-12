
namespace QuanLyBanHang.Views
{
    partial class formLoginNV
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
            this.btnOKLogin = new System.Windows.Forms.Button();
            this.txtMatKhauNhanVien = new System.Windows.Forms.TextBox();
            this.txtTaiKhoanNhanVien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOKLogin
            // 
            this.btnOKLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOKLogin.Location = new System.Drawing.Point(258, 222);
            this.btnOKLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOKLogin.Name = "btnOKLogin";
            this.btnOKLogin.Size = new System.Drawing.Size(96, 37);
            this.btnOKLogin.TabIndex = 11;
            this.btnOKLogin.Text = "Đăng nhập";
            this.btnOKLogin.UseVisualStyleBackColor = false;
            this.btnOKLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMatKhauNhanVien
            // 
            this.txtMatKhauNhanVien.Location = new System.Drawing.Point(258, 146);
            this.txtMatKhauNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauNhanVien.Name = "txtMatKhauNhanVien";
            this.txtMatKhauNhanVien.PasswordChar = '*';
            this.txtMatKhauNhanVien.Size = new System.Drawing.Size(280, 22);
            this.txtMatKhauNhanVien.TabIndex = 10;
            // 
            // txtTaiKhoanNhanVien
            // 
            this.txtTaiKhoanNhanVien.Location = new System.Drawing.Point(258, 109);
            this.txtTaiKhoanNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoanNhanVien.Name = "txtTaiKhoanNhanVien";
            this.txtTaiKhoanNhanVien.Size = new System.Drawing.Size(280, 22);
            this.txtTaiKhoanNhanVien.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Form đăng nhập Nhân viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(441, 222);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 37);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // formLoginNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnOKLogin);
            this.Controls.Add(this.txtMatKhauNhanVien);
            this.Controls.Add(this.txtTaiKhoanNhanVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formLoginNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOKLogin;
        private System.Windows.Forms.TextBox txtMatKhauNhanVien;
        private System.Windows.Forms.TextBox txtTaiKhoanNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
    }
}