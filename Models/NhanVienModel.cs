using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class NhanVienModel
    {
        public string IDNhanVien { get; set; }
        public int IDKhoQuanLy { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public NhanVienModel() { }  
        public NhanVienModel(string _idNhanVien, int _idKhoQuanLy, string _hoTen, string _gioiTinh, DateTime _ngaySinh, string _dienThoai, string _email, string _diaChi)
        {
            IDNhanVien = _idNhanVien;
            IDKhoQuanLy = _idKhoQuanLy;
            HoTen = _hoTen;
            GioiTinh = _gioiTinh;
            NgaySinh = _ngaySinh;
            DienThoai = _dienThoai;
            Email = _email;
            DiaChi = _diaChi;
        }
        public NhanVienModel(string _s)
        {
            this.IDNhanVien = _s;
            this.HoTen = _s;
            this.GioiTinh = _s;
            this.DienThoai = _s;
            this.Email = _s;
            this.DiaChi = _s;
        }
        public NhanVienModel(int _idKho)
        {
            this.IDKhoQuanLy = _idKho;
        }
        public NhanVienModel(string _idNhanVien, int _idKhoQuanLy)
        {
            IDNhanVien = _idNhanVien;
            IDKhoQuanLy = _idKhoQuanLy;
        }
        public static DataSet FillDataSetDSNhanVien()
        {
            return Models.connection.FillDataSet("spGetDSNhanVien", CommandType.StoredProcedure);
        }
        // Insert Method
        public int InsertNhanVien()
        {
            int i = 0;
            string[] paras = new string[] { "@id_NhanVien", "@HoTen", "@id_KhoQuanLy", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[] { IDNhanVien, HoTen, IDKhoQuanLy, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };
            i = Models.connection.Excute_sql("spInsertNhanVien", CommandType.StoredProcedure, paras, values);

            int j = InsertTaiKhoan();
            return i;
        }
        // Update Method
        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[] { "@id_NhanVien", "@HoTen", "@id_KhoQuanLy", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[] { IDNhanVien, HoTen, IDKhoQuanLy, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };
            i = Models.connection.Excute_sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);

            int j = UpdateTaiKhoan();
            return i;
        }
        // Delete Method
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[] { "@id_NhanVien", "@id_KhoQuanLy" };
            object[] values = new object[] { IDNhanVien, IDKhoQuanLy };
            i = Models.connection.Excute_sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);

            int j = DeleteTaiKhoan();
            return i;
        }

        public int InsertTaiKhoan()
        {
            int i = 0;
            string[] pars = new string[] { "@tk_Username", "@tk_Password", "@is_Admin", "@is_NhanVien", "@is_KhachHang", "@id_KhoQuanLy" };
            object[] values = new object[] { IDNhanVien, "pass"+IDNhanVien, 0, 1, 0, IDKhoQuanLy};
            i = Models.connection.Excute_sql("spInsertTaiKhoan", CommandType.StoredProcedure, pars, values);
            return i;
        }
        public int UpdateTaiKhoan()
        {
            int i = 0;
            string[] pars = new string[] { "@tk_Username", "@tk_Password", "@is_Admin", "@is_NhanVien", "@is_KhachHang", "@id_KhoQuanLy" };
            object[] values = new object[] { IDNhanVien, "pass" + IDNhanVien, 0, 1, 0, IDKhoQuanLy };
            i = Models.connection.Excute_sql("spUpdateTaiKhoan", CommandType.StoredProcedure, pars, values);
            return i;
        }
        public int DeleteTaiKhoan()
        {
            int i = 0;
            string[] pars = new string[] { "@tk_Username" };
            object[] values = new object[] { IDNhanVien };
            i = Models.connection.Excute_sql("spDeleteTaiKhoan", CommandType.StoredProcedure, pars, values);
            return i;
        }


        public DataSet FillDataSet_SearchNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[] { "@id_NhanVien", "@HoTen", "@id_KhoQuanLy", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[] { IDNhanVien, HoTen, IDKhoQuanLy, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };

            ds = Models.connection.FillDataSet("spSearchNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
