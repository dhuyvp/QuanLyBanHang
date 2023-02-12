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
    public partial class uctQuanLyNhanVien : UserControl
    {
        public static uctQuanLyNhanVien _uctQlyNhanVien = new uctQuanLyNhanVien();
        public uctQuanLyNhanVien()
        {
            InitializeComponent();
            _uctQlyNhanVien = this;
        }
        int flag = 0;
        private void uctQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cmbIDKho.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            HienThiDSNhanVien();
            DataBinding();
            Dis_Enable(false);
            GetAllKhoHang();
        }
        void GetAllKhoHang()
        {
            cmbIDKho.Items.Clear();
            DataTable dc = Models.MuaHangModel.FillDataSetDSIDKho().Tables[0];
            for (int i = 0; i < dc.Rows.Count; i++)
            {
                if (int.Parse(dc.Rows[i][0].ToString()) != 0)
                {
                    cmbIDKho.Items.Add(dc.Rows[i][0].ToString());
                }
            }
        }
        public void HienThiDSNhanVien()
        {
            dgvDSNhanVien.DataSource = Models.NhanVienModel.FillDataSetDSNhanVien().Tables[0];
            dgvDSNhanVien.Dock = DockStyle.Fill;
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.AllowUserToAddRows = false;

            dgvDSNhanVien.Columns[0].HeaderText = "ID nhân viên";
            dgvDSNhanVien.Columns[1].HeaderText = "Kho quản lý";
            dgvDSNhanVien.Columns[2].HeaderText = "Họ tên";
            dgvDSNhanVien.Columns[2].Width = 150;
            dgvDSNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns[5].HeaderText = "Điện thoại";
            dgvDSNhanVien.Columns[6].HeaderText = "Email";
            dgvDSNhanVien.Columns[7].HeaderText = "Địa chỉ";
            dgvDSNhanVien.Columns[7].Width = 200;
        }

        void DataBinding()
        {
            txtIdNhanVien.DataBindings.Clear();
            txtIdNhanVien.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "id_NhanVien");
            cmbIDKho.DataBindings.Clear();
            cmbIDKho.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "id_KhoQuanLy");
            txtHoTen.DataBindings.Clear();
            txtHoTen.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "HoTen");
            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "NgaySinh");
            cmbGioiTinh.DataBindings.Clear();
            cmbGioiTinh.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "GioiTinh");
            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "DienThoai");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "Email");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dgvDSNhanVien.DataSource, "DiaChi");
        }
        // Enable button or not based on bool e
        void Dis_Enable(bool e)
        {
            txtIdNhanVien.Enabled = false;
            txtHoTen.Enabled = e;
            cmbIDKho.Enabled = e;
            dtpNgaySinh.Enabled = e;
            cmbGioiTinh.Enabled = e;
            txtDiaChi.Enabled = e;
            txtDienThoai.Enabled = e;
            txtEmail.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThem.Enabled = !e;
            btnSua.Enabled = !e;
            btnXoa.Enabled = !e;
        }
        // Load items into control  
        void loadcontrol()
        {
            cmbGioiTinh.Items.Clear();
            cmbGioiTinh.Items.Add("Nam");
            cmbGioiTinh.Items.Add("Nữ");
            cmbGioiTinh.Items.Add("Khác");
        }
        // function used to delete the data of textboxes whenever we click on the button 
        void clearData()
        {
            txtIdNhanVien.Text = Models.connection.ExcuteScalar("select dbo.funGetNextIDNhanVien()");
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            loadcontrol();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            clearData();
            Dis_Enable(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 0;
            Dis_Enable(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idNhanVien = txtIdNhanVien.Text;
            MessageBox.Show(_idNhanVien);
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uctQuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIdNhanVien.Text;
            }
            catch { }
            string _hoTen = "";
            try
            {
                _hoTen = txtHoTen.Text;
            }
            catch { }
            int _idKho = 0;
            try
            {
                _idKho = Convert.ToInt32(cmbIDKho.Text);
            }
            catch { }
            DateTime _ngaySinh = dtpNgaySinh.Value;
            string _gioiTinh = "";
            try
            {
                _gioiTinh = cmbGioiTinh.Text;
            }
            catch { }
            string _dienThoai = "";
            try
            {
                _dienThoai = txtDienThoai.Text;
            }
            catch { }
            string _email = "";
            try
            {
                _email = txtEmail.Text;
            }
            catch { }
            string _diaChi = "";
            try
            {
                _diaChi = txtDiaChi.Text;
            }
            catch { }

            if (flag == 1)
            {
                if (_idNhanVien == "" || _idKho <= 0 || _hoTen == "" || _gioiTinh == "" || _dienThoai == "" || _email == "" || _diaChi == "")
                {
                    MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!");
                }
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.InsertNhanVien(_idNhanVien, _idKho, _hoTen, _gioiTinh, _ngaySinh, _dienThoai, _email, _diaChi);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_idNhanVien, _idKho, _hoTen, _gioiTinh, _ngaySinh, _dienThoai, _email, _diaChi);
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            uctQuanLyNhanVien_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctQuanLyNhanVien_Load(sender, e);
        }

        
    }
}
