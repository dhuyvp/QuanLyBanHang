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
            
        }

        public void uctThongKeKhachHang_Load(object sender, EventArgs e)
        {
            HienThiDSKhachHang();
        }
    }
}
