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
    public partial class uctDoiMatKhau : UserControl
    {
        public static uctDoiMatKhau _uctDoiMatKhau = new uctDoiMatKhau();
        public uctDoiMatKhau()
        {
            InitializeComponent();
            _uctDoiMatKhau = this;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhauCu = "";
            DataTable dt = Models.connection.FillDataSet("select tk_Password from TaiKhoan where tk_Username = '" + Views.formLogin.IDKhachHang + "'", CommandType.Text).Tables[0];
            if (dt.Rows.Count > 0)
            {
                matKhauCu = dt.Rows[0][0].ToString();
            }
            if (txtMatKhauHienTai.Text != matKhauCu)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!");
            } else
            {
                if (txtMatKhau1.Text != txtMatKhau2.Text || txtMatKhau1.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập khớp mật khẩu và khác rỗng!");
                } else
                {
                    int i = 0;
                    i = Controllers.KhachHangCtrl.UpdateTaiKhoan(txtMatKhau1.Text);
                    if (i > 0)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công! Vui lòng đăng nhập lại!");
                        formLogin f2 = new formLogin();
                        f2.Show();
                        Views.formMainKhachHang._formMainKhachHang.Hide();
                        f2.FormClosing += delegate { Views.formMainKhachHang._formMainKhachHang.Close(); };
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi mật khẩu thất bại!");
                    }
                }
            }
        }

    }
}
