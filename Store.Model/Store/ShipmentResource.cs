using Store.Model.Directory;

namespace Store.Model.Store;

public class ShipmentResource
{
    public Guid Id { get; set; }
    public Resource? Resource { get; set; }
    public UnitMeasure? Measure { get; set; }
    public int Quantity { get; set; }
}