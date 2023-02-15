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
    public partial class uctSearchInforNV : UserControl
    {
        public static uctSearchInforNV _uctSearchInfor = new uctSearchInforNV();
        public uctSearchInforNV()
        {
            InitializeComponent();
            _uctSearchInfor = this;
        }

        private void uctSearchInforNV_Load(object sender, EventArgs e)
        {
            loadcontrol();
        }

        void loadcontrol()
        {
            cmbFind.Items.Clear();
            cmbFind.Items.Add("Id Nhân viên");
            cmbFind.Items.Add("Id Kho");
            cmbFind.Items.Add("Họ và tên nhân viên");
        }
        private void btnFind_Click(object sender, EventArgs e)
        {
            if (cmbFind.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cmbFind.Text == "Id Nhân viên")
            {
                string _idNhanVien = txBFind.Text;
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByIdNhanVien(_idNhanVien).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dgvDSNhanVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Id " + txBFind + " không có trong danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cmbFind.Text == "Id Kho")
            {
                int _idKho = int.Parse(txBFind.Text);
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByIdKho(_idKho).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dgvDSNhanVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Id " + txBFind + " không có trong danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                string _hoTen = txBFind.Text;
                DataTable dt = new DataTable();
                dt = Controllers.NhanVienCtrl.FillDataSet_SearchNhanVienByHoTenNhanVien(_hoTen).Tables[0];
                if (dt.Rows.Count > 0)
                {
                    dgvDSNhanVien.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Họ và tên " + txBFind + " không có trong danh mục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dgvDSNhanVien.Dock = DockStyle.Fill;
            dgvDSNhanVien.RowHeadersVisible = false;
            dgvDSNhanVien.AllowUserToAddRows = false;
            dgvDSNhanVien.ColumnHeadersVisible = true;
            dgvDSNhanVien.Columns[0].HeaderText = "ID nhân viên";
            dgvDSNhanVien.Columns[0].Width = 120;
            dgvDSNhanVien.Columns[1].HeaderText = "Kho quản lý";
            dgvDSNhanVien.Columns[1].Width = 120;
            dgvDSNhanVien.Columns[2].HeaderText = "Họ tên";
            dgvDSNhanVien.Columns[2].Width = 200;
            dgvDSNhanVien.Columns[3].HeaderText = "Giới tính";
            dgvDSNhanVien.Columns[4].HeaderText = "Ngày sinh";
            dgvDSNhanVien.Columns[4].Width = 150;
            dgvDSNhanVien.Columns[5].HeaderText = "Điện thoại";
            dgvDSNhanVien.Columns[6].HeaderText = "Email";
            dgvDSNhanVien.Columns[7].HeaderText = "Địa chỉ";
            dgvDSNhanVien.Columns[7].Width = 200;
        }

       
    }
}
