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
    public partial class uctQuanLyKhoHang : UserControl
    {
        public uctQuanLyKhoHang()
        {
            InitializeComponent();
        }
        int flag = 0;
        public static uctQuanLyKhoHang _uctQLyNhanVien = new uctQuanLyKhoHang();
        public void uctQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDSHangHoa();
            dis_enable(false);
            DataBinding();
        }
        void HienThiDSHangHoa()
        {
            dgvDSHangHoa.DataSource = Models.HangHoaModel.FillDataSetDSHangHoaByIDKho().Tables[0];
            dgvDSHangHoa.Dock = DockStyle.Fill;
            dgvDSHangHoa.RowHeadersVisible = false;
            dgvDSHangHoa.AllowUserToAddRows = false;

            dgvDSHangHoa.Columns[0].HeaderText = "ID hàng hóa";
            dgvDSHangHoa.Columns[1].HeaderText = "Kho quản lý";
            dgvDSHangHoa.Columns[2].HeaderText = "Mã hàng hóa";
            dgvDSHangHoa.Columns[3].HeaderText = "Tên hàng hóa";
            dgvDSHangHoa.Columns[3].Width = 200;
            dgvDSHangHoa.Columns[4].HeaderText = "Giá tiền";
            dgvDSHangHoa.Columns[5].HeaderText = "Ngày sản xuất";
            dgvDSHangHoa.Columns[6].HeaderText = "Hạn sử dụng";
        }

        void DataBinding()
        {
            txtIDHangHoa.DataBindings.Clear();
            txtIDHangHoa.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "id_HangHoa");
            txtKhoQuanLy.DataBindings.Clear();
            txtKhoQuanLy.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "id_KhoQuanLy");
            txtMaHangHoa.DataBindings.Clear();
            txtMaHangHoa.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "MaHangHoa");
            txtTenHangHoa.DataBindings.Clear();
            txtTenHangHoa.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "TenHangHoa");
            txtGiaTien.DataBindings.Clear();
            txtGiaTien.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "GiaTien");
            dtpNgaySanXuat.DataBindings.Clear();
            dtpNgaySanXuat.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "NgaySanXuat");
            dtpHanSD.DataBindings.Clear();
            dtpHanSD.DataBindings.Add("Text", dgvDSHangHoa.DataSource, "HanSD");
        }
        void clearData()
        {
            txtIDHangHoa.Text = Models.connection.ExcuteScalar("select dbo.funGetNextIDHangHoa()");
            txtKhoQuanLy.Text = Models.LoginModel.IDKhoQuanLy.ToString();
            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            txtGiaTien.Text = "";
        }
        void dis_enable(bool e)
        {
            txtIDHangHoa.Enabled = false;
            txtKhoQuanLy.Enabled = false;
            txtMaHangHoa.Enabled = e;
            txtTenHangHoa.Enabled = e;
            txtGiaTien.Enabled = e;
            dtpNgaySanXuat.Enabled = e;
            dtpHanSD.Enabled = e;

            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_enable(true);
            clearData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_enable(true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idHangHoa = txtIDHangHoa.Text;
            int _idKhoQuanLy = 0;
            try
            {
                _idKhoQuanLy = Convert.ToInt32(txtKhoQuanLy.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            string _maHangHoa = txtMaHangHoa.Text;
            string _tenHangHoa = txtTenHangHoa.Text;
            int _giaTien = 0;
            try
            {
                _giaTien = Convert.ToInt32(txtGiaTien.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            DateTime _dtpNgaySanXuat = dtpNgaySanXuat.Value;
            DateTime _dtpHanSD = dtpHanSD.Value;

            if (flag == 0)
            {
                if (_idHangHoa == "" || _idKhoQuanLy <= 0 || _maHangHoa == "" || _tenHangHoa == "" || _giaTien <= 0 || DateTime.Compare(_dtpNgaySanXuat, _dtpHanSD) >= 0)
                {
                    MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!");
                }
                else
                {
                    int ketQua = 0;
                    ketQua = Controllers.HangHoaCtrl.InsertHangHoa(_idHangHoa, _idKhoQuanLy, _maHangHoa, _tenHangHoa, _giaTien, _dtpNgaySanXuat, _dtpHanSD, 0);
                    if (ketQua > 0)
                    {
                        MessageBox.Show("Thêm mới thông tin hàng hóa thành công!");
                        HienThiDSHangHoa();
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới thông tin hàng hóa thất bại!");
                    }
                }
            }
            else
            {
                int ketQua = 0;

                ketQua = Controllers.HangHoaCtrl.UpdateHangHoaByID(_idHangHoa, _idKhoQuanLy, _maHangHoa, _tenHangHoa, _giaTien, _dtpNgaySanXuat, _dtpHanSD, 0);
                if (ketQua > 0)
                {
                    MessageBox.Show("Sửa đổi thông tin hàng hóa thành công!");
                    HienThiDSHangHoa();
                }
                else
                {
                    MessageBox.Show("Sửa đổi thông tin hàng hóa thất bại!");
                }
            }
            uctQuanLyNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctQuanLyNhanVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idHangHoaXoa = "";
            try
            {
                _idHangHoaXoa = txtIDHangHoa.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int ketQua = Controllers.HangHoaCtrl.DeleteHangHoaByID(_idHangHoaXoa);
                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa hàng hóa thành công!");
                    uctQuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa hàng hóa thất bại!");
                }
            }
        }
    }
}
