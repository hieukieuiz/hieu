namespace WebBanCafe
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

        public virtual DbSet<CHUYENNGANH> CHUYENNGANHs { get; set; }
        public virtual DbSet<DIEMLHP> DIEMLHPs { get; set; }
        public virtual DbSet<DiemRL> DiemRLs { get; set; }
        public virtual DbSet<GIANGVIEN> GIANGVIENs { get; set; }
        public virtual DbSet<HOCKY> HOCKies { get; set; }
        public virtual DbSet<HOCPHAN> HOCPHANs { get; set; }
        public virtual DbSet<KETQUA> KETQUAs { get; set; }
        public virtual DbSet<KHOA> KHOAs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<LOPHOCPHAN> LOPHOCPHANs { get; set; }
        public virtual DbSet<SINHVIEN> SINHVIENs { get; set; }
        public virtual DbSet<THONGKE> THONGKEs { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_dev> spt_fallback_dev { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUYENNGANH>()
                .Property(e => e.MACHUYENNGANH)
                .IsUnicode(false);

            modelBuilder.Entity<CHUYENNGANH>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEMLHP>()
                .Property(e => e.MALOPHOCPHAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DIEMLHP>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DiemRL>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DiemRL>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DiemRL>()
                .Property(e => e.MAHOCKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GIANGVIEN>()
                .Property(e => e.MAGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCKY>()
                .Property(e => e.MAHOCKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCKY>()
                .HasMany(e => e.DiemRLs)
                .WithRequired(e => e.HOCKY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCKY>()
                .HasMany(e => e.THONGKEs)
                .WithRequired(e => e.HOCKY)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOCPHAN>()
                .Property(e => e.MAHOCPHAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCPHAN>()
                .HasMany(e => e.KETQUAs)
                .WithRequired(e => e.HOCPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KETQUA>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KETQUA>()
                .Property(e => e.MAHOCPHAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KETQUA>()
                .Property(e => e.DIEMCHU)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHOA>()
                .Property(e => e.MATRUONGKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .Property(e => e.MAKHOA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOP>()
                .HasMany(e => e.DiemRLs)
                .WithRequired(e => e.LOP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPHOCPHAN>()
                .Property(e => e.MALOPHOCPHAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOCPHAN>()
                .Property(e => e.MAHOCKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOCPHAN>()
                .Property(e => e.MAGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOCPHAN>()
                .Property(e => e.MAHOCPHAN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOCPHAN>()
                .HasMany(e => e.DIEMLHPs)
                .WithRequired(e => e.LOPHOCPHAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.GT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .Property(e => e.MALOP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.DIEMLHPs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.DiemRLs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.KETQUAs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SINHVIEN>()
                .HasMany(e => e.THONGKEs)
                .WithRequired(e => e.SINHVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<THONGKE>()
                .Property(e => e.MASV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THONGKE>()
                .Property(e => e.MAHOCKY)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_db>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.xfallback_drive)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_dev>()
                .Property(e => e.phyname)
                .IsUnicode(false);

            modelBuilder.Entity<spt_fallback_usg>()
                .Property(e => e.xserver_name)
                .IsUnicode(false);
        }
    }
}
