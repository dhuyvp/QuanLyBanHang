using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Controllers
{
    internal class KhoHangCtrl
    {
        public static int InsertKhoHang(int iDKhoQuanLy, string diaChi, int taiChinh, int soNhanVien, int soHangHoa)
        {
            Models.KhoHangModel _khoHangModel = new Models.KhoHangModel(iDKhoQuanLy, diaChi, taiChinh, soNhanVien, soHangHoa);
            return _khoHangModel.InsertKhoHang();
        }
        public static int UpdateKhoHang(int iDKhoQuanLy, string diaChi, int taiChinh, int soNhanVien, int soHangHoa)
        {
            Models.KhoHangModel _khoHangModel = new Models.KhoHangModel(iDKhoQuanLy, diaChi, taiChinh, soNhanVien, soHangHoa);
            return _khoHangModel.UpdateKhoHang();
        }
        public static int DeleteKhoHang(int iDKhoQuanLy)
        {
            Models.KhoHangModel _khoHangModel = new Models.KhoHangModel(iDKhoQuanLy);
            return _khoHangModel.DeleteKhoHang();
        }
    }
}
