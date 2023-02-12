
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(233, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form đăng nhập Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTaiKhoanAdmin
            // 
            this.txtTaiKhoanAdmin.Location = new System.Drawing.Point(237, 106);
            this.txtTaiKhoanAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTaiKhoanAdmin.Name = "txtTaiKhoanAdmin";
            this.txtTaiKhoanAdmin.Size = new System.Drawing.Size(280, 22);
            this.txtTaiKhoanAdmin.TabIndex = 3;
            // 
            // txtMatKhauAdmin
            // 
            this.txtMatKhauAdmin.Location = new System.Drawing.Point(237, 144);
            this.txtMatKhauAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMatKhauAdmin.Name = "txtMatKhauAdmin";
            this.txtMatKhauAdmin.PasswordChar = '*';
            this.txtMatKhauAdmin.Size = new System.Drawing.Size(280, 22);
            this.txtMatKhauAdmin.TabIndex = 4;
            // 
            // btnOKLogin
            // 
            this.btnOKLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOKLogin.Location = new System.Drawing.Point(237, 222);
            this.btnOKLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOKLogin.Name = "btnOKLogin";
            this.btnOKLogin.Size = new System.Drawing.Size(96, 37);
            this.btnOKLogin.TabIndex = 5;
            this.btnOKLogin.Text = "Đăng nhập";
            this.btnOKLogin.UseVisualStyleBackColor = false;
            this.btnOKLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 222);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // formLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
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
    }
}