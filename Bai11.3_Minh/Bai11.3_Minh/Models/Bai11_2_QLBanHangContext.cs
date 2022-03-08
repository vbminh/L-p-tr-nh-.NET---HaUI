using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Bai11._3_Minh.Models
{
    public partial class Bai11_2_QLBanHangContext : DbContext
    {
        public Bai11_2_QLBanHangContext()
        {
        }

        public Bai11_2_QLBanHangContext(DbContextOptions<Bai11_2_QLBanHangContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<HoaDonChiTiet> HoaDonChiTiets { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NguoiDung> NguoiDungs { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=minh\\sqlexpress01;Initial Catalog=Bai11_2_QLBanHang;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd)
                    .HasName("PK__HoaDon__2725A6E0090FCE6F");

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaKh)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.Ngaylap).HasColumnType("date");

                entity.Property(e => e.NguoiLap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_HoaDon_KhachHang");
            });

            modelBuilder.Entity<HoaDonChiTiet>(entity =>
            {
                entity.HasKey(e => new { e.MaHd, e.MaSp })
                    .HasName("PK__HoaDonCh__F557F6614A40AAF8");

                entity.ToTable("HoaDonChiTiet");

                entity.Property(e => e.MaHd)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaHD")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaHd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonChiTiet_HoaDon");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.HoaDonChiTiets)
                    .HasForeignKey(d => d.MaSp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HoaDonChiTiet_SanPham");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1EA5CC91EB");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.SoDt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("SoDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<LoaiSanPham>(entity =>
            {
                entity.HasKey(e => e.MaLoai)
                    .HasName("PK__LoaiSanP__730A575970662ABA");

                entity.ToTable("LoaiSanPham");

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenLoai)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NguoiDung>(entity =>
            {
                entity.HasKey(e => e.TenDangNhap)
                    .HasName("PK__NguoiDun__55F68FC1D14A0B20");

                entity.ToTable("NguoiDung");

                entity.Property(e => e.TenDangNhap)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Hoten)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Matkhau)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081CDAA44EB9");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.MaLoai)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TenSp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_SanPham_LoaiSanPham");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
