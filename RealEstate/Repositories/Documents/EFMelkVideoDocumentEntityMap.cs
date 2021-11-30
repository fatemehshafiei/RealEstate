using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Melks;

namespace RealEstate.Persistence.EF.Documents
{
    public class EFMelkVideoDocumentEntityMap : IEntityTypeConfiguration<MelkVideoDocument>
    {
        public void Configure(EntityTypeBuilder<MelkVideoDocument> builder)
        {
            builder.ToTable("MelkVideoDocuments");
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.DocumentId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(_ => _.Extension).IsRequired();
           // builder.HasOne(_ => _.Melk).WithMany(_ => _.Videos)
                 //.HasForeignKey(_ => _.MelkId);
        }
    }
}
