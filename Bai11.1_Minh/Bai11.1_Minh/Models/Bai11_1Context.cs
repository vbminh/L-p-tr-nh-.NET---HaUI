using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bai11._1_Minh.Models
{
    public partial class Bai11_1Context : DbContext
    {
        public Bai11_1Context()
        {
        }

        public Bai11_1Context(DbContextOptions<Bai11_1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MINH\\SQLEXPRESS01;Initial Catalog=Bai11_1;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.MaHang)
                    .HasName("PK__Brand__19C0DB1D7A962FC4");

                entity.ToTable("Brand");

                entity.Property(e => e.MaHang)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenHang).HasMaxLength(20);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__Product__2725081CAAB3503B");

                entity.ToTable("Product");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.MaHang)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Mau).HasMaxLength(20);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(20)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaHangNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.MaHang)
                    .HasConstraintName("FK_Product_Brand");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
