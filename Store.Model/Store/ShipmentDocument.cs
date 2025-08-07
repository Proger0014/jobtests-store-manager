using Store.Model.Directory;
using Store.Model.Enum;

namespace Store.Model.Store;

public class ShipmentDocument
{
    public Guid Id { get; set; }
    public required string Number { get; set; }
    public Client? Client { get; set; }
    public DateOnly Date { get; set; }
    public Status State { get; set; }
}