using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class KhoHangModel
    {
        public int IDKhoQuanLy { get; set; }
        public string DiaChi { get; set; }
        public int TaiChinh { get; set; }
        public int SoNhanVien { get; set; }
        public int SoHangHoa { get; set; }
        public KhoHangModel() { }
        public KhoHangModel(int iDKhoQuanLy)
        {
            IDKhoQuanLy = iDKhoQuanLy;
        }
        public KhoHangModel(int iDKhoQuanLy, string diaChi, int taiChinh, int soNhanVien, int soHangHoa)
        {
            IDKhoQuanLy = iDKhoQuanLy;
            DiaChi = diaChi;
            TaiChinh = taiChinh;
            SoNhanVien = soNhanVien;
            SoHangHoa = soHangHoa;
        }
        /*
        public static DataSet FillDataSetKhoByIDKho()
        {
            return Models.connection.FillDataSet("exec spGetKhoByIDKho @id_KhoQuanLy='" +  "'", CommandType.Text);
        }
        */
        public static DataSet FillDataSetDSKho()
        {
            return Models.connection.FillDataSet("spGetDSKho", CommandType.StoredProcedure);
        }
        public int InsertKhoHang()
        {
            int ret = 0;
            string[] pars = new string[] { "@id_KhoQuanLy", "@DiaChi", "@TaiChinh", "@soNhanVien", "@soHangHoa" };
            object[] values = new object[] { IDKhoQuanLy, DiaChi, TaiChinh, SoNhanVien, SoHangHoa };
            ret = Models.connection.Excute_sql("spInsertKhoHang", CommandType.StoredProcedure, pars, values);

            return ret;
        }
        public int UpdateKhoHang()
        {
            int ret = 0;
            string[] pars = new string[] { "@id_KhoQuanLy", "@DiaChi", "@TaiChinh", "@soNhanVien", "@soHangHoa" };
            object[] values = new object[] { IDKhoQuanLy, DiaChi, TaiChinh, SoNhanVien, SoHangHoa };
            ret = Models.connection.Excute_sql("spUpdateKhoHang", CommandType.StoredProcedure, pars, values);

            return ret;
        }
        public int DeleteKhoHang()
        {
            int ret = 0;
            string[] pars = new string[] { "@id_KhoQuanLy"};
            object[] values = new object[] { IDKhoQuanLy};
            ret = Models.connection.Excute_sql("spDeleteKhoHangByID", CommandType.StoredProcedure, pars, values);

            return ret;
        }
        
    }
}
