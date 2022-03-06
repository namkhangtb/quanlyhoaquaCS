using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class ChiTietPhieuNhap
    {
        string _MaCTPN;
        string _MaPhieuNhap;
        string _MaSanPham;
        int _SoLuong;
        int _DonGia;
        public ChiTietPhieuNhap(SqlDataReader dr)
        {
            this.MaCTPN = dr["MaCTPN"].ToString();
            this.MaPhieuNhap = dr["MaPhieuNhap"].ToString();
            this.MaSanPham = dr["MaSanPham"].ToString(); 
            this.SoLuong = (int)dr["SoLuong"];
            this.DonGia = (int)dr["DonGia"];
        }
        public string MaCTPN { get => _MaCTPN; set => _MaCTPN = value; }
        public string MaPhieuNhap { get => _MaPhieuNhap; set => _MaPhieuNhap = value; }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public int SoLuong { get => _SoLuong; set => _SoLuong = value; }
        public int DonGia { get => _DonGia; set => _DonGia = value; }
    }
}
