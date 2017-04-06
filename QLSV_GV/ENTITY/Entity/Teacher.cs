namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Teacher")]
    public partial class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        public int? Phone { get; set; }

        public byte? Gender { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
