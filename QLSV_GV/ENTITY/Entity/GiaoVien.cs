namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiaoVien")]
    public partial class GiaoVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GiaoVien()
        {
            TietHocs = new HashSet<TietHoc>();
        }

        [Required]
        [StringLength(10)]
        public string MaGiaoVien { get; set; }

        public int id { get; set; }

        [Required]
        [StringLength(200)]
        public string TenGiaoVien { get; set; }

        public DateTime NgaySinh { get; set; }

        public int GioiTinh { get; set; }

        [StringLength(11)]
        public string SoDienThoai { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string DiaChi { get; set; }

        public string GhiChu { get; set; }

        public int idMonHoc { get; set; }

        public virtual MonHoc MonHoc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TietHoc> TietHocs { get; set; }
    }
}
