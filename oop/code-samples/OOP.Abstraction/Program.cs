// See https://aka.ms/new-console-template for more information
House house = new Bungalow();
Console.WriteLine("[Bungalow]");
house.TurnOnLights();

house = new Duplex();
Console.WriteLine();
Console.WriteLine("[Duplex]");
house.TurnOnLights();

public abstract class House
{
    // Abstract method to turn on the lights
    public abstract void TurnOnLights();
}

public class Bungalow : House
{
    // Implementation of the abstract method for a bungalow
    public override void TurnOnLights()
    {
        Console.WriteLine("Turning on the lights in the bungalow.");
        Console.WriteLine("Turning on the lights in the living room.");
        Console.WriteLine("Turning on the lights in the kitchen.");
        // Details of how the lights are turned on in a bungalow are hidden
    }
}

public class Duplex : House
{
    // Implementation of the abstract method for a duplex
    public override void TurnOnLights()
    {
        Console.WriteLine("Turning on the lights in the duplex.");
        Console.WriteLine("Turning on the lights in the first unit.");
        Console.WriteLine("Turning on the lights in the second unit.");
        Console.WriteLine("Turning on the lights in the common areas.");
        // Details of how the lights are turned on in a duplex are hidden
    }
}
