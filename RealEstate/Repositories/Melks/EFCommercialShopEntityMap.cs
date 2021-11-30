using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    class EFCommercialShopEntityMap : IEntityTypeConfiguration<CommercialShop>
    {
        public void Configure(EntityTypeBuilder<CommercialShop> builder)
        {
            builder.ToTable("CommercialShops");
            builder.Property(_ => _.OnTheShop).IsRequired();
        }
    }
}
