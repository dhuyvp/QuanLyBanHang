using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Views
{
    public partial class formLoginAdmin : Form
    {
        public formLoginAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStart _fr = new formStart();
            _fr.Show();
            _fr.FormClosing += delegate { this.Close(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Models.LoginModel.KiemTraDangNhapAdmin(txtTaiKhoanAdmin.Text, txtMatKhauAdmin.Text) )
            {
                this.Hide();
                formMainAdmin _fr = new formMainAdmin();
                _fr.Show();
                _fr.FormClosing += delegate { this.Close(); };
            }    
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
