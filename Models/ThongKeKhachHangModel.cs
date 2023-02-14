﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Models
{
    internal class ThongKeKhachHangModel
    {
        public int STT { get; set; }
        public string IDKhachHang { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public int TongTien { get; set; }
        public static DataSet FillDataSetDSKhachHang()
        {
            return Models.connection.FillDataSet("spGetDSKhachHang", CommandType.StoredProcedure);
        }
        public static string GetTongChiPhi(string _idKhachHang)
        {
            DataTable dt = Models.connection.FillDataSet("select sum(GiaTien) from HoaDon where id_KhachHang ='" + _idKhachHang + "'", CommandType.Text).Tables[0];
            return dt.Rows[0][0].ToString();
        }
    }
}
