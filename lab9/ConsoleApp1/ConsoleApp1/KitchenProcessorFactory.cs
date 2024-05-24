namespace _353505_Andrianov_9;

public class KitchenProcessorFactory : IKitchenProcessorFactory
{
    public KitchenProcessor CreateChopper(string name, string type)
    {
        return new Chopper(name, type);
    }

    public KitchenProcessor CreateMeatGrinder(string name, string type)
    {
        return new MeatGrinder(name, type);
    }

    public KitchenProcessor CreateMultiFunctionalProcessor(string name, string type)
    {
        return new MultiFunctionalProcessor(name, type);
    }
}
    