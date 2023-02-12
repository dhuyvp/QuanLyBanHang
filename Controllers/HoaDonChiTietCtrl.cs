using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class HoaDonChiTietCtrl
    {
        public static int InsertHoaDonChiTiet(string iDGiaoDich, string idHangHoa, string maHoaDon)
        {
            try
            {
                Models.HoaDonChiTietModel _hoaDon = new Models.HoaDonChiTietModel(iDGiaoDich, idHangHoa, maHoaDon);
                return _hoaDon.InsertHoaDonChiTiet();
            }
            catch { return 0; }
        }
        public static int UpdateHoaDonChiTiet(string iDGiaoDich, string idHangHoa, string maHoaDon)
        {
            try
            {
                Models.HoaDonChiTietModel _hoaDon = new Models.HoaDonChiTietModel(iDGiaoDich, idHangHoa, maHoaDon);
                return _hoaDon.UpdateHoaDonChiTiet();
            }
            catch { return 0; }
        }
        public static int DeleteHoaDonChiTiet(string iDGiaoDich)
        {
            try
            {
                Models.HoaDonChiTietModel _hoaDon = new Models.HoaDonChiTietModel(iDGiaoDich);
                return _hoaDon.DeleteHoaDonChiTiet();
            }
            catch { return 0; }
        }
    }
}
