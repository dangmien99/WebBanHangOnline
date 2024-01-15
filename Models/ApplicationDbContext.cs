using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DanhGiaKh> DanhGiaKhs { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DonDatHang> DonDatHangs { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<SanPham> SanPhams { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }
        public virtual DbSet<VanChuyen> VanChuyens { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=THUONG\\HOAITHUONG;Initial Catalog=BANQUANAO;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => e.MaCtdh)
                    .HasName("PK__ChiTietD__1E4E40F00C0C4F8C");

                entity.ToTable("ChiTietDonHang");

                entity.Property(e => e.MaCtdh).HasColumnName("MaCTDH");

                entity.Property(e => e.MaDh).HasColumnName("MaDH");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.ThanhTien).HasComputedColumnSql("([Sl]*[DonGia])", false);

                entity.HasOne(d => d.MaDhNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaDh)
                    .HasConstraintName("FK_ChiTietDonHang_DonDatHang");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_ChiTietDonHang_SanPham");
            });

            modelBuilder.Entity<DanhGiaKh>(entity =>
            {
                entity.HasKey(e => e.MaDg)
                    .HasName("PK__DanhGia__272586608A7D0CFD");

                entity.ToTable("DanhGiaKH");

                entity.Property(e => e.MaDg).HasColumnName("MaDG");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayDanhGia).HasColumnType("date");

                entity.Property(e => e.NoiDung).HasMaxLength(50);

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DanhGiaKhs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DanhGia_KhachHang");
            });

            modelBuilder.Entity<DanhMucSanPham>(entity =>
            {
                entity.HasKey(e => e.MaDm);

                entity.ToTable("DanhMucSanPham");

                entity.Property(e => e.TenDm).HasMaxLength(50);
            });

            modelBuilder.Entity<DonDatHang>(entity =>
            {
                entity.HasKey(e => e.MaDh);

                entity.ToTable("DonDatHang");

                entity.Property(e => e.MaDh).HasColumnName("MaDH");

                entity.Property(e => e.Dcgh)
                    .HasMaxLength(50)
                    .HasColumnName("DCGH");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.NgayDh)
                    .HasColumnType("date")
                    .HasColumnName("NgayDH");

                entity.Property(e => e.TrangThaiDh)
                    .HasMaxLength(50)
                    .HasColumnName("TrangThaiDH");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DonDatHangs)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonDatHang_KhachHang");

                entity.HasOne(d => d.MaTtNavigation)
                    .WithMany(p => p.DonDatHangs)
                    .HasForeignKey(d => d.MaTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DonDatHang_ThanhToan");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.MaGio);

                entity.ToTable("GioHang");

                entity.Property(e => e.Anh).HasMaxLength(50);

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.NgayThem).HasColumnType("date");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh);

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .HasColumnName("DC");

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaNv);

                entity.ToTable("NhanVien");

                entity.Property(e => e.MaNv).HasColumnName("MaNV");

                entity.Property(e => e.DiaChi).HasMaxLength(50);

                entity.Property(e => e.HoTen).HasMaxLength(50);

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");
            });

            modelBuilder.Entity<PhanQuyen>(entity =>
            {
                entity.HasKey(e => e.MaPq);

                entity.ToTable("PhanQuyen");

                entity.Property(e => e.MaPq).HasColumnName("MaPQ");

                entity.Property(e => e.TenPq)
                    .HasMaxLength(50)
                    .HasColumnName("TenPQ");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("SanPham");

                entity.Property(e => e.Anh).HasMaxLength(50);

                entity.Property(e => e.TenSp).HasMaxLength(50);

                entity.HasOne(d => d.MaDmNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaDm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPham_DanhMucSanPham");

                entity.HasOne(d => d.MaThNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaTh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SanPham_ThuongHieu");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaNd)
                    .HasName("PK__TaiKhoan__2725D7045924B4E5");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MatKhau).HasMaxLength(20);

                entity.Property(e => e.TaiKhoan1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("TaiKhoan")
                    .IsFixedLength(true);

                entity.Property(e => e.Ten).HasMaxLength(50);
            });

            modelBuilder.Entity<ThanhToan>(entity =>
            {
                entity.HasKey(e => e.MaTt);

                entity.ToTable("ThanhToan");

                entity.Property(e => e.MaTt).HasColumnName("MaTT");

                entity.Property(e => e.Pttt)
                    .HasMaxLength(50)
                    .HasColumnName("PTTT");

                entity.Property(e => e.Tttt)
                    .HasMaxLength(50)
                    .HasColumnName("TTTT");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.HasKey(e => e.MaTh);

                entity.ToTable("ThuongHieu");

                entity.Property(e => e.TenTh).HasMaxLength(50);
            });

            modelBuilder.Entity<VanChuyen>(entity =>
            {
                entity.HasKey(e => e.MaVc)
                    .HasName("PK__VanChuye__27251029B2F1768A");

                entity.ToTable("VanChuyen");

                entity.Property(e => e.MaVc).HasColumnName("MaVC");

                entity.Property(e => e.MaDh).HasColumnName("MaDH");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(50)
                    .HasColumnName("SDT");

                entity.Property(e => e.TenNguoiVc)
                    .HasMaxLength(50)
                    .HasColumnName("TenNguoiVC");

                entity.HasOne(d => d.MaDhNavigation)
                    .WithMany(p => p.VanChuyens)
                    .HasForeignKey(d => d.MaDh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VanChuyen_DonDatHang");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
