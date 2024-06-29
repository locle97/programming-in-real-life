public class OrderCommand : ICommand
{
    public string Item { get; set; }
    public int Quantity { get; set; }
}
