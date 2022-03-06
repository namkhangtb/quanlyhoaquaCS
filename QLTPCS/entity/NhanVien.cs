using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTPCS.entity
{
    class NhanVien
    {
        string _MaNhanVien;
        string _TenNhanVien;
        DateTime _NgaySinh;
        string _GioiTinh;
        DateTime _NgayVaoLam;
        string _DiaChi;
        string _Sdt;
        double _LuongCoBan;

        public NhanVien(SqlDataReader dr)
        {
            this.MaNhanVien = dr["MaNhanVien"].ToString();
            this.TenNhanVien = dr["TenNhanVien"].ToString();
            this.NgaySinh = (DateTime)dr["NgaySinh"];
            this.GioiTinh = dr["GioiTinh"].ToString();
            this.NgayVaoLam = (DateTime)dr["NgayVaoLam"];
            this.DiaChi = dr["DiaChi"].ToString();
            this.Sdt = dr["Sdt"].ToString();
            this.LuongCoBan = (double)dr["LuongCoBan"];
        }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public DateTime NgayVaoLam { get => _NgayVaoLam; set => _NgayVaoLam = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public double LuongCoBan { get => _LuongCoBan; set => _LuongCoBan = value; }
    }
}
