using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Model.Directory;

namespace Store.Model.Persistence.Configuration.Directory;

public class ResourceEntityTypeConfiguration : IEntityTypeConfiguration<Resource>
{
    public void Configure(EntityTypeBuilder<Resource> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(Constants.DefaultStringMaxLength);
        builder.Property(e => e.State)
            .IsRequired();
        builder
            .HasMany(e => e.Balances)
            .WithOne(e => e.Resource);
        builder
            .HasMany(e => e.ReceiptResources)
            .WithOne(e => e.Resource);
        builder
            .HasMany(e => e.ShipmentResources)
            .WithOne(e => e.Resource);
    }
}