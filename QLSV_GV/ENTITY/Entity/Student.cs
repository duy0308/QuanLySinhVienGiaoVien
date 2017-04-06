namespace ENTITY.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        public string Address { get; set; }

        public bool? Gender { get; set; }

        public int? Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
