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
    public partial class uctMuaHang : UserControl
    {
        public uctMuaHang()
        {
            InitializeComponent();
        }
        public static uctMuaHang _uctMua = new uctMuaHang();
        public List<string> dsIDHangMua = new List<string> ();
        void HienThiDSHangHoa()
        {
            string strQuery = "select id_HangHoa, id_KhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD from HangHoa where is_Ban = 0 and (id_KhoQuanLy = '" + cmbIDKho.Text + "'";
            foreach (string s in dsIDHangMua)
            {
                strQuery += " and id_HangHoa<>'" + s + "'";
            }
            strQuery += ")";

            dgvDanhSachHangDeMua.DataSource = Models.connection.FillDataSet(strQuery, CommandType.Text).Tables[0];
            dgvDanhSachHangDeMua.Dock = DockStyle.Fill;
            dgvDanhSachHangDeMua.RowHeadersVisible = false;
            dgvDanhSachHangDeMua.AllowUserToAddRows = false;

            dgvDanhSachHangDeMua.Columns[0].HeaderText = "ID hàng hóa";
            dgvDanhSachHangDeMua.Columns[1].HeaderText = "Kho quản lý";
            dgvDanhSachHangDeMua.Columns[2].HeaderText = "Mã hàng hóa";
            dgvDanhSachHangDeMua.Columns[3].HeaderText = "Tên hàng hóa";
            dgvDanhSachHangDeMua.Columns[4].HeaderText = "Giá tiền";
            dgvDanhSachHangDeMua.Columns[5].HeaderText = "Ngày sản xuất";
            dgvDanhSachHangDeMua.Columns[6].HeaderText = "Hạn sử dụng";
        }

        public void uctMuaHang_Load(object sender, EventArgs e)
        {
            cmbIDKho.DropDownStyle = ComboBoxStyle.DropDownList;
            HienThiDSHangHoa();
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
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbIDKho.Text == "")
            {
                MessageBox.Show("Vui lòng lựa chọn kho hàng!");
            } else
            {
                Models.LoginModel.IDKhoQuanLy = int.Parse(cmbIDKho.Text);
                HienThiDSHangHoa();
            }
        }

        private void btnOKThem_Click(object sender, EventArgs e)
        {
            int idRow = -1;
            try
            {
                if (dgvDanhSachHangDeMua.CurrentCell != null)
                    idRow = dgvDanhSachHangDeMua.CurrentCell.RowIndex;
            } catch { }
            
            if (idRow > -1) 
            {
                string val = dgvDanhSachHangDeMua.Rows[idRow].Cells[0].Value.ToString();
                if (dsIDHangMua.Contains(val) == false)
                {
                    dsIDHangMua.Add(val);
                    MessageBox.Show("Thêm hàng vào giỏ hàng thành công!");
                } else
                {
                    MessageBox.Show("Bạn đã thêm hàng vào giỏ hàng!");
                }
                HienThiDSHangHoa();
                Views.uctGioHang._uctGioHang.uctGioHang_Load(sender, e);
            } else
            {
                MessageBox.Show("Vui lòng chọn hàng hóa mà bạn muốn mua!");
            }
            
        }

        private void cmbIDKho_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbIDKho.Text != "")
            {
                Models.LoginModel.IDKhoQuanLy = int.Parse(cmbIDKho.Text);
                HienThiDSHangHoa();
            }
        }
    }
}
