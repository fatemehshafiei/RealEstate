using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Persistence.EF.Documents
{
    class EFMelkImageDocumentEntityMap : IEntityTypeConfiguration<MelkImageDocument>
    {
        public void Configure(EntityTypeBuilder<MelkImageDocument> builder)
        {
            builder.ToTable("MelkImageDocuments");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.DocumentId).IsRequired();
            builder.Property(_ => _.Extension).IsRequired();
            builder.HasOne(_ => _.Melk).WithMany(_ => _.Images)
                 .HasForeignKey(_ => _.MelkId);
        }
    }
}
