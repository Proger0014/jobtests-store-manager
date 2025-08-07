namespace Store.Model.Store;

public class ReceiptDocument
{
    public Guid Id { get; set; }
    public required string Number { get; set; }
    public DateOnly Date { get; set; }
}