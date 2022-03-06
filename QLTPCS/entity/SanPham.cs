using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTPCS.entity
{
    class SanPham
    {
        string _MaSanPham;
        string _TenSanPham;
        string _MaLoaiSanPham;
        string _NoiSanXuat;
        string _GiaNhap;
        string _GiaBan;
        int _TonKho;
        public SanPham(SqlDataReader dr)
        {
            this.MaSanPham = dr["MaSanPham"].ToString();
            this.TenSanPham = dr["TenSanPham"].ToString();
            this.MaLoaiSanPham = dr["MaLoaiSanPham"].ToString(); ;
            this.NoiSanXuat = dr["NoiSanXuat"].ToString();
            this.GiaNhap = dr["GiaNhap"].ToString();
            this.GiaBan = dr["GiaBan"].ToString();
            this.TonKho = (int)dr["TonKho"];
        }
        public string MaSanPham { get => _MaSanPham; set => _MaSanPham = value; }
        public string TenSanPham { get => _TenSanPham; set => _TenSanPham = value; }
        public string MaLoaiSanPham { get => _MaLoaiSanPham; set => _MaLoaiSanPham = value; }
        public string NoiSanXuat { get => _NoiSanXuat; set => _NoiSanXuat = value; }
        public string GiaNhap { get => _GiaNhap; set => _GiaNhap = value; }
        public string GiaBan { get => _GiaBan; set => _GiaBan = value; }
        public int TonKho { get => _TonKho; set => _TonKho = value; }
    }
}
