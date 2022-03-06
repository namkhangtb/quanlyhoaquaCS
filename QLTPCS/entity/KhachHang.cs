using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTPCS.entity
{
    class KhachHang
    {
        string _MaKhachHang;
        string _TenKhachHang;
        DateTime _NgaySinh;
        string _GioiTinh;
        string _DiaChi;
        string _Sdt;
        public KhachHang(SqlDataReader dr)
        {
            this.MaKhachHang = dr["MaKhachHang"].ToString();
            this.TenKhachHang = dr["TenKhachHang"].ToString();
            this.NgaySinh = (DateTime)dr["NgaySinh"];
            this.GioiTinh = dr["GioiTinh"].ToString();
            this.DiaChi = dr["DiaChi"].ToString();
            this.Sdt = dr["Sdt"].ToString();
        }
        public string MaKhachHang { get => _MaKhachHang; set => _MaKhachHang = value; }
        public string TenKhachHang { get => _TenKhachHang; set => _TenKhachHang = value; }
        public DateTime NgaySinh { get => _NgaySinh; set => _NgaySinh = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
    }
}
