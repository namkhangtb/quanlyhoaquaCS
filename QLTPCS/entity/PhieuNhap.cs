using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class PhieuNhap
    {
        string _MaPhieuNhap;
        string _MaNhanVien;
        string _MaNhaPhanPhoi;
        string _TongTien;
        DateTime _NgayNhap;
        public PhieuNhap(SqlDataReader dr)
        {
            this.MaPhieuNhap = dr["MaPhieuNhap"].ToString();
            this.MaNhanVien = dr["MaNhanVien"].ToString();
            this.MaNhaPhanPhoi = dr["MaNhaPhanPhoi"].ToString(); ;
            this.TongTien = dr["TongTien"].ToString();
            this.NgayNhap = (DateTime)dr["NgayNhap"];
        }
        public string MaPhieuNhap { get => _MaPhieuNhap; set => _MaPhieuNhap = value; }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string MaNhaPhanPhoi { get => _MaNhaPhanPhoi; set => _MaNhaPhanPhoi = value; }
        public string TongTien { get => _TongTien; set => _TongTien = value; }
        public DateTime NgayNhap { get => _NgayNhap; set => _NgayNhap = value; }
    }
}
