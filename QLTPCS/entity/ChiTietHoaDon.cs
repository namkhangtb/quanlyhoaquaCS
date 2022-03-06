using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class ChiTietHoaDon
    {
        string _MaSanPham;
        int _SoLuong;
        String _MaChiTietHoaDon;
        public ChiTietHoaDon(SqlDataReader dr)
        {
            this.MaChiTietHoaDon = dr["MaChiTietHoaDon"].ToString();
            this.MaSanPham = dr["MaSanPham"].ToString();
            this.SoLuong = (int)dr["SoLuong"];
        }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public string MaChiTietHoaDon { get => _MaChiTietHoaDon; set => _MaChiTietHoaDon = value; }
    }
}
