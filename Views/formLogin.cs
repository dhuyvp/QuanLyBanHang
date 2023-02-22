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
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        public static string IDKhachHang;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (Models.LoginModel.KiemTraDangNhapAdmin(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                this.Hide();
                formMainAdmin _fr = new formMainAdmin();
                _fr.Show();
                _fr.FormClosing += delegate { this.Close(); };
                return;
            }
            if (Models.LoginModel.KiemTraDangNhapNhanVien(txtTenDangNhap.Text, txtMatKhau.Text) > 0)
            {
                Models.LoginModel.IDKhoQuanLy = Models.LoginModel.KiemTraDangNhapNhanVien(txtTenDangNhap.Text, txtMatKhau.Text);
                this.Hide();
                formMainNhanVien _fr = new formMainNhanVien();
                _fr.Show();
                _fr.FormClosing += delegate { this.Close(); };
                return;
            }
            if (Models.LoginModel.KiemTraDangNhapKhachHang(txtTenDangNhap.Text, txtMatKhau.Text))
            {
                IDKhachHang = txtTenDangNhap.Text;
                this.Hide();
                formMainKhachHang _frMainKhachHang = new formMainKhachHang();
                _frMainKhachHang.Show();
                _frMainKhachHang.FormClosing += delegate { this.Close(); };
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            formDangKyKhachHang _frDkyKhachHang = new formDangKyKhachHang();
            _frDkyKhachHang.Show();
            _frDkyKhachHang.FormClosing += delegate { this.Close(); };
        }

        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            this.Hide();
            formQuenMatKhau _fr = new formQuenMatKhau();
            _fr.Show();
            _fr.FormClosing += delegate { this.Close(); };
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }
    }
}
