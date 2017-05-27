namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocSinh")]
    public partial class HocSinh
    {
        [Required]
        [StringLength(10)]
        public string MaHocSinh { get; set; }

        [Required]
        [StringLength(200)]
        public string TenHocSinh { get; set; }

        public DateTime NgaySinh { get; set; }

        [Required]
        public string DiaChi { get; set; }

        public decimal NamBatDau { get; set; }

        public int id { get; set; }

        public int GioiTinh { get; set; }

        public string GhiChu { get; set; }

        public int IdLop { get; set; }

        public virtual Lop Lop { get; set; }


    }
}
