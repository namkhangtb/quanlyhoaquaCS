using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace QLTPCS.entity
{
    class DiemDanh
    {
        string _MaNhanVien;
        string _TenNhanVien;
        DateTime _NgayDiLam;

        public DiemDanh(SqlDataReader dr)
        {
            this.MaNhanVien = dr["MaNhanVien"].ToString();
            this.TenNhanVien = dr["TenNhanVien"].ToString();
            this.NgayDiLam = (DateTime)dr["NgayDiLam"];
        }
        public string MaNhanVien { get => _MaNhanVien; set => _MaNhanVien = value; }
        public string TenNhanVien { get => _TenNhanVien; set => _TenNhanVien = value; }
        public DateTime NgayDiLam { get => _NgayDiLam; set => _NgayDiLam = value; }
    }
}
