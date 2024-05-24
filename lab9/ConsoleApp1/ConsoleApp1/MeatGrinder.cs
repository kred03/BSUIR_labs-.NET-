using System.Xml.Linq;

namespace _353505_Andrianov_9;

public class MeatGrinder : KitchenProcessor
{
    public MeatGrinder(string name, string type) : base(name, type) { }

    public override string GetInfo()
    {
        return $"{Name} - {Type} (Мясорубка)";
    }

    public override void Process()
    {
        Console.WriteLine("Перемалывание мяса...");
    }
}
