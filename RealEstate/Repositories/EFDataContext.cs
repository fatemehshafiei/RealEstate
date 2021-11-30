using Microsoft.EntityFrameworkCore;
using RealEstate.App.Models.Inducs;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories
{
    public class EFDataContext : DbContext
    {
        public DbSet<Melk> Properties { get; set; }
        public DbSet<Villa> Villas { get; set; }

        public DbSet<Document> Documents { get; set; }
        public DbSet<Apartmant> Apartmants { get; set; }
        public DbSet<ApartmentComplex> ApartmentComplexes { get; set; }
        public DbSet<AgroIndustry> AgroIndustries { get; set; }
        public DbSet<Factory> Factories { get; set; }
        public DbSet<Land> Lands { get; set; }
        public DbSet<Garden> Gardens { get; set; }
        public DbSet<ParticipationConstruction> ParticipationConstructions { get; set; }
        public DbSet<CommercialShop> CommercialShops { get; set; }
        public DbSet<MelkImageDocument> MelkImageDocuments { get; set; }
        public DbSet<MelkVideoDocument> MelkVideoDocuments { get; set; }

        private EFDataContext(DbContextOptions<EFDataContext> options) : base(options)
        {
        }
        public EFDataContext()
          : this(new DbContextOptionsBuilder<EFDataContext>().UseSqlServer("server=.;database=RealEstate;trusted_connection=true;").Options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EFDataContext).Assembly);
            modelBuilder.Entity<Melk>().OwnsOne(c => c.Address);

        }
    }
}
