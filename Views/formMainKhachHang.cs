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
    public partial class formMainKhachHang : Form
    {
        public static formMainKhachHang _formMainKhachHang ;
        public formMainKhachHang()
        {
            InitializeComponent();
            _formMainKhachHang = this;
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
            tab.Name= uct.Name;
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

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                formLogin _fr = new formLogin();
                _fr.Show();
                _fr.FormClosing += delegate { this.Close(); };
            }
            else
            {
                return;
            }
        }

        private void muaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctMuaHang._uctMua, 4, "Mua hàng");
        }

        private void giỏHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctGioHang._uctGioHang, 4, "Giỏ hàng");
        }

        private void đóngTabHiệnTạiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void đóngTấtCảCácTabToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void đổiThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctXemHoaDon._uctHoaDon, 4, "Hóa đơn");
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThayDoiThongTin._uctThayDoiThongTin, 4, "Thông tin cá nhân");
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctDoiMatKhau._uctDoiMatKhau, 4, "Đổi mật khẩu");
        }
    }
}
