namespace QLTPCS.DataAcessLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietPhieuNhaps = new HashSet<ChiTietPhieuNhap>();
        }

        [Key]
        [StringLength(255)]
        public string MaSanPham { get; set; }

        [Required]
        [StringLength(255)]
        public string TenSanPham { get; set; }

        [Required]
        [StringLength(255)]
        public string MaLoaiSanPham { get; set; }

        [Required]
        [StringLength(255)]
        public string NoiSanXuat { get; set; }

        [Required]
        [StringLength(100)]
        public string GiaNhap { get; set; }

        [Required]
        [StringLength(100)]
        public string GiaBan { get; set; }

        public int? TonKho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
    }
}
