using System.Threading;
using System.Xml.Linq;
namespace _353505_Andrianov_9;

public class MultiFunctionalProcessor : KitchenProcessor, IMixer, IBlender, ITestomeshalka
{
    public MultiFunctionalProcessor(string name, string type) : base(name, type) { }

    public override string GetInfo()
    {
        return $"{Name} - {Type} (Многофункциональный)";
    }

    public override void Process()
    {
        Console.WriteLine("Процесс выполнения выбранной функции...");
    }

    public void Mix()
    {
        Console.WriteLine("Смешивание...");
    }

    public void Blend()
    {
        Console.WriteLine("Блендирование...");
    }

    public void KneadDough()
    {
        Console.WriteLine("Замешивание теста...");
    }
}
