using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class KhachHangModel
    {
        public string IDKhachHang { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set;}
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }

        public KhachHangModel() { }
        public KhachHangModel(string _idKhachHang)
        {
            IDKhachHang= _idKhachHang;
        }
        public KhachHangModel(string iDKhachHang, string matKhau, string hoTen, string gioiTinh, DateTime ngaySinh, string dienThoai, string email, string diaChi)
        {
            IDKhachHang = iDKhachHang;
            MatKhau= matKhau;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            DienThoai = dienThoai;
            Email = email;
            DiaChi = diaChi;
        }
        // Insert Method
        public int InsertKhachHang()
        {
            int i = 0;
            string[] paras = new string[] { "@id_KhachHang", "@MatKhau", "@HoTen", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[] { IDKhachHang, MatKhau, HoTen, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };
            i = Models.connection.Excute_sql("spInsertKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Update Method
        public int UpdateKhachHang()
        {
            int i = 0;
            string[] paras = new string[] { "@id_KhachHang", "@MatKhau", "@HoTen", "@NgaySinh", "@GioiTinh", "@DienThoai", "@Email", "@DiaChi" };
            object[] values = new object[] { IDKhachHang, MatKhau, HoTen, NgaySinh, GioiTinh, DienThoai, Email, DiaChi };
            i = Models.connection.Excute_sql("spUpdateKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Delete Method
        public int DeleteKhachHang()
        {
            int i = 0;
            string[] paras = new string[] { "@id_KhachHang" };
            object[] values = new object[] { IDKhachHang };
            i = Models.connection.Excute_sql("spDeleteKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateTaiKhoan(string matKhau)
        {
            int i = 0;
            string[] pars = new string[] { "@tk_Username", "@tk_Password", "@is_Admin", "@is_NhanVien", "@is_KhachHang", "@id_KhoQuanLy" };
            object[] values = new object[] { Views.formLogin.IDKhachHang, matKhau, 0, 0, 1, 0 };
            i = Models.connection.Excute_sql("spUpdateTaiKhoan", CommandType.StoredProcedure, pars, values);
            return i;
        }

    }
}
