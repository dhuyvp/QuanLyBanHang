using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class HoaDonCtrl
    {
        public static int InsertHoaDon(string maHoaDon, DateTime thoiGian, int giaTien, string hinhThucThanhToan)
        {
            try
            {
                Models.HoaDonModel _hoaDon = new Models.HoaDonModel(maHoaDon, thoiGian, giaTien, hinhThucThanhToan);
                return _hoaDon.InsertHoaDon();
            }
            catch { return 0; }
        }
        public static int UpdateHoaDon(string maHoaDon, DateTime thoiGian, int giaTien, string hinhThucThanhToan)
        {
            try
            {
                Models.HoaDonModel _hoaDon = new Models.HoaDonModel(maHoaDon, thoiGian, giaTien, hinhThucThanhToan);
                return _hoaDon.UpdateHoaDon();
            }
            catch { return 0; }
        }
        public static int DeleteHoaDon(string maHoaDon)
        {
            try
            {
                Models.HoaDonModel _hoaDon = new Models.HoaDonModel(maHoaDon);
                return _hoaDon.DeleteHoaDon();
            }
            catch { return 0; }
        }
    }
}
