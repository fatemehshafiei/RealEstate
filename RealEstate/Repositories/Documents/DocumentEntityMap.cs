using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstate.App.Models.Inducs;

namespace RealEstate.Persistence.Documents
{
    class DocumentEntityMap : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> _)
        {
            _.ToTable("Documents");
            _.HasKey(_ => _.Id);
            
            _.Property(_ => _.Id);
            _.Property(_ => _.Data).IsRequired();
            _.Property(_ => _.FileName).HasMaxLength(50).IsRequired();
            _.Property(_ => _.Extension).HasMaxLength(10).IsRequired();
            _.Property(_ => _.CreationDate).IsRequired();
        }
    }
}
