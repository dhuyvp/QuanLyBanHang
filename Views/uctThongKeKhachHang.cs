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
    public partial class uctThongKeKhachHang : UserControl
    {
        public static uctThongKeKhachHang _uctThongKe = new uctThongKeKhachHang();
        public uctThongKeKhachHang()
        {
            InitializeComponent();
            _uctThongKe = this;
        }

        
        void HienThiDSKhachHang()
        {
            dgvThongKeKhachHang.DataSource = Models.ThongKeKhachHangModel.FillDataSetDSKhachHang().Tables[0];
            dgvThongKeKhachHang.Dock = DockStyle.Fill;
            dgvThongKeKhachHang.RowHeadersVisible = false;
            dgvThongKeKhachHang.AllowUserToAddRows = false;

            dgvThongKeKhachHang.Columns[0].HeaderText = "ID Khách hàng";
            dgvThongKeKhachHang.Columns[1].HeaderText = "Họ tên";
            dgvThongKeKhachHang.Columns[2].HeaderText = "Giới tính";
            dgvThongKeKhachHang.Columns[3].HeaderText = "Ngày sinh";
            dgvThongKeKhachHang.Columns[4].HeaderText = "Điện thoại";
            dgvThongKeKhachHang.Columns[5].HeaderText = "Email";
            dgvThongKeKhachHang.Columns[6].HeaderText = "Địa chỉ";
            dgvThongKeKhachHang.Columns[7].HeaderText = "Tổng chi tiêu";
        }

        public void uctThongKeKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }

        private void dgvThongKeKhachHang_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            for (int i = 0; i < dgvThongKeKhachHang.Rows.Count; i++)
            {
                if (i >= 3) break;
                if (i == 0)
                {
                    dgvThongKeKhachHang.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                else if (i == 1)
                {
                    dgvThongKeKhachHang.Rows[i].DefaultCellStyle.BackColor = Color.Silver;
                }
                else
                {
                    dgvThongKeKhachHang.Rows[i].DefaultCellStyle.BackColor = Color.SandyBrown;
                }
            }
        }
    }
}
