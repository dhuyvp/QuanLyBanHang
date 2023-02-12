using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class KhachHangCtrl
    {
        public static int InsertKhachHang(string iDKhachHang, string matKhau, string hoTen, string gioiTinh, DateTime ngaySinh, string dienThoai, string email, string diaChi)
        {
            try
            {
                Models.KhachHangModel _khachHang = new Models.KhachHangModel(iDKhachHang, matKhau, hoTen, gioiTinh, ngaySinh, dienThoai, email, diaChi);
                return _khachHang.InsertKhachHang();
            }
            catch { return 0; }
        }
        public static int UpdateKhachHang(string iDKhachHang, string matKhau, string hoTen, string gioiTinh, DateTime ngaySinh, string dienThoai, string email, string diaChi)
        {
            try
            {
                Models.KhachHangModel _khachHang = new Models.KhachHangModel(iDKhachHang, matKhau, hoTen, gioiTinh, ngaySinh, dienThoai, email, diaChi);
                return _khachHang.UpdateKhachHang();
            }
            catch { return 0; }
        }
        public static int DeleteKhachHang(string iDKhachHang)
        {
            try
            {
                Models.KhachHangModel _khachHang = new Models.KhachHangModel(iDKhachHang);
                return _khachHang.DeleteKhachHang();
            }
            catch { return 0; }
        }
        public static int UpdateTaiKhoan(string matKhau)
        {
            try
            {
                Models.KhachHangModel _khachHang = new Models.KhachHangModel();
                return _khachHang.UpdateTaiKhoan(matKhau);
            }
            catch { return 0; }
        }
    }
}
