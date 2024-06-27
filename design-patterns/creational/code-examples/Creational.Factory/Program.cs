// This is a simple example of the Factory pattern in C#.

internal class Program
{
    private static void Main(string[] args)
    {
      var constructionCompany = new ConstructionCompany();
      var house = constructionCompany.BuildHouse(ConstructionCompany.HouseType.Wooden);
      Console.WriteLine(house.Build());

      house = constructionCompany.BuildHouse(ConstructionCompany.HouseType.Brick);
      Console.WriteLine(house.Build());
    }
}

public class ConstructionCompany
{
  public House BuildHouse(HouseType houseType)
  {
    switch (houseType)
    {
        case HouseType.Wooden:
            return new WoodenHouse();
        case HouseType.Brick:
            return new BrickHouse();
        default:
            throw new ArgumentOutOfRangeException(nameof(houseType), houseType, null);
    }
  }

  public enum HouseType
  {
    Wooden,
    Brick
  }

  public abstract class House
  {
    public abstract string Build();
  }

  public class WoodenHouse : House
  {
      public override string Build()
      {
        return "Cut the wood and build the house";
      }
    }

  public class BrickHouse : House
  {
    public override string Build()
    {
        return "Heat the bricks and build the house";
    }
  }
}
