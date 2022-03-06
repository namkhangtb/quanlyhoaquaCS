using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTPCS.entity
{
    class NhaPhanPhoi
    {
        string _MaNhaPhanPhoi;
        string _TenNhaPhanPhoi;
        string _DiaChi;
        string _Sdt;
        string _Email;
        public NhaPhanPhoi(SqlDataReader dr)
        {
            this.MaNhaPhanPhoi = dr["MaNhaPhanPhoi"].ToString();
            this.TenNhaPhanPhoi = dr["TenNhaPhanPhoi"].ToString();
            this.DiaChi = dr["DiaChi"].ToString(); ;
            this.Sdt = dr["Sdt"].ToString();
            this.Email = dr["Email"].ToString();
        }
        public string MaNhaPhanPhoi { get => _MaNhaPhanPhoi; set => _MaNhaPhanPhoi = value; }
        public string TenNhaPhanPhoi { get => _TenNhaPhanPhoi; set => _TenNhaPhanPhoi = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string Email { get => _Email; set => _Email = value; }
    }
}
