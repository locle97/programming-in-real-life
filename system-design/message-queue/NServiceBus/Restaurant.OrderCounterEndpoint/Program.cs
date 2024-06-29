// See https://aka.ms/new-console-template for more information
internal class Program
{
    private async static Task Main(string[] args)
    {
        Console.WriteLine("Order counter is ordering...");

        var endpointConfiguration = new EndpointConfiguration("OrderCounter");

        endpointConfiguration.UseSerialization<SystemJsonSerializer>();

        var transport = endpointConfiguration.UseTransport<LearningTransport>();
        var routing = transport.Routing();
        routing.RouteToEndpoint(typeof(OrderPlaced), "Kitchen");

        var endpointInstance = await Endpoint.Start(endpointConfiguration);

        Console.ReadKey();

        await endpointInstance.Stop();
    }
}

public class OrderHandler: IHandleMessages<PlaceOrder>
{
    public async Task Handle(PlaceOrder message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Item: {message.Item}, Quantity: {message.Quantity}");
        Console.WriteLine("Checking availability...");
        await Task.Delay(1000);

        Console.WriteLine($"Order {message.OrderId} checked.");

        OrderPlaced orderPlaced = new OrderPlaced {
          OrderId = message.OrderId,
          Item = message.Item,
          Quantity = message.Quantity,
          Ingredients = new List<Ingredient> { 
            new Ingredient { Name = "Flour", Quantity = 1 },
            new Ingredient { Name = "Sugar", Quantity = 2 }
          }
        };
        await context.Publish(orderPlaced);
    }
}
