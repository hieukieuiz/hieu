namespace WebBanCafe
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<LOAITHUCPHAM> LOAITHUCPHAMs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<THUCPHAM> THUCPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LOAITHUCPHAM>()
                .Property(e => e.MALOAISANPHAM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUCPHAM>()
                .Property(e => e.MASANPHAM)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<THUCPHAM>()
                .Property(e => e.MALOAISANPHAM)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
