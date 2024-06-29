public class PlaceOrder: ICommand
{
    public Guid OrderId { get; set; }
    public string Item { get; set; }
    public int Quantity { get; set; }
}
