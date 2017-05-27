namespace ENTITY.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLGDEntity : DbContext
    {
        public QLGDEntity()
            : base("name=QLGDEntity")
        {
        }

        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<HocSinh> HocSinhs { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<TietHoc> TietHocs { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.MaGiaoVien)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength();

            modelBuilder.Entity<GiaoVien>()
                .HasMany(e => e.TietHocs)
                .WithRequired(e => e.GiaoVien)
                .HasForeignKey(e => e.idGiaoVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.MaHocSinh)
                .IsFixedLength();

            modelBuilder.Entity<HocSinh>()
                .Property(e => e.NamBatDau)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Lop>()
                .Property(e => e.MaLop)
                .IsFixedLength();

            modelBuilder.Entity<Lop>()
                .Property(e => e.NamHoc)
                .HasPrecision(4, 0);

            modelBuilder.Entity<Lop>()
                .Property(e => e.Khoi)
                .HasPrecision(2, 0);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.HocSinhs)
                .WithRequired(e => e.Lop)
                .HasForeignKey(e => e.IdLop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.TietHocs)
                .WithRequired(e => e.Lop)
                .HasForeignKey(e => e.idLop)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .Property(e => e.MaMonHoc)
                .IsFixedLength();

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.GiaoViens)
                .WithRequired(e => e.MonHoc)
                .HasForeignKey(e => e.idMonHoc)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.TietHocs)
                .WithRequired(e => e.MonHoc)
                .HasForeignKey(e => e.idMonHoc)
                .WillCascadeOnDelete(false);
        }
    }
}
