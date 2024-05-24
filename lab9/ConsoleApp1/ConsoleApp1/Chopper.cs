namespace _353505_Andrianov_9;

public class Chopper : KitchenProcessor
{
    public Chopper(string name, string type) : base(name, type) { }

    public override string GetInfo()
    {
        return $"{Name} - {Type} (Шинковка)";
    }

    public override void Process()
    {
        Console.WriteLine("Шинковка...");
    }
}
