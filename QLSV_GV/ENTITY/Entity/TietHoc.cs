namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TietHoc")]
    public partial class TietHoc
    {
        public int idLop { get; set; }

        public int idMonHoc { get; set; }

        public int Tiet { get; set; }

        public DateTime TuNgay { get; set; }

        public int id { get; set; }

        public int idGiaoVien { get; set; }

        public DateTime DenNgay { get; set; }

        public int Thu { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
