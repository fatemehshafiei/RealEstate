using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    public class EFLandEntityMap : IEntityTypeConfiguration<Land>
    {
        public void Configure(EntityTypeBuilder<Land> builder)
        {
            builder.ToTable("Lands");
            builder.Property(_ => _.OnEarth).IsRequired();
            builder.Property(_ => _.TransPassWidth).IsRequired(false);
        }
    }
}
