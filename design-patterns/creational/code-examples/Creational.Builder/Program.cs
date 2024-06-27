// This is an example of the Builder design pattern in C#.

internal class Program
{
    private static void Main(string[] args)
    {
      HouseBuilder builder = new HouseBuilder();
      builder.BuildWindows(4).BuildDoors(2).BuildWalls(4);
      House house = builder.Build();
      Console.WriteLine($"Windows: {house.Windows}, Doors: {house.Doors}, Walls: {house.Walls}");
        
    }
}

public class House
{
    public int Windows { get; set; }
    public int Doors { get; set; }
    public int Walls { get; set; }
}

public class HouseBuilder
{
    private readonly House _house = new House();
    public HouseBuilder BuildWindows(int windows)
    {
        _house.Windows = windows;
        return this;
    }
    public HouseBuilder BuildDoors(int doors)
    {
        _house.Doors = doors;
        return this;
    }
    public HouseBuilder BuildWalls(int walls)
    {
        _house.Walls = walls;
        return this;
    }
    public House Build()
    {
        return _house;
    }
}

public interface IHouseBuilder
{
    HouseBuilder BuildWindows(int windows);
    HouseBuilder BuildDoors(int doors);
    HouseBuilder BuildWalls(int walls);
    House Build();
}
