using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    public class EFApartmentEntityMap : IEntityTypeConfiguration<Apartmant>
    {
        public void Configure(EntityTypeBuilder<Apartmant> builder)
        {
            builder.ToTable("Apartmants");
            builder.Property(_ => _.Floor).IsRequired();
            builder.Property(_ => _.HasElevator).IsRequired(false);
            builder.Property(_ => _.HasLoan).IsRequired(false);
            builder.Property(_ => _.HasParking).IsRequired(false);
            builder.Property(_ => _.HasStoreRoom).IsRequired(false);
            builder.Property(_ => _.HasStoreRoom).IsRequired(false);
            builder.Property(_ => _.RoomCount).IsRequired();
            builder.Property(_ => _.Age).IsRequired();
        }
    }
}
