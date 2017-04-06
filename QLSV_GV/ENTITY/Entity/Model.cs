namespace ENTITY.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model : DbContext
    {
        public Model()
            : base("name=QLSVGVENTITY")
        {
        }

        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Student_Class> Student_Class { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Teacher_Class> Teacher_Class { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Teacher>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
