using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class SanPham_LoaiSanPham
    {
        string _MaSanPham;
        string _TenLoaiSanPham;
        string _TenSanPham;

        public SanPham_LoaiSanPham(SqlDataReader dr)
        {
            this.MaSanPham = dr["MaSanPham"].ToString();
            this.TenLoaiSanPham = dr["TenLoaiSanPham"].ToString();
            this.TenSanPham = dr["TenSanPham"].ToString();
        }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public string TenLoaiSanPham { get => _TenLoaiSanPham; set => _TenLoaiSanPham = value; }
        public string TenSanPham { get => _TenSanPham; set => _TenSanPham = value; }
    }
}
