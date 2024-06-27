// This is an example of inheritance in C#
// See https://aka.ms/new-console-template for more information

Console.WriteLine("Init a house...");
var myHouse = new BaseHouse();
myHouse.BuildHouse();

Console.WriteLine();
Console.WriteLine("Init a villa...");
var myVilla = new Villa();
myVilla.BuildHouse();

Console.WriteLine();
Console.WriteLine("Init a bungalow...");
var myBungalow = new Bungalow();
myBungalow.BuildHouse();


public class BaseHouse
{
    public string Roof { get; set; }
    public string Walls { get; set; }
    public string Windows { get; set; }
    public string Doors { get; set; }
    public string Foundation { get; set; }

    public void BuildHouse()
    {
      Console.WriteLine("Building a house...");
      Console.WriteLine("Roof: " + Roof);
      Console.WriteLine("Walls: " + Walls);
      Console.WriteLine("Windows: " + Windows);
      Console.WriteLine("Doors: " + Doors);
      Console.WriteLine("Foundation: " + Foundation);
    }
}

public class Villa : BaseHouse
{
    public string Pool { get; set; }

    public new void BuildHouse()
    {
      base.BuildHouse();

      Console.WriteLine("Building a villa...");
      Console.WriteLine("Pool: " + Pool);
    }
}

public class Bungalow : BaseHouse
{
    public string Garden { get; set; }
    public string Garage { get; set; }

    public new void BuildHouse()
    {
      base.BuildHouse();

      Console.WriteLine("Building a bungalow...");
      Console.WriteLine("Garden: " + Garden);
      Console.WriteLine("Garage: " + Garage);
    }
}
