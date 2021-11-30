using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    class EFParticipationConstructionEntityMap : IEntityTypeConfiguration<ParticipationConstruction>
    {
        public void Configure(EntityTypeBuilder<ParticipationConstruction> builder)
        {
            builder.ToTable("ParticipationConstructions");
            builder.Property(_ => _.TransPassWidth).IsRequired(false);
            builder.Property(_ => _.NumberOfFloors).IsRequired();
            builder.Property(_ => _.LengthOfLength).IsRequired();
        }
    }
}
