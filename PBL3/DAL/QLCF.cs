using PBL3.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3
{
    public class QLCF : DbContext
    {
        
        public QLCF()
            : base("name=QLCF")
        {
            Database.SetInitializer<QLCF>(new CreateDB());
        }
        public DbSet<BAN> BANs { get; set; }

        public DbSet<BANTHANHTOAN> BANTHANHTOANs { get; set; }
        public DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public DbSet<CHUCVU> CHUCVUs { get; set; }
        public DbSet<HOADON> HOADONs { get; set; }
        public DbSet<LOAIDOUONG> LOAIDOUONGs { get; set; }
        public DbSet<DOUONG> DOUONGs { get; set; }
        public DbSet<TAIKHOAN> TAIKHOANs { get; set; }
        public DbSet<THONGTINNHANVIEN> THONGTINNHANVIENs { get; set; }
        public DbSet<LUONGNHANVIEN> LUONGNHANVIENs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAIKHOAN>().HasRequired(a => a.THONGTINNHANVIEN).WithRequiredDependent(b => b.TAIKHOAN);
        }

    }

}