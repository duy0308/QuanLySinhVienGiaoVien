namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Class
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Student { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Class { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [Column(TypeName = "ntext")]
        public string Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_Start { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date_end { get; set; }
    }
}
