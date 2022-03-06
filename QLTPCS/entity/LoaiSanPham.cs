using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class LoaiSanPham
    {
        string _MaLoaiSanPham;
        string _TenLoaiSanPham;
        public LoaiSanPham(SqlDataReader dr)
        {
            this.MaLoaiSanPham = dr["MaLoaiSanPham"].ToString();
            this.TenLoaiSanPham = dr["TenLoaiSanPham"].ToString();
        }
        public string MaLoaiSanPham { get => _MaLoaiSanPham; set => _MaLoaiSanPham = value; }
        public string TenLoaiSanPham { get => _TenLoaiSanPham; set => _TenLoaiSanPham = value; }
    }
}
