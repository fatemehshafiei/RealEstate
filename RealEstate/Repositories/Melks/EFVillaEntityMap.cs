using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    public class EFVillaEntityMap : IEntityTypeConfiguration<Villa>
    {
        public void Configure(EntityTypeBuilder<Villa> _)
        {
            _.ToTable("Villas");
            _.Property(_ => _.Age).IsRequired();
            _.Property(_ => _.RoomCount).IsRequired();
            _.Property(_ => _.BuildingSize).IsRequired();
            _.Property(_ => _.TransPassWidth).IsRequired(false);
        }
    }
}
