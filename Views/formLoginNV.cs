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
    public partial class formLoginNV : Form
    {
        public formLoginNV()
        {
            InitializeComponent();
        }

        public int IDKhoQuanLy { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            formStart _fr = new formStart();
            _fr.Show();
            _fr.FormClosing += delegate { this.Close(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Models.LoginModel.KiemTraDangNhapNhanVien(txtTaiKhoanNhanVien.Text, txtMatKhauNhanVien.Text) > 0)
            {
                Models.LoginModel.IDKhoQuanLy = Models.LoginModel.KiemTraDangNhapNhanVien(txtTaiKhoanNhanVien.Text, txtMatKhauNhanVien.Text);
                this.Hide();
                formMainNhanVien _fr = new formMainNhanVien();
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
