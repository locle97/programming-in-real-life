// This is an example of encapsulation in C#
// In SmartHouseVille, Mr. Encapsulate was a renowned architect who designed houses with secret blueprints. 
// These blueprints included detailed plans for the electrical system, plumbing, and foundation. 
// Only specific builders could access these sections, ensuring that the construction was secure and well-organized.
// See https://aka.ms/new-console-template for more information
var blueprints = new Blueprints();
blueprints.ElectricalSystem = "Electrical System Blueprint";
blueprints.Plumbing = "Plumbing Blueprint";
blueprints.Foundation = "Foundation Blueprint";

Console.WriteLine(blueprints.ElectricalSystem);

public class Blueprints
{
    private string _electricalSystem;
    private string _plumbing;
    private string _foundation;
    public string ElectricalSystem
    {
        get { return _electricalSystem; }
        set { _electricalSystem = value; }
    }
    public string Plumbing
    {
        get { return _plumbing; }
        set { _plumbing = value; }
    }
    public string Foundation
    {
        get { return _foundation; }
        set { _foundation = value; }
    }
}
