namespace WebApplication4.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<tBanSaoSach> tBanSaoSaches { get; set; }
        public virtual DbSet<tDocGia> tDocGias { get; set; }
        public virtual DbSet<tDoiTuong> tDoiTuongs { get; set; }
        public virtual DbSet<tDonVi> tDonVis { get; set; }
        public virtual DbSet<tLoaiSach> tLoaiSaches { get; set; }
        public virtual DbSet<tMuonTra> tMuonTras { get; set; }
        public virtual DbSet<tNgonNgu> tNgonNgus { get; set; }
        public virtual DbSet<tNhaXB> tNhaXBs { get; set; }
        public virtual DbSet<tSach> tSaches { get; set; }
        public virtual DbSet<tTheDocGia> tTheDocGias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tBanSaoSach>()
                .Property(e => e.MaBanSao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tBanSaoSach>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tBanSaoSach>()
                .HasMany(e => e.tMuonTras)
                .WithRequired(e => e.tBanSaoSach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tDocGia>()
                .Property(e => e.MaDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDocGia>()
                .Property(e => e.MaDonVi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDocGia>()
                .Property(e => e.MaDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDocGia>()
                .Property(e => e.Anh)
                .IsFixedLength();

            modelBuilder.Entity<tDoiTuong>()
                .Property(e => e.MaDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tDonVi>()
                .Property(e => e.MaDonVi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tLoaiSach>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tMuonTra>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tMuonTra>()
                .Property(e => e.MaBanSao)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tNgonNgu>()
                .Property(e => e.MaNgonNgu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tNhaXB>()
                .Property(e => e.MaNXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.MaSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.MaLoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.MaNgonNgu)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.MaNXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.NamXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.LanXB)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.GioiThieu)
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.TongSoTrang)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.Tap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.TongSoTap)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tSach>()
                .Property(e => e.FileAnh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tTheDocGia>()
                .Property(e => e.MaThe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tTheDocGia>()
                .Property(e => e.MaDG)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tTheDocGia>()
                .HasMany(e => e.tMuonTras)
                .WithRequired(e => e.tTheDocGia)
                .WillCascadeOnDelete(false);
        }
    }
}
