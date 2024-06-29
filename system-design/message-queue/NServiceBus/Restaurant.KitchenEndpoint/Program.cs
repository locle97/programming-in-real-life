// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kitchen is ready...");

var endpointConfiguration = new EndpointConfiguration("Kitchen");

endpointConfiguration.UseSerialization<SystemJsonSerializer>();

endpointConfiguration.UseTransport<LearningTransport>();

var endpointInstance = await Endpoint.Start(endpointConfiguration);

Console.ReadKey();

await endpointInstance.Stop();

public class CookCommandHandler : IHandleMessages<CookCommand>
{
    public async Task Handle(CookCommand message, IMessageHandlerContext context)
    {
        Console.WriteLine($"Cooking: {message.Item}");
        for (int i = 0; i < message.Quantity; i++)
        {
          foreach (var ingredient in message.Ingredients)
          {
            Console.WriteLine($"Adding: {ingredient.Name}");
            await Task.Delay(1000);
          }

          Console.WriteLine($"Cooked: {message.Item}");
        }
    }
}
