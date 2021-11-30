using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    class EFAgroIndustryEntityMap : IEntityTypeConfiguration<AgroIndustry>
    {
        public void Configure(EntityTypeBuilder<AgroIndustry> builder)
        {
            builder.ToTable("AgroIndustries");
            builder.Property(_ => _.BuildingSize).IsRequired();
        }
    }
}
