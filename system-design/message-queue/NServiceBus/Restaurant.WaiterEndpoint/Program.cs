internal class Program
{
    private async static Task Main(string[] args)
    {
        Console.WriteLine("Waiter is ordering...");

        var endpointConfiguration = new EndpointConfiguration("Waiter");

        endpointConfiguration.UseSerialization<SystemJsonSerializer>();

        var transport = endpointConfiguration.UseTransport<LearningTransport>();
        var routing = transport.Routing();
        routing.RouteToEndpoint(typeof(OrderCommand), "OrderCounter");

        var endpointInstance = await Endpoint.Start(endpointConfiguration);

        while(true)
        {
          Console.WriteLine("Press 'Q' to quit, any other key to order.");
          var key = Console.ReadKey();
          if(key.Key == ConsoleKey.Q)
          {
            break;
          }


          Console.Write("Enter item: ");
          string item = Console.ReadLine();

          Console.Write("Enter quantity: ");
          int quan = int.Parse(Console.ReadLine());

          var command = new OrderCommand(){ 
            Item = item,
            Quantity = quan
          };
          await endpointInstance.Send(command);
        }

        await endpointInstance.Stop();
    }
}

