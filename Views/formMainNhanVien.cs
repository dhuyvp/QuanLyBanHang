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
    public partial class formMainNhanVien : Form
    {
        public static formMainNhanVien _frMainNV;
        public formMainNhanVien()
        {
            InitializeComponent();
            _frMainNV = this;
        }

        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Text = tenTab;
            tab.Size = TabHienThi.Size;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        // Đóng tab hiện tại
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        // Đóng all tab
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctQuanLyHangHoa._uctQLyHangHoa, 4, "Quản lý kho hàng");
            Views.uctQuanLyHangHoa._uctQLyHangHoa.uctQuanHangHoa_Load(sender, e);
        }

        private void đóngTabHiệnTạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảCácTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                formStart _fr = new formStart();
                _fr.Show();
                _fr.FormClosing += delegate { this.Close(); };
            }
            else
            {
                return;
            }
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThongKeKhachHang._uctThongKe, 4, "Thống kê khách hàng");
        }
    }
}
