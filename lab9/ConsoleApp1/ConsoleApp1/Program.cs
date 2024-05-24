#define BUILDER

using _353505_Andrianov_9;
using System.Threading;

#if BUILDER
class Program
{
    static void Main(string[] args)
    {
        KitchenProcessorBuilder builder = new KitchenProcessorBuilder();

        List<KitchenProcessor> processors = new List<KitchenProcessor>
        {
            builder.SetName("Шинковка1").SetType("Настольный").BuildChopper(),
            builder.SetName("Мясорубка1").SetType("Ручной").BuildMeatGrinder(),
            builder.SetName("Процессор1").SetType("Встроенный").BuildMultiFunctionalProcessor()
        };

        foreach (var processor in processors)
        {
            Console.WriteLine(processor.GetInfo());
            processor.Process();

            if (processor is IMixer mixer)
            {
                mixer.Mix();
            }

            if (processor is IBlender blender)
            {
                blender.Blend();
            }

            if (processor is ITestomeshalka testomeshalka)
            {
                testomeshalka.KneadDough();
            }

            Console.WriteLine();
        }
    }
}

#else
class Program
{
    static void Main(string[] args)
    {
        IKitchenProcessorFactory factory = new KitchenProcessorFactory();

        List<KitchenProcessor> processors = new List<KitchenProcessor>
        {
            factory.CreateChopper("Шинковка1", "Настольный"),
            factory.CreateMeatGrinder("Мясорубка1", "Ручной"),
            factory.CreateMultiFunctionalProcessor("Процессор1", "Встроенный")
        };

        foreach (var processor in processors)
        {
            Console.WriteLine(processor.GetInfo());
            processor.Process();

            if (processor is IMixer mixer)
            {
                mixer.Mix();
            }

            if (processor is IBlender blender)
            {
                blender.Blend();
            }

            if (processor is ITestomeshalka testomeshalka)
            {
                testomeshalka.KneadDough();
            }

            Console.WriteLine();
        }
    }
}
#endif