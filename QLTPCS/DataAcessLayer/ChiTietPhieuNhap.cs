namespace QLTPCS.DataAcessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuNhap")]
    public partial class ChiTietPhieuNhap
    {
        [Key]
        [StringLength(255)]
        public string MaCTPN { get; set; }

        [Required]
        [StringLength(255)]
        public string MaPhieuNhap { get; set; }

        [Required]
        [StringLength(255)]
        public string MaSanPham { get; set; }

        public int SoLuong { get; set; }

        public int DonGia { get; set; }

        public virtual PhieuNhap PhieuNhap { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
