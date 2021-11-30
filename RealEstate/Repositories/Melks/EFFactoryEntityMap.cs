using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    class EFFactoryEntityMap : IEntityTypeConfiguration<Factory>
    {
        public void Configure(EntityTypeBuilder<Factory> builder)
        {
            builder.ToTable("Factories");
            builder.Property(_ => _.BuildingSize).IsRequired();
        }

    }
}
