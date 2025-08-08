using Microsoft.EntityFrameworkCore;
using Store.Model.Directory;
using Store.Model.Store;

namespace Store.Model.Persistence;

public class Persistence(DbContextOptions<Persistence> options) : DbContext(options)
{
    public DbSet<Client> Clients { get; set; }
    public DbSet<Resource> Resources { get; set; }
    public DbSet<UnitMeasure> UnitMeasures { get; set; }
    
    public DbSet<Balance> Balances { get; set; }
    public DbSet<ReceiptDocument> ReceiptDocuments { get; set; }
    public DbSet<ReceiptResource> ReceiptResources { get; set; }
    public DbSet<ShipmentDocument> ShipmentDocuments { get; set; }
    public DbSet<ShipmentResource> ShipmentResources { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Persistence).Assembly);
    }
}