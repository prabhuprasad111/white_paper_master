using Microsoft.EntityFrameworkCore;
using static white_paper_master.Models.Common;

namespace white_paper_master.Models
{
    public class StateDbContext : DbContext
    {
        public StateDbContext(DbContextOptions<StateDbContext> options)
            : base(options)
        {
        }

        public DbSet<OdWpPoliceStation> m_police_station { get; set; }
        public DbSet<OdWpDistrict> m_district { get; set; }
        public DbSet<LoginRequest> t_user_info { get; set; }
        public DbSet<OfficeInfo> OfficeInfoResults { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<OfficeInfo>().HasNoKey();

            modelBuilder.Entity<OdWpPoliceStation>()
                .HasKey(e => e.PS_CD);

            modelBuilder.Entity<OdWpDistrict>()
                .HasKey(e => e.DISTRICT_CD); // Corrected property name

            modelBuilder.Entity<OdWpDistrict>()
                .Property(e => e.LANG_CD)
                .IsRequired();

            modelBuilder.Entity<OdWpDistrict>()
                .Property(e => e.DISTRICT) // Ensure this property exists in OdWpDistrict
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<LoginRequest>().HasNoKey();
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
