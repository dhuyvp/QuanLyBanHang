using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class HoaDonChiTietModel
    {
        public string IDGiaoDich { get; set; }
        public string IDHangHoa { get; set; }
        public string MaHoaDon { get; set; }
        public HoaDonChiTietModel() { }
        public HoaDonChiTietModel(string iDGiaoDich)
        {
            IDGiaoDich= iDGiaoDich;
        }
        public HoaDonChiTietModel(string iDGiaoDich, string idHangHoa, string maHoaDon)
        {
            IDGiaoDich = iDGiaoDich;
            IDHangHoa = idHangHoa;
            MaHoaDon = maHoaDon;
        }
        // Insert Method
        public int InsertHoaDonChiTiet()
        {
            int i = 0;
            string[] paras = new string[] { "@id_GiaoDich", "@id_HangHoa", "@MaHoaDon"};
            object[] values = new object[] { IDGiaoDich, IDHangHoa, MaHoaDon };
            i = Models.connection.Excute_sql("spInsertHoaDonChiTiet", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Update Method
        public int UpdateHoaDonChiTiet()
        {
            int i = 0;
            string[] paras = new string[] { "@id_GiaoDich", "@id_HangHoa", "@MaHoaDon" };
            object[] values = new object[] { IDGiaoDich, IDHangHoa, MaHoaDon };
            i = Models.connection.Excute_sql("spUpdateHoaDonChiTiet", CommandType.StoredProcedure, paras, values);
            return i;
        }
        // Delete Method
        public int DeleteHoaDonChiTiet()
        {
            int i = 0;
            string[] paras = new string[] { "@id_GiaoDich" };
            object[] values = new object[] { IDGiaoDich };
            i = Models.connection.Excute_sql("spDeleteHoaDonChiTiet", CommandType.StoredProcedure, paras, values);
            return i;
        }
    }
}
