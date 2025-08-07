using Store.Model.Enum;
using Store.Model.Store;

namespace Store.Model.Directory;

public class Client
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public required string Address { get; set; }
    public Signature State { get; set; }

    public ICollection<ShipmentDocument> Shipments { get; set; } = new List<ShipmentDocument>();
}