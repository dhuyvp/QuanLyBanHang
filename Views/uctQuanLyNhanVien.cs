﻿using System;
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
        // flag = 0 -> thêm
        // flag = 1 -> sửa
        // flag = 2 -> tìm kiếm
        int flag = 0;
        public void uctQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvDSNhanVien.ReadOnly = true;
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
            dgvDSNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns[5].HeaderText = "Điện thoại";
            dgvDSNhanVien.Columns[6].HeaderText = "Email";
            dgvDSNhanVien.Columns[7].HeaderText = "Địa chỉ";
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
            btnFind.Enabled = !e;
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
            loadcontrol();
            GetAllKhoHang();
            txtIdNhanVien.Text = Models.connection.ExcuteScalar("select dbo.funGetNextIDNhanVien()");
            cmbIDKho.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            cmbGioiTinh.Text = "";           
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
            int _idKho = -1;
            bool _b = int.TryParse(cmbIDKho.Text, out _idKho);
            if (_b == false || _idKho <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên mà bạn muốn xóa!");
                uctQuanLyNhanVien_Load(sender, e);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_idNhanVien, _idKho);
                if (i > 0)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    uctQuanLyNhanVien_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Views.uctQuanLyKho._uctQLyKho.uctQuanLyKho_Load(sender, e);
            }
            else
            {
                return;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idNhanVien = txtIdNhanVien.Text;
            string _hoTen = txtHoTen.Text;
            int _idKho = 0;
            try
            {
                _idKho = Convert.ToInt32(cmbIDKho.Text);
            }
            catch { }
            DateTime _ngaySinh = dtpNgaySinh.Value.Date;
           // MessageBox.Show(_ngaySinh.ToString());


            string _gioiTinh = cmbGioiTinh.Text;
            string _dienThoai = txtDienThoai.Text;
            string _email = txtEmail.Text;
            string _diaChi = txtDiaChi.Text;
            if (_idNhanVien == "" || _idKho <= 0 || _hoTen == "" || _gioiTinh == "" || _dienThoai == "" || _email == "" || _diaChi == "")
            {
                MessageBox.Show("Vui lòng nhập đúng và đầy đủ thông tin!");
                return;
            }

            if (flag == 1)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.InsertNhanVien(_idNhanVien, _idKho, _hoTen, _gioiTinh, _ngaySinh, _dienThoai, _email, _diaChi);
                if (i > 0)
                {
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên không thành công!");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_idNhanVien, _idKho, _hoTen, _gioiTinh, _ngaySinh, _dienThoai, _email, _diaChi);
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin nhân viên không thành công!");
                }
            }
            uctQuanLyNhanVien_Load(sender, e);
            Views.uctQuanLyKho._uctQLyKho.uctQuanLyKho_Load(sender, e);

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (flag == 0 || flag == 1)
            {
                uctQuanLyNhanVien_Load(sender, e);
            }
            else
            {
                flag = -1;
                Dis_Enable(false);
                //clearData();
                //HienThiDSNhanVien();
                DataBinding();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            flag = 2;
            clearData();
            txtIdNhanVien.Text = "";
            Dis_Enable(true);
            txtIdNhanVien.Enabled = true;
            btnLuu.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        public void HienThiDSSearchNhanVien()
        {
            string _idNhanVien = txtIdNhanVien.Text;
            int _idKho = -1;
            bool _isNum = int.TryParse(cmbIDKho.Text, out _idKho);
            string _hoTen = txtHoTen.Text;
            string _gioiTinh = cmbGioiTinh.Text;
            DateTime _ngaySinh = dtpNgaySinh.Value;
            string _dienThoai = txtDienThoai.Text;
            string _email = txtEmail.Text;
            string _diaChi = txtDiaChi.Text;

            string sqlQuery = "select * from NhanVien where " +
                "id_NhanVien like '%" + _idNhanVien + "%' and " +
                "HoTen like '%" + _hoTen + "%' and " +
                "GioiTinh like '%" + _gioiTinh + "%' and " +
                "DienThoai like '%" + _dienThoai + "%' and " +
                "Email like '%" + _email + "%' and " +
                "DiaChi like '%" + _diaChi + "%' ";
            
            if (_isNum && _idKho > 0) 
            {
                sqlQuery += " and id_KhoQuanLy = " + _idKho.ToString();
            }

            dgvDSNhanVien.DataSource = Models.connection.FillDataSet(sqlQuery, CommandType.Text).Tables[0];
            dgvDSNhanVien.Dock = DockStyle.Fill;
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.AllowUserToAddRows = false;

            dgvDSNhanVien.Columns[0].HeaderText = "ID nhân viên";
            dgvDSNhanVien.Columns[1].HeaderText = "Kho quản lý";
            dgvDSNhanVien.Columns[2].HeaderText = "Họ tên";
            dgvDSNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns[5].HeaderText = "Điện thoại";
            dgvDSNhanVien.Columns[6].HeaderText = "Email";
            dgvDSNhanVien.Columns[7].HeaderText = "Địa chỉ";
        }
        private void txtIdNhanVien_TextChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }
        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }

        private void cmbIDKho_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }

        private void cmbGioiTinh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flag == 2) HienThiDSSearchNhanVien();
        }
    }
}
