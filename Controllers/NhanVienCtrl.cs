using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class NhanVienCtrl
    {
        public static int InsertNhanVien(string _IdNhanVien, int _idKho, string _HoTenNV, string _GioiTinhNV, DateTime _NgaySinhNV, string _DienThoaiNV, string _EmailNV, string _DiaChiNV)
        {
            try
            {
                Models.NhanVienModel _nhanvien = new Models.NhanVienModel(_IdNhanVien, _idKho, _HoTenNV, _GioiTinhNV, _NgaySinhNV, _DienThoaiNV, _EmailNV, _DiaChiNV);
                return _nhanvien.InsertNhanVien();
            }
            catch { return 0; }
        }

        public static int UpdateNhanVien(string _IdNhanVien, int _idKho, string _HoTenNV, string _GioiTinhNV, DateTime _NgaySinhNV, string _DienThoaiNV, string _EmailNV, string _DiaChiNV)
        {
            try
            {
                Models.NhanVienModel _nhanvien = new Models.NhanVienModel(_IdNhanVien, _idKho, _HoTenNV, _GioiTinhNV, _NgaySinhNV, _DienThoaiNV, _EmailNV, _DiaChiNV);
                return _nhanvien.UpdateNhanVien();
            }
            catch { return 0; }
        }

        public static int DeleteNhanVien(string _IdNhanVien, int idKho)
        {
            try
            {
                Models.NhanVienModel _nhanvien = new Models.NhanVienModel(_IdNhanVien, idKho);
                return _nhanvien.DeleteNhanVien();
            }
            catch { return 0; }
        }
    }
}
