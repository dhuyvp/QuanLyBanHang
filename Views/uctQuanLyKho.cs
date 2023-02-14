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
    public partial class uctQuanLyKho : UserControl
    {
        public static uctQuanLyKho _uctQLyKho = new uctQuanLyKho();
        public uctQuanLyKho()
        {
            InitializeComponent();
            _uctQLyKho = this;
        }
        int flag = 0;
        public void uctQuanLyKho_Load(object sender, EventArgs e)
        {
            dgvDSKho.ReadOnly = true;
            cmbDiaChi.DropDownStyle = ComboBoxStyle.DropDownList;
            HienThiDSKho();
            DataBinding();
            Dis_Enable(false);
        }
        void HienThiDSKho()
        {
            dgvDSKho.DataSource = Models.KhoHangModel.FillDataSetDSKho().Tables[0];
            dgvDSKho.Dock = DockStyle.Fill;
            dgvDSKho.RowHeadersVisible = false;
            dgvDSKho.AllowUserToAddRows = false;

            dgvDSKho.Columns[0].HeaderText = "ID Kho";
            dgvDSKho.Columns[1].HeaderText = "Địa chỉ";
            dgvDSKho.Columns[2].HeaderText = "Quỹ tiền";
            dgvDSKho.Columns[3].HeaderText = "Số nhân viên";
            dgvDSKho.Columns[4].HeaderText = "Số hàng hóa";
        }
        void DataBinding()
        {
            txtIDKhoQuanLy.DataBindings.Clear();
            txtIDKhoQuanLy.DataBindings.Add("Text", dgvDSKho.DataSource, "id_KhoQuanLy");
            txtTaiChinh.DataBindings.Clear();
            txtTaiChinh.DataBindings.Add("Text", dgvDSKho.DataSource, "TaiChinh");
            cmbDiaChi.DataBindings.Clear();
            cmbDiaChi.DataBindings.Add("Text", dgvDSKho.DataSource, "DiaChi");
        }
        void Dis_Enable(bool e)
        {
            txtIDKhoQuanLy.Enabled = false;
            txtTaiChinh.Enabled = e;
            cmbDiaChi.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        void clearData()
        {
            txtIDKhoQuanLy.Text = Models.connection.ExcuteScalar("select dbo.funGetNextIDKhoHang()"); ;
            cmbDiaChi.Text = "";
            txtTaiChinh.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_Enable(true);
            clearData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            Dis_Enable(true);
        }
        int GetValue(string col, int idKho)
        {
            int ret = 0;
            string strQuery = "select count(*) from " + col +" where id_KhoQuanLy ='" + idKho.ToString() + "'";
            DataTable dt = Models.connection.FillDataSet(strQuery, CommandType.Text).Tables[0];
            ret = int.Parse(dt.Rows[0][0].ToString());
            return ret;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idKho = int.Parse(txtIDKhoQuanLy.Text);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int ketQua = Controllers.KhoHangCtrl.DeleteKhoHang(idKho);
                if (ketQua > 0)
                {
                    MessageBox.Show("Xóa kho hàng thành công!");
                    uctQuanLyKho_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa kho hàng thất bại!");
                }
            }
            Views.uctQuanLyNhanVien._uctQlyNhanVien.uctQuanLyNhanVien_Load(sender, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int idKho = -1;
            bool is_idNum = int.TryParse(txtIDKhoQuanLy.Text, out idKho);
            string diaChi = cmbDiaChi.Text;
            int taiChinh = -1;
            bool isNum = int.TryParse(txtTaiChinh.Text, out taiChinh);
            int soNhanVien = GetValue("NhanVien", idKho);
            int soHangHoa = GetValue("HangHoa", idKho);

            if (diaChi == "" || txtTaiChinh.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!");
                return;
            }
            if (is_idNum == false || idKho < 0)
            {
                MessageBox.Show("ID kho chưa là số nguyên dương!");
                return;
            }
            if (isNum == false || taiChinh < 0)
            {
                MessageBox.Show("Quỹ tiền chưa là số nguyên không âm!");
                return;
            }
            if (flag == 0)
            {
                int ketQua = 0;
                ketQua = Controllers.KhoHangCtrl.InsertKhoHang(idKho, diaChi, taiChinh, soNhanVien, soHangHoa);
                if (ketQua > 0)
                {
                    MessageBox.Show("Thêm mới kho hàng thành công!");
                    HienThiDSKho();
                }
                else
                {
                    MessageBox.Show("Thêm mới kho hàng thất bại!");
                }
            }
            else
            {
                int ketQua = 0;

                ketQua = Controllers.KhoHangCtrl.UpdateKhoHang(idKho, diaChi, taiChinh, soNhanVien, soHangHoa);
                if (ketQua > 0)
                {
                    MessageBox.Show("Sửa đổi thông tin kho hàng thành công!");
                    HienThiDSKho();
                }
                else
                {
                    MessageBox.Show("Sửa đổi thông tin hàng hóa thất bại!");
                }
            }
            uctQuanLyKho_Load(sender, e);
            Views.uctQuanLyNhanVien._uctQlyNhanVien.uctQuanLyNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctQuanLyKho_Load(sender, e);
        }
    }
}
