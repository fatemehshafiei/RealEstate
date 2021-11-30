using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Repositories.Melks
{
    public class EFMelkEntitiMap : IEntityTypeConfiguration<Melk>
    {
        public void Configure(EntityTypeBuilder<Melk> _)
        {
            _.ToTable("Melks");
            _.HasKey(_ => _.Id);
            _.Property(_ => _.Id).ValueGeneratedOnAdd();
            _.Property(_ => _.RegistrationPlate).HasMaxLength(50).IsRequired(false);
            _.Property(_ => _.CreateDate).IsRequired();
            _.Property(_ => _.Size).IsRequired();
            _.Property(_ => _.DepositAmount).IsRequired(false);
            _.Property(_ => _.RentAmount).IsRequired(false);
            _.Property(_ => _.Price).IsRequired(false);
            _.Property(_ => _.Title).HasMaxLength(2000).IsRequired();
            _.Property(_ => _.Detail).HasMaxLength(2000).IsRequired(false);
            _.OwnsOne(_ => _.Address, _ =>
            {
                _.Property(_ => _.Title).HasMaxLength(1000).IsRequired().HasColumnName("Address_Title");
                _.Property(_ => _.Longitude).IsRequired().HasColumnName("Address_Longitude");
                _.Property(_ => _.Latitude).IsRequired().HasColumnName("Address_Latitude");
            });
            _.HasMany(_ => _.Images).WithOne(_ => _.Melk).HasForeignKey(_ => _.MelkId);
            _.HasMany(_ => _.Videos).WithOne(_ => _.Melk).HasForeignKey(_ => _.MelkId);
            _.HasOne<Apartmant>().WithOne(_ => _.Melk).HasForeignKey<Apartmant>(_ => _.Id);
            _.HasOne<ApartmentComplex>().WithOne(_ => _.Melk).HasForeignKey<ApartmentComplex>(_ => _.Id);
            _.HasOne<Villa>().WithOne(_ => _.Melk).HasForeignKey<Villa>(_ => _.Id);
            _.HasOne<AgroIndustry>().WithOne(_ => _.Melk).HasForeignKey<AgroIndustry>(_ => _.Id);
            _.HasOne<Factory>().WithOne(_ => _.Melk).HasForeignKey<Factory>(_ => _.Id);
            _.HasOne<Land>().WithOne(_ => _.Melk).HasForeignKey<Land>(_ => _.Id);
            _.HasOne<Garden>().WithOne(_ => _.Melk).HasForeignKey<Garden>(_ => _.Id);
            _.HasOne<ParticipationConstruction>().WithOne(_ => _.Melk).HasForeignKey<ParticipationConstruction>(_ => _.Id);
            _.HasOne<CommercialShop>().WithOne(_ => _.Melk).HasForeignKey<CommercialShop>(_ => _.Id);

        }

    }
}
