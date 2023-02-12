using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang.Models
{
    internal class LoginModel
    {
        public static int IDKhoQuanLy { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public int IsAdmin { get; set; }
        public int IsNhanVien { get; set; }
        public int IsKhachHang { get; set; }
        
        public LoginModel() { }
        public static bool KiemTraDangNhapAdmin(string taiKhoan, string matKhau)
        {
            string ketQua;
            ketQua = Models.connection.ExcuteScalar("select dbo.checkAdmin('" + taiKhoan + "', '"+ matKhau + "')");

            if (ketQua == "false") 
                return false;
            return true;
        }
        public static int KiemTraDangNhapNhanVien(string taiKhoan, string matKhau)
        {
            int ketQua;
            string[] pars = new string[2] { "@tk_Username", "@tk_Password" };
            object[] values = new object[2] { taiKhoan, matKhau };
            ketQua = Convert.ToInt32(Models.connection.ExcuteScalar("select dbo.checkNhanVien(@tk_Username, @tk_Password)", CommandType.StoredProcedure, pars, values));

            return ketQua;
        }
        public static bool KiemTraDangNhapKhachHang(string taiKhoan, string matKhau)
        {
            string ketQua;
            string[] pars = new string[2] { "@tk_Username", "@tk_Password" };
            object[] values = new object[2] { taiKhoan, matKhau };
            ketQua = Models.connection.ExcuteScalar("select dbo.checkKhachHang(@tk_Username, @tk_Password)", CommandType.StoredProcedure, pars, values);

            if (ketQua == "false")
                return false;
            return true;
        }
    }
}
