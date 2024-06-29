// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

var endpointConfiguration = new EndpointConfiguration("Storage");

endpointConfiguration.UseSerialization<SystemJsonSerializer>();

endpointConfiguration.UseTransport<LearningTransport>();

var endpointInstance = await Endpoint.Start(endpointConfiguration);

Console.WriteLine("Press Enter to exit...");
Console.ReadKey();

await endpointInstance.Stop();

public class OrderPlacedHandler : IHandleMessages<OrderPlaced>
{
    public async Task Handle(OrderPlaced message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Storage received order {message.OrderId}");
        for(int quan = 0; quan < message.Quantity; quan++)
        {
          foreach (var ingredient in message.Ingredients)
          {
              for(int i = 0; i < ingredient.Quantity; i++)
              {
                await Task.Delay(2000);
                Console.WriteLine($"Preparing: {ingredient.Name}");
              }
          }
        }

        var ingredientsPrepared = new IngredientsPrepared() {
          OrderId = message.OrderId,
        };
        await context.Publish(ingredientsPrepared);
    }
}
