using QuanLyBanHang.Models;
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
    public partial class uctGioHang : UserControl
    {
        public uctGioHang()
        {
            InitializeComponent();
        }
        public static uctGioHang _uctGioHang = new uctGioHang();
        public void uctGioHang_Load(object sender, EventArgs e)
        {
            HienThiDSHangHoa();
        }
        void HienThiDSHangHoa()
        {
            string strQuery = "select id_HangHoa, id_KhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD from HangHoa where is_Ban = 0 and (id_HangHoa=''";
            foreach (string s in Views.uctMuaHang._uctMua.dsIDHangMua)
            {
                strQuery += " or id_HangHoa='" + s + "'";
            }
            strQuery += ")";

            dgvGioHang.DataSource = Models.connection.FillDataSet(strQuery, CommandType.Text).Tables[0];
            dgvGioHang.Dock = DockStyle.Fill;
            dgvGioHang.RowHeadersVisible = false;
            dgvGioHang.AllowUserToAddRows = false;

            dgvGioHang.Columns[0].HeaderText = "ID hàng hóa";
            dgvGioHang.Columns[1].HeaderText = "Kho quản lý";
            dgvGioHang.Columns[2].HeaderText = "Mã hàng hóa";
            dgvGioHang.Columns[3].HeaderText = "Tên hàng hóa";
            dgvGioHang.Columns[4].HeaderText = "Giá tiền";
            dgvGioHang.Columns[5].HeaderText = "Ngày sản xuất";
            dgvGioHang.Columns[6].HeaderText = "Hạn sử dụng";
        }
        void UpdateTaiChinhKhoHang(int idKhoHang, int taiChinh)
        {
            string[] pars = new string[] { "@id_KhoQuanLy", "@TaiChinh" };
            object[] values = new object[] { idKhoHang, taiChinh };
            int i = Models.connection.Excute_sql("spUpdateTaiChinhKhoHang", CommandType.StoredProcedure, pars, values);
        }
        void InsertHoaDonChiTiet(string maHoaDon, List<string> list)
        {
            string idHangHoa = "";
            foreach(string str in list)
            {
                if (str != "")
                {
                    string idGiaoDich = Models.connection.ExcuteScalar("select dbo.funGetNextIDHoaDonChiTiet()");
                    idHangHoa = str;
                    int i = Controllers.HoaDonChiTietCtrl.InsertHoaDonChiTiet(idGiaoDich, idHangHoa, maHoaDon);
                    int j = Controllers.HangHoaCtrl.UpdateDaBanHangHoa(idHangHoa);

                    DataTable dt = Models.connection.FillDataSet("select id_KhoQuanLy, GiaTien from HangHoa where id_HangHoa ='" + idHangHoa + "'", CommandType.Text).Tables[0];
                    int idKhoHang = int.Parse(dt.Rows[0][0].ToString() );
                    int giaTien = int.Parse(dt.Rows[0][1].ToString());
                    UpdateTaiChinhKhoHang(idKhoHang, giaTien);

                    int _ = Models.connection.Excute_sql("update KhoHang set soHangHoa = (select count(*) from HangHoa where id_KhoQuanLy ='" + idKhoHang.ToString() + "' and is_Ban = 0) where id_KhoQuanLy = '" + idKhoHang.ToString() + "'");
                }
            }
            
        }
        
        void InsertHoaDon()
        {
            List<string> list = Views.uctMuaHang._uctMua.dsIDHangMua;

            string idHoaDon = Models.connection.ExcuteScalar("select dbo.funGetNextIDHoaDon()");
            DateTime thoiGian = DateTime.Now;
            int giaTien = 0;
            string hinhThucThanhToan = "Ví điện tử";

            string strQuery = "select sum(GiaTien) from HangHoa where id_HangHoa = ''";
            foreach (string str in list)
            {
                strQuery += " or id_HangHoa = '" + str + "'";
            }
            DataTable dt = Models.connection.FillDataSet(strQuery, CommandType.Text).Tables[0];
            giaTien = int.Parse(dt.Rows[0][0].ToString());

            int i = Controllers.HoaDonCtrl.InsertHoaDon(idHoaDon, thoiGian, giaTien, hinhThucThanhToan);
            if (i > 0)
            {
                MessageBox.Show("Đặt hàng thành công!");
                InsertHoaDonChiTiet(idHoaDon, list);

                Views.uctMuaHang._uctMua.dsIDHangMua.Clear();
            } else
            {
                MessageBox.Show("Đặt hàng thất bại!");
            }
        }
        private void btnOKMua_Click(object sender, EventArgs e)
        {
            if (Views.uctMuaHang._uctMua.dsIDHangMua.Count <= 0)
            {
                MessageBox.Show("Vui lòng chọn hàng muốn mua!");
                return;
            }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn mua hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                InsertHoaDon();
                uctGioHang_Load(sender, e);
                Views.uctThongKeKhachHang._uctThongKe.uctThongKeKhachHang_Load(sender, e);
                Views.uctXemHoaDon._uctHoaDon.uctXemHoaDon_Load(sender, e);
                Views.uctQuanLyKho._uctQLyKho.uctQuanLyKho_Load(sender, e);
            } else
            {
                return;
            }
        }

        private void btnOKXoa_Click(object sender, EventArgs e)
        {
            int idRow = -1;
            try
            {
                if (dgvGioHang.CurrentCell != null)
                    idRow = dgvGioHang.CurrentCell.RowIndex;
            }
            catch { }
            if (idRow > -1) 
            {
                string val = dgvGioHang.Rows[idRow].Cells[0].Value.ToString();
                if (Views.uctMuaHang._uctMua.dsIDHangMua.Contains(val) == false)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
                else
                {
                    Views.uctMuaHang._uctMua.dsIDHangMua.Remove(val);
                    MessageBox.Show("Xóa khỏi giỏ hàng thành công!");
                    HienThiDSHangHoa();
                    Views.uctMuaHang._uctMua.uctMuaHang_Load(sender, e);
                }
            } else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa mà bạn muốn xóa khỏi giỏ hàng!");
            }
            Views.uctQuanLyKho._uctQLyKho.uctQuanLyKho_Load(sender, e);
        }
    }
}
