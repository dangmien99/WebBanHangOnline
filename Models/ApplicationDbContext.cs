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
        public virtual DbSet<DanhGium> DanhGia { get; set; }
        public virtual DbSet<DanhMucSanPham> DanhMucSanPhams { get; set; }
        public virtual DbSet<DonDatHang> DonDatHangs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
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
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-MV6VII4;Initial Catalog=BANQUANAO;Integrated Security=True;");
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

                entity.Property(e => e.MaCtdh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaCTDH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaDh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaDH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.ThanhTien).HasComputedColumnSql("([Sl]*[DonGia])", false);

                entity.HasOne(d => d.MaDhNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaDh)
                    .HasConstraintName("FK__ChiTietDon__MaDH__35BCFE0A");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_ChiTietDonHang_SanPham");
            });

            modelBuilder.Entity<DanhGium>(entity =>
            {
                entity.HasKey(e => e.MaDg)
                    .HasName("PK__DanhGia__272586608A7D0CFD");

                entity.Property(e => e.MaDg)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaDG")
                    .IsFixedLength(true);

                entity.Property(e => e.DanhGia).HasMaxLength(50);

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.NgayDanhGia).HasColumnType("date");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DanhGia)
                    .HasForeignKey(d => d.MaKh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DanhGia__MaKH__38996AB5");
            });

            modelBuilder.Entity<DanhMucSanPham>(entity =>
            {
                entity.HasKey(e => e.MaDm)
                    .HasName("PK__DanhMucS__2725866E0F78C758");

                entity.ToTable("DanhMucSanPham");

                entity.Property(e => e.MaDm)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaDM")
                    .IsFixedLength(true);

                entity.Property(e => e.TenDm)
                    .HasMaxLength(50)
                    .HasColumnName("TenDM");
            });

            modelBuilder.Entity<DonDatHang>(entity =>
            {
                entity.HasKey(e => e.MaDh)
                    .HasName("PK__DonDatHa__27258661EDCB93B0");

                entity.ToTable("DonDatHang");

                entity.Property(e => e.MaDh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaDH")
                    .IsFixedLength(true);

                entity.Property(e => e.Dcgh)
                    .HasMaxLength(50)
                    .HasColumnName("DCGH");

                entity.Property(e => e.MaKh)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTt)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaTT")
                    .IsFixedLength(true);

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
                    .HasConstraintName("FK__DonDatHang__MaKH__31EC6D26");

                entity.HasOne(d => d.MaTtNavigation)
                    .WithMany(p => p.DonDatHangs)
                    .HasForeignKey(d => d.MaTt)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__DonDatHang__MaTT__32E0915F");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK__KhachHan__2725CF1E3FFB1AFD");

                entity.ToTable("KhachHang");

                entity.Property(e => e.MaKh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaKH")
                    .IsFixedLength(true);

                entity.Property(e => e.Dc)
                    .HasMaxLength(50)
                    .HasColumnName("DC");

                entity.Property(e => e.Email).HasMaxLength(30);

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .HasColumnName("SDT")
                    .IsFixedLength(true);

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.HasKey(e => e.MaSp)
                    .HasName("PK__SanPham__2725081CA1CAB706");

                entity.ToTable("SanPham");

                entity.Property(e => e.MaSp)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaSP")
                    .IsFixedLength(true);

                entity.Property(e => e.Anh).HasMaxLength(50);

                entity.Property(e => e.MaDm)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaDM")
                    .IsFixedLength(true);

                entity.Property(e => e.MaTh)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaTH")
                    .IsFixedLength(true);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaDmNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaDm)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaDM__2D27B809");

                entity.HasOne(d => d.MaThNavigation)
                    .WithMany(p => p.SanPhams)
                    .HasForeignKey(d => d.MaTh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SanPham__MaTH__2C3393D0");
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.HasKey(e => e.MaNd)
                    .HasName("PK__TaiKhoan__2725D7045924B4E5");

                entity.ToTable("TaiKhoan");

                entity.Property(e => e.MaNd)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength(true);

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
                entity.HasKey(e => e.MaTt)
                    .HasName("PK__ThanhToa__27250079B2F3627A");

                entity.ToTable("ThanhToan");

                entity.Property(e => e.MaTt)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaTT")
                    .IsFixedLength(true);

                entity.Property(e => e.Pttt)
                    .HasMaxLength(50)
                    .HasColumnName("PTTT");

                entity.Property(e => e.Tttt)
                    .HasMaxLength(50)
                    .HasColumnName("TTTT");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.HasKey(e => e.MaTh)
                    .HasName("PK__ThuongHi__272500756468DCA6");

                entity.ToTable("ThuongHieu");

                entity.Property(e => e.MaTh)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaTH")
                    .IsFixedLength(true);

                entity.Property(e => e.TenTh)
                    .HasMaxLength(50)
                    .HasColumnName("TenTH");
            });

            modelBuilder.Entity<VanChuyen>(entity =>
            {
                entity.HasKey(e => e.MaVc)
                    .HasName("PK__VanChuye__27251029B2F1768A");

                entity.ToTable("VanChuyen");

                entity.Property(e => e.MaVc)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaVC")
                    .IsFixedLength(true);

                entity.Property(e => e.MaDh)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MaDH")
                    .IsFixedLength(true);

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
                    .HasConstraintName("FK__VanChuyen__MaDH__3B75D760");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
