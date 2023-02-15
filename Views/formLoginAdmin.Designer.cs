
namespace QuanLyBanHang.Views
{
    partial class formLoginAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoanAdmin = new System.Windows.Forms.TextBox();
            this.txtMatKhauAdmin = new System.Windows.Forms.TextBox();
            this.btnOKLogin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(497, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form đăng nhập Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(344, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(344, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTaiKhoanAdmin
            // 
            this.txtTaiKhoanAdmin.Location = new System.Drawing.Point(502, 165);
            this.txtTaiKhoanAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoanAdmin.Name = "txtTaiKhoanAdmin";
            this.txtTaiKhoanAdmin.Size = new System.Drawing.Size(314, 26);
            this.txtTaiKhoanAdmin.TabIndex = 3;
            // 
            // txtMatKhauAdmin
            // 
            this.txtMatKhauAdmin.Location = new System.Drawing.Point(502, 213);
            this.txtMatKhauAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauAdmin.Name = "txtMatKhauAdmin";
            this.txtMatKhauAdmin.PasswordChar = '*';
            this.txtMatKhauAdmin.Size = new System.Drawing.Size(314, 26);
            this.txtMatKhauAdmin.TabIndex = 4;
            // 
            // btnOKLogin
            // 
            this.btnOKLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOKLogin.Location = new System.Drawing.Point(502, 311);
            this.btnOKLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOKLogin.Name = "btnOKLogin";
            this.btnOKLogin.Size = new System.Drawing.Size(108, 46);
            this.btnOKLogin.TabIndex = 5;
            this.btnOKLogin.Text = "Đăng nhập";
            this.btnOKLogin.UseVisualStyleBackColor = false;
            this.btnOKLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(707, 311);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 46);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.admin_login;
            this.pictureBox1.Location = new System.Drawing.Point(12, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // formLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 492);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOKLogin);
            this.Controls.Add(this.txtMatKhauAdmin);
            this.Controls.Add(this.txtTaiKhoanAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formLoginAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoanAdmin;
        private System.Windows.Forms.TextBox txtMatKhauAdmin;
        private System.Windows.Forms.Button btnOKLogin;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}