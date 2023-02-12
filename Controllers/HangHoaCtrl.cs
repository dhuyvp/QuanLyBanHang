using QuanLyBanHang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class HangHoaCtrl
    {
        public static int InsertHangHoa(string iDHangHoa, int iDKhoQuanLy, string maHangHoa, string tenHangHoa, int giaTien, DateTime ngaySanXuat, DateTime hanSD, int isBan)
        {
            Models.HangHoaModel _hangHoaModel = new Models.HangHoaModel(iDHangHoa, iDKhoQuanLy, maHangHoa, tenHangHoa, giaTien, ngaySanXuat, hanSD, isBan);
            return _hangHoaModel.InsertHangHoa();
        }
        public static int UpdateHangHoaByID(string iDHangHoa, int iDKhoQuanLy, string maHangHoa, string tenHangHoa, int giaTien, DateTime ngaySanXuat, DateTime hanSD, int isBan)
        {
            Models.HangHoaModel _hangHoaModel = new Models.HangHoaModel(iDHangHoa, iDKhoQuanLy, maHangHoa, tenHangHoa, giaTien, ngaySanXuat, hanSD, isBan);
            return _hangHoaModel.UpdateHangHoaByID();
        }
        public static int DeleteHangHoaByID(string idHangHoa)
        {
            Models.HangHoaModel _hangHoaModel = new Models.HangHoaModel(idHangHoa);
            return _hangHoaModel.DeleteHangHoaByID();
        }
        public static int UpdateDaBanHangHoa(string idHangHoa)
        {
            Models.HangHoaModel _hangHoaModel = new Models.HangHoaModel(idHangHoa);
            return _hangHoaModel.UpdateDaBanHangHoa();
        }
    }
}
