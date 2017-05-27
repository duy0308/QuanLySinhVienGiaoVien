namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            HocSinhs = new HashSet<HocSinh>();
            TietHocs = new HashSet<TietHoc>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string MaLop { get; set; }

        public decimal NamHoc { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLop { get; set; }

        public decimal Khoi { get; set; }

        public int Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocSinh> HocSinhs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TietHoc> TietHocs { get; set; }
    }
}
