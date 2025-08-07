using Store.Model.Enum;
using Store.Model.Store;

namespace Store.Model.Directory;

public class Resource
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
    public Signature State { get; set; }
    
    public ICollection<Balance> Balances { get; set; } = new List<Balance>();
    public ICollection<ReceiptResource> ReceiptResources { get; set; } = new List<ReceiptResource>();
    public ICollection<ShipmentResource> ShipmentResources { get; set; } = new List<ShipmentResource>();
}