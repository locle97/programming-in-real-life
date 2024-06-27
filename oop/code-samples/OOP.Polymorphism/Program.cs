// See https://aka.ms/new-console-template for more information

House house = new();
house.Describe();

house = new Bungalow();
house.Describe();

house = new Duplex();
house.Describe();

house = new Villa();
house.Describe();

public class House
{
    public virtual void Describe()
    {
        Console.WriteLine("This is a standard house.");
    }
}

public class Bungalow : House
{
    public override void Describe()
    {
        Console.WriteLine("This is a bungalow with a single-story layout and a large porch.");
    }
}

public class Duplex : House
{
    public override void Describe()
    {
        Console.WriteLine("This is a duplex with two separate living units.");
    }
}

public class Villa : House
{
    public override void Describe()
    {
        Console.WriteLine("This is a villa with multiple floors, a swimming pool, and a garden.");
    }
}

