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
            formLoginKhachHang _fr = new formLoginKhachHang();
            _fr.Show();
            _fr.FormClosing += delegate { this.Close(); };
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string matKhau = "";
            DataTable dt = Models.connection.FillDataSet("select tk_Password from TaiKhoan where tk_Username = '" + txtTenDangNhap.Text + "'", CommandType.Text).Tables[0];
            if (dt.Rows.Count > 0)
            {
                matKhau = dt.Rows[0][0].ToString();
                MessageBox.Show("Mật khẩu của bạn là: '" + matKhau + "'");
            } else
            {
                MessageBox.Show("Tài khoản chưa tồn tại!");
            }
        }
    }
}
