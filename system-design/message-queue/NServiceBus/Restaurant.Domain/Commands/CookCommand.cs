public class CookCommand : ICommand
{
    public string Item { get; set; }
    public int Quantity { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
}

public class Ingredient
{
    public string Name { get; set; }
    public int Quantity { get; set; }
}
