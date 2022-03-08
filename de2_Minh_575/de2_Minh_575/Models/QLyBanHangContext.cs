using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace De2_Minh_575.Models
{
    public partial class QLyBanHangContext : DbContext
    {
        public QLyBanHangContext()
        {
        }

        public QLyBanHangContext(DbContextOptions<QLyBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSp> LoaiSps { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MINH\\SQLEXPRESS01;Initial Catalog=QLyBanHang;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK__HoaDonCh__F557F6611C22A1BE");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayBan).HasColumnType("date");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__HoaDonChiT__MaSP__4E88ABD4");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E5F2D4A52");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayMua).HasColumnType("date");
            });

            modelBuilder.Entity<LoaiSp>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSP__730A575961001791");

                entity.ToTable("LoaiSP");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenLoai).HasMaxLength(20);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081CF40E5B19");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(30)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK__SanPham__MaLoai__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
