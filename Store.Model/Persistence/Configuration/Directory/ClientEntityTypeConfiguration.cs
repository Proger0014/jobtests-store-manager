using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Model.Directory;

namespace Store.Model.Persistence.Configuration.Directory;

public class ClientEntityTypeConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(Constants.DefaultStringMaxLength);
        builder.Property(e => e.Address)
            .IsRequired()
            .HasMaxLength(Constants.DefaultStringMaxLength);
        builder.Property(e => e.State)
            .IsRequired();
        builder
            .HasMany(e => e.Shipments)
            .WithOne(e => e.Client);
    }
}