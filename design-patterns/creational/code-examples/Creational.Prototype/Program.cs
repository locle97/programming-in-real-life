// This is an example of the Prototype design pattern in C#.

internal class Program
{
    private static void Main(string[] args)
    {
      House prototypeHouse = new House();
      prototypeHouse.Windows = 4;
      prototypeHouse.Doors = 2;
      prototypeHouse.Walls = 4;
      prototypeHouse.BedRoom = new Room();

      House realHouse1 = prototypeHouse.Clone();
      Console.WriteLine($"Clone Windows prototype to realHouse1");
      Console.WriteLine($"House 1: Windows: {realHouse1.Windows}, Doors: {realHouse1.Doors}, Walls: {realHouse1.Walls}, BedRoom: {realHouse1.BedRoom.Windows}");

      House realHouse2 = prototypeHouse.DeepClone();
      Console.WriteLine($"Clone Windows prototype to realHouse2");
      Console.WriteLine($"House 2: Windows: {realHouse2.Windows}, Doors: {realHouse2.Doors}, Walls: {realHouse2.Walls}, BedRoom: {realHouse2.BedRoom.Windows} ");
          

      prototypeHouse.BedRoom.Windows = 2;
      Console.WriteLine($"Change prototype bedRoom windows to 2");
      Console.WriteLine($"House 1: Windows: {realHouse1.Windows}, Doors: {realHouse1.Doors}, Walls: {realHouse1.Walls}, BedRoom: {realHouse1.BedRoom.Windows}");
      Console.WriteLine($"House 2: Windows: {realHouse2.Windows}, Doors: {realHouse2.Doors}, Walls: {realHouse2.Walls}, BedRoom: {realHouse2.BedRoom.Windows}");
    }
}

public class House
{
    public int Windows { get; set; }
    public int Doors { get; set; }
    public int Walls { get; set; }
    public Room BedRoom { get; set; }

    public House Clone()
    {
        return (House)MemberwiseClone();
    }

    public House DeepClone()
    {
      House house = (House)MemberwiseClone();
      house.BedRoom = BedRoom.Clone();
      return house;
    }
}

public class Room
{
    public int Windows { get; set; }
    public int Doors { get; set; }
    public int Walls { get; set; }
    public Room Clone()
    {
        return (Room)MemberwiseClone();
    }
}
