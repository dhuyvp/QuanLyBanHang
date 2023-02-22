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
    public partial class formQuenMatKhau : Form
    {
        public formQuenMatKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin _fr = new formLogin();
            _fr.Show();
            _fr.FormClosing += delegate { this.Close(); };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string matKhau = "";
            DataTable dt = Models.connection.FillDataSet("select tk_Password from TaiKhoan where tk_Username = '" + txtTenDangNhap.Text + "' and  is_KhachHang = 1" , CommandType.Text).Tables[0];
            if (dt.Rows.Count > 0)
            {
                matKhau = dt.Rows[0][0].ToString();
                MessageBox.Show("Mật khẩu của bạn là: '" + matKhau + "'");
            } else
            {
                dt = Models.connection.FillDataSet("select tk_Password from TaiKhoan where tk_Username = '" + txtTenDangNhap.Text + "' and  is_KhachHang = 0", CommandType.Text).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Tài khoản không cho phép xem mật khẩu!");
                }
                else
                {
                    MessageBox.Show("Tài khoản chưa tồn tại!");
                }
            }
        }
    }
}
