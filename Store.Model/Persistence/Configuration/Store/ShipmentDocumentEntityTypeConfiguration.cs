using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Model.Store;

namespace Store.Model.Persistence.Configuration.Store;

public class ShipmentDocumentEntityTypeConfiguration : IEntityTypeConfiguration<ShipmentDocument>
{
    public void Configure(EntityTypeBuilder<ShipmentDocument> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Number)
            .IsRequired()
            .HasMaxLength(Constants.DefaultStringMaxLength);
        builder.Property(e => e.Date)
            .IsRequired();
        builder.Property(e => e.State)
            .IsRequired();

        builder
            .HasOne(e => e.Client)
            .WithMany(e => e.Shipments);
    }
}