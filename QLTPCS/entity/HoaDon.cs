using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class HoaDon
    {
        string _MaHoaDon;
        string _MaNhanVien;
        string _MaKhachHang;
        string _TongTien;
        DateTime _NgayLapHoaDon;

        public HoaDon(SqlDataReader dr)
        {
            this.MaHoaDon = dr["MaHoaDon"].ToString();
            this.MaNhanVien = dr["MaNhanVien"].ToString();
            this.MaKhachHang = dr["MaKhachHang"].ToString();
            this.TongTien = dr["TongTien"].ToString();
            this.NgayLapHoaDon = (DateTime)dr["NgayLapHoaDon"];
        }

        public string MaHoaDon { get => _MaHoaDon; set => _MaHoaDon = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public DateTime NgayLapHoaDon { get => _NgayLapHoaDon; set => _NgayLapHoaDon = value; }
        public string TongTien { get => _TongTien; set => _TongTien = value; }
    }
}
