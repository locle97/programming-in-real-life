// See https://aka.ms/new-console-template for more information
Console.WriteLine("Kitchen is ready...");

var endpointConfiguration = new EndpointConfiguration("Kitchen");

endpointConfiguration.UseSerialization<SystemJsonSerializer>();

endpointConfiguration.UseTransport<LearningTransport>();
endpointConfiguration.UsePersistence<LearningPersistence>();

var endpointInstance = await Endpoint.Start(endpointConfiguration);

Console.ReadKey();

await endpointInstance.Stop();

public class CookingPolicyData: ContainSagaData
{
  public Guid OrderId { get; set; }
  public string Item { get; set; }
  public int Quantity { get; set; }
  public List<Ingredient> Ingredients { get; set; }

  public bool OrderPlaced { get; set; }
  public bool IngredientsPrepared { get; set; }
}

public class CookingPolicy: Saga<CookingPolicyData>, IAmStartedByMessages<OrderPlaced>, IHandleMessages<IngredientsPrepared>
{
  protected override void ConfigureHowToFindSaga(SagaPropertyMapper<CookingPolicyData> mapper)
  {
    mapper.ConfigureMapping<OrderPlaced>(message => message.OrderId).ToSaga(saga => saga.OrderId);
    mapper.ConfigureMapping<IngredientsPrepared>(message => message.OrderId).ToSaga(saga => saga.OrderId);
  }

  public Task Cook(IMessageHandlerContext context)
  {
    if(Data.OrderPlaced && Data.IngredientsPrepared)
    {
      Console.WriteLine($"Cooked - {Data.OrderId}");
    }

    return Task.CompletedTask;
  }

    public Task Handle(OrderPlaced message, IMessageHandlerContext context)
    {
      Console.WriteLine($"Received order: {message.OrderId}");
      Data.OrderPlaced = true;
      Data.OrderId = message.OrderId;
      Data.Item = message.Item;
      Data.Quantity = message.Quantity;
      Data.Ingredients = message.Ingredients;

      return Cook(context);
    }

    public Task Handle(IngredientsPrepared message, IMessageHandlerContext context)
    {
      Console.WriteLine($"Received ingredient for {message.OrderId}");
      Data.IngredientsPrepared = true;

      return Cook(context);
    }
}
