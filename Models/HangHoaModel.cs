using QuanLyBanHang.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class HangHoaModel
    {
        public string IDHangHoa { get; set; }
        public int IDKhoQuanLy { get; set; }
        public string MaHangHoa { get; set; }
        public string TenHangHoa { get; set; }
        public int GiaTien { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public DateTime HanSD { get; set; }
        public int ISBan { get; set; }
        public HangHoaModel() { }
        public HangHoaModel(string iDHangHoa) 
        {
            IDHangHoa = iDHangHoa;        
        }
        public HangHoaModel(string iDHangHoa, int iDKhoQuanLy, string maHangHoa, string tenHangHoa, int giaTien, DateTime ngaySanXuat, DateTime hanSD, int iSBan)
        {
            IDHangHoa = iDHangHoa;
            IDKhoQuanLy = iDKhoQuanLy;
            MaHangHoa = maHangHoa;
            TenHangHoa = tenHangHoa;
            GiaTien = giaTien;
            NgaySanXuat = ngaySanXuat;
            HanSD = hanSD;
            ISBan = iSBan;
        }
        public static DataSet FillDataSetDSHangHoaByIDKho()
        {
            return Models.connection.FillDataSet("exec spGetDSHangHoaByID @id_KhoQuanLy='" + Models.LoginModel.IDKhoQuanLy + "'", CommandType.Text);    
        }
        public static DataSet FillDataSetDSHangHoa()
        {
            return Models.connection.FillDataSet("spGetDSHangHoa", CommandType.StoredProcedure);
        }
        public int InsertHangHoa()
        {
            int ketQua = 0;
            string[] pars = new string[] { "@id_HangHoa", "@id_KhoQuanLy", "@MaHangHoa", "@TenHangHoa", "@GiaTien", "@NgaySanXuat", "@HanSD" , "@is_Ban"};
            object[] values = new object[] { IDHangHoa, IDKhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD, ISBan};
            ketQua = Models.connection.Excute_sql("spInsertHangHoa", CommandType.StoredProcedure, pars, values);

            return ketQua;
        }
        public int UpdateHangHoaByID()
        {
            int ketQua = 0;
            string[] pars = new string[] { "@id_HangHoa", "@id_KhoQuanLy", "@MaHangHoa", "@TenHangHoa", "@GiaTien", "@NgaySanXuat", "@HanSD", "@is_Ban" };
            object[] values = new object[] { IDHangHoa, IDKhoQuanLy, MaHangHoa, TenHangHoa, GiaTien, NgaySanXuat, HanSD, ISBan };
            ketQua = Models.connection.Excute_sql("spUpdateHangHoa", CommandType.StoredProcedure, pars, values);

            return ketQua;
        }
        public int DeleteHangHoaByID() 
        {
            int ketQua = 0;
            string[] pars = new string[] { "@id_HangHoa" };
            object[] values = new object[] { IDHangHoa };

            ketQua = Models.connection.Excute_sql("spDeleteHangHoa", CommandType.StoredProcedure, pars, values);
            return ketQua;
        }
        public int UpdateDaBanHangHoa()
        {
            int ketQua = 0;
            string[] pars = new string[] { "@id_HangHoa" };
            object[] values = new object[] { IDHangHoa };

            ketQua = Models.connection.Excute_sql("spUpdateBanHang", CommandType.StoredProcedure, pars, values);
            return ketQua;
        }
    }
}
