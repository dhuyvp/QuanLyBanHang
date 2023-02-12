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
    public partial class uctThayDoiThongTin : UserControl
    {
        public static uctThayDoiThongTin _uctThayDoiThongTin = new uctThayDoiThongTin();
        public uctThayDoiThongTin()
        {
            InitializeComponent();
            _uctThayDoiThongTin = this;
        }

        private void uctThayDoiThongTin_Load(object sender, EventArgs e)
        {
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");

            DataTable dt = Models.connection.FillDataSet("select HoTen, GioiTinh, NgaySinh, DienThoai, Email, DiaChi from KhachHang where id_KhachHang ='" + Views.formLoginKhachHang.IDKhachHang + "'", CommandType.Text).Tables[0];
            txtHoTen.Text = dt.Rows[0][0].ToString();
            cmbGioiTinh.Text = dt.Rows[0][1].ToString();
            dtpNgaySinh.Value = DateTime.Parse(dt.Rows[0][2].ToString());
            txtDienThoai.Text = dt.Rows[0][3].ToString();
            txtEmail.Text = dt.Rows[0][4].ToString();
            txtDiaChi.Text = dt.Rows[0][5].ToString();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string matKhau = "";
            DataTable dt = Models.connection.FillDataSet("select tk_Password from TaiKhoan where tk_Username = '" + Views.formLoginKhachHang.IDKhachHang + "'", CommandType.Text).Tables[0];
            if (dt.Rows.Count > 0)
            {
                matKhau = dt.Rows[0][0].ToString();
            }
            int i = Controllers.KhachHangCtrl.UpdateKhachHang(Views.formLoginKhachHang.IDKhachHang, matKhau, txtHoTen.Text, cmbGioiTinh.Text, dtpNgaySinh.Value, txtDienThoai.Text, txtEmail.Text, txtDiaChi.Text);
            if (i > 0)
            {
                MessageBox.Show("Thay đổi thông tin thành công!");
            } else
            {
                MessageBox.Show("Thay đổi thông tin thất bại!");
            }
        }
    }
}
