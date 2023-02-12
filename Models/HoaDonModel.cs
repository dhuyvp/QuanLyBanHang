using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyBanHang.Models
{
    internal class HoaDonModel
    {
        public string MaHoaDon { get; set; }
        public string IDKhachHang 
        { 
            get { return Views.formLoginKhachHang.IDKhachHang; } 
        }
        public DateTime ThoiGian { get; set; }
        public int GiaTien { get; set; }
        public string HinhThucThanhToan { get; set; }
        public HoaDonModel() { }
        public HoaDonModel(string maHoaDon)
        {
            MaHoaDon= maHoaDon;
        }
        public HoaDonModel(string maHoaDon, DateTime thoiGian, int giaTien, string hinhThucThanhToan)
        {
            MaHoaDon = maHoaDon;
            ThoiGian = thoiGian;
            GiaTien = giaTien;
            HinhThucThanhToan = hinhThucThanhToan;
        }
        // Insert Method
        public int InsertHoaDon()
        {
            int i = 0;
            string[] paras = new string[] { "@MaHoaDon", "@id_KhachHang", "@ThoiGian", "@GiaTien", "@HinhThucThanhToan" };
            object[] values = new object[] { MaHoaDon, IDKhachHang, ThoiGian, GiaTien, HinhThucThanhToan};
            i = Models.connection.Excute_sql("spInsertHoaDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Update Method
        public int UpdateHoaDon()
        {
            int i = 0;
            string[] paras = new string[] { "@MaHoaDon", "@id_KhachHang", "@ThoiGian", "@GiaTien", "@HinhThucThanhToan" };
            object[] values = new object[] { MaHoaDon, IDKhachHang, ThoiGian, GiaTien, HinhThucThanhToan };
            i = Models.connection.Excute_sql("spUpdateHoaDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Delete Method
        public int DeleteHoaDon()
        {
            int i = 0;
            string[] paras = new string[] { "@MaHoaDon" };
            object[] values = new object[] { MaHoaDon };
            i = Models.connection.Excute_sql("spDeleteHoaDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetDSHoaDonByIDKhachHang()
        {
            return Models.connection.FillDataSet("exec spGetDSHoaDonTheoKhachHang @id_KhachHang= '" + Views.formLoginKhachHang.IDKhachHang +"'", CommandType.Text) ;
        }
    }
}
