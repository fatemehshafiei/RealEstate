using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    class EFApartmentComplexEntityMap : IEntityTypeConfiguration<ApartmentComplex>
    {
        public void Configure(EntityTypeBuilder<ApartmentComplex> builder)
        {
            builder.ToTable("ApartmentComplexes");
            builder.Property(_ => _.Age).IsRequired();
            builder.Property(_ => _.HasElevator).IsRequired(false);
            builder.Property(_ => _.HasLoan).IsRequired(false);
            builder.Property(_ => _.HasParking).IsRequired(false);
            builder.Property(_ => _.HasStoreRoom).IsRequired(false);
            builder.Property(_ => _.NumberOfFloors).IsRequired();
        }
    }
}
