using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class MuaHangModel
    {
        public string IDHangHoa { get; set; }
        public int IDKhoQuanLy { get; set; }
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public int GiaTien { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSD { get; set; }
        public MuaHangModel() { }
        public MuaHangModel(string iDHangHoa)
        {
            IDHangHoa = iDHangHoa;
        }
        public MuaHangModel(string iDHangHoa, int iDKhoQuanLy, string maHangHoa, string tenHangHoa, int giaTien, DateTime ngaySanXuat, DateTime hanSD)
        {
            IDHangHoa = iDHangHoa;
            IDKhoQuanLy = iDKhoQuanLy;
            MaHangHoa = maHangHoa;
            TenHangHoa = tenHangHoa;
            GiaTien = giaTien;
            NgaySanXuat = ngaySanXuat;
            HanSD = hanSD;
        }
        public static DataSet FillDataSetDSHangHoaByIDKho()
        {
            string[] pars = new string[] { "@id_KhoQuanLy" };
            object[] values = new object[] { Models.LoginModel.IDKhoQuanLy };
            return Models.connection.FillDataSet("spGetDSHangHoaByID", CommandType.StoredProcedure, pars, values);
        }
        public static DataSet FillDataSetDSHangHoa()
        {
            return Models.connection.FillDataSet("spGetDSHangHoa", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDSIDKho()
        {
            return Models.connection.FillDataSet("select id_KhoQuanLy from KhoHang where HoatDong=1", CommandType.Text);
        }
    }
}
