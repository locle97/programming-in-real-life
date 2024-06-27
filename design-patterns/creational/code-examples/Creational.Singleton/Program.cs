// This is a simple example of a Singleton pattern in C#.

internal class Program
{
    private static void Main(string[] args)
    {
      BluePrint instance1 = BluePrint.GetInstance();
      instance1.Model = "X";
      Console.WriteLine($"Instance 1: {instance1.Model}");

      BluePrint instance2 = BluePrint.GetInstance();
      Console.WriteLine("Change the model of instance 2 to Y");
      instance2.Model = "Y";

      Console.WriteLine($"Instance 1: {instance1.Model}");
      Console.WriteLine($"Instance 2: {instance2.Model}");

      BluePrint instance3 = BluePrint.GetInstance();
      BluePrint instance4 = BluePrint.GetInstance();
      Console.WriteLine($"Instance 3: {instance3.Model}");
      Console.WriteLine($"Instance 4: {instance4.Model}");
    }
}

public class BluePrint
{
  private static BluePrint? _instance;
  public string Model { get; set; } = "X";

  private BluePrint()
  {
  }

  public static BluePrint GetInstance(){
    if(_instance == null){
      _instance = new BluePrint();
    }
    return _instance;
  }

  public static BluePrint Instance
  {
    get
    {
      if (_instance == null)
      {
        _instance = new BluePrint();
      }
      return _instance;
    }
  }

}
