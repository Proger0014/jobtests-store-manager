using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Model.Store;

namespace Store.Model.Persistence.Configuration.Store;

public class BalanceEntityTypeConfiguration : IEntityTypeConfiguration<Balance>
{
    public void Configure(EntityTypeBuilder<Balance> builder)
    {
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedNever();
        builder.Property(e => e.Quantity)
            .IsRequired();

        builder
            .HasOne(e => e.Resource)
            .WithMany(e => e.Balances);
        builder
            .HasOne(e => e.Measure)
            .WithMany(e => e.Balances);
    }
}