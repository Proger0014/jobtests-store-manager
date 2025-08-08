using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Model.Store;

namespace Store.Model.Persistence.Configuration.Store;

public class ReceiptDocumentEntityTypeConfiguration : IEntityTypeConfiguration<ReceiptDocument>
{
    public void Configure(EntityTypeBuilder<ReceiptDocument> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Number)
            .IsRequired()
            .HasMaxLength(Constants.DefaultStringMaxLength);
        builder.Property(e => e.Date)
            .IsRequired();

        builder
            .HasMany(e => e.ReceiptResources)
            .WithOne(e => e.ReceiptDocument);
    }
}