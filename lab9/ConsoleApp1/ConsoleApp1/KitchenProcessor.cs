namespace _353505_Andrianov_9;

public abstract class KitchenProcessor : ICommonFunctions
{
    public string Name { get; set; }
    public string Type { get; set; }

    public KitchenProcessor(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public abstract string GetInfo();
    public abstract void Process();
}
