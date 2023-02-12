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
    public partial class formDangKyKhachHang : Form
    {
        public formDangKyKhachHang()
        {
            InitializeComponent();
        }

        private void formDangKyKhachHang_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.DropDownStyle= ComboBoxStyle.DropDownList;
            txtTaiKhoan.Text = string.Empty;
            txtMatKhau1.Text = string.Empty;
            txtMatKhau2.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtDienThoai.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtDiaChi.Text = string.Empty;

            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
        }
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string _taiKhoan = txtTaiKhoan.Text;
            string _matKhau = txtMatKhau1.Text;
            string _hoTen = txtHoTen.Text;
            string _gioiTinh = cmbGioiTinh.Text;
            DateTime _ngaySinh = dtpNgaySinh.Value;
            string _dienThoai = txtDienThoai.Text;
            string _email = txtEmail.Text;
            string _diaChi = txtDiaChi.Text;
            if (_taiKhoan == "" || _matKhau == "" || _hoTen == "" || _gioiTinh == "" || _dienThoai == "" || _email == "" || _diaChi == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
                return;
            }
            if (txtMatKhau1.Text != txtMatKhau2.Text || txtMatKhau1.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khớp mật khẩu và khác rỗng!");
                return;
            }
            string[] pars = new string[] { "@tk_Username" };
            object[] values = new object[] { _taiKhoan };
            
            string ret = Models.connection.ExcuteScalar("select dbo.checkTKKhachHang(@tk_Username)", CommandType.StoredProcedure, pars, values); 
            if (ret == "true")
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            } else
            {
                int i = Controllers.KhachHangCtrl.InsertKhachHang(_taiKhoan, _matKhau, _hoTen, _gioiTinh, _ngaySinh, _dienThoai, _email, _diaChi);
                if (i > 0)
                {
                    MessageBox.Show("Đăng ký tài khoản thành công!");
                    this.Hide();
                    formLoginKhachHang _frLoginKhachHang = new formLoginKhachHang();
                    _frLoginKhachHang.Show();
                    _frLoginKhachHang.FormClosing += delegate { this.Close(); };
                } else
                {
                    MessageBox.Show("Đăng ký tài khoản thất bại!");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLoginKhachHang _fr = new formLoginKhachHang();
            _fr.Show();
            _fr.FormClosing += delegate { this.Close(); };
        }
    }
}
