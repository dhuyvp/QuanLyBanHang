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
    public partial class uctXemHoaDon : UserControl
    {
        public uctXemHoaDon()
        {
            InitializeComponent();
        }
        public static uctXemHoaDon _uctHoaDon = new uctXemHoaDon();
        void HienThiDSHangHoa(string maHoaDon)
        {
            dgvDanhSachHangTrongHoaDon.DataSource = Models.connection.FillDataSet("exec spGetDSHangHoaTheoHoaDon @MaHoaDon='" + maHoaDon + "'", CommandType.Text).Tables[0];
            dgvDanhSachHangTrongHoaDon.Dock = DockStyle.Fill;
            dgvDanhSachHangTrongHoaDon.RowHeadersVisible = false;
            dgvDanhSachHangTrongHoaDon.AllowUserToAddRows = false;

            dgvDanhSachHangTrongHoaDon.Columns[1].HeaderText = "Mã hóa đơn";
            dgvDanhSachHangTrongHoaDon.Columns[1].HeaderText = "ID hàng hóa";
            dgvDanhSachHangTrongHoaDon.Columns[2].HeaderText = "Kho quản lý";
            dgvDanhSachHangTrongHoaDon.Columns[3].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangTrongHoaDon.Columns[4].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangTrongHoaDon.Columns[4].Width = 200;
            dgvDanhSachHangTrongHoaDon.Columns[5].HeaderText = "Giá tiền";
            dgvDanhSachHangTrongHoaDon.Columns[6].HeaderText = "Ngày sản xuất";
            dgvDanhSachHangTrongHoaDon.Columns[7].HeaderText = "Hạn sử dụng";
        }
        private void uctXemHoaDon_Load(object sender, EventArgs e)
        {
            cmbMaHoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            HienThiDSHangHoa("");
            GetAllHoaDon();
        }
        void GetAllHoaDon()
        {
            cmbMaHoaDon.Items.Clear();
            DataTable dc = Models.HoaDonModel.FillDataSetDSHoaDonByIDKhachHang().Tables[0];
            for (int i = 0; i < dc.Rows.Count; i++)
            {
                cmbMaHoaDon.Items.Add(dc.Rows[i][0].ToString());

            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbMaHoaDon.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn hóa đơn muốn kiểm tra!");
            }
            else
            {
                HienThiDSHangHoa(cmbMaHoaDon.Text);
            }
        }
    }
}
