namespace _353505_Andrianov_9
{
    public interface ICommonFunctions
    {
        string GetInfo();
        void Process();
    }

    public interface IMixer
    {
        void Mix();
    }

    public interface IBlender
    {
        void Blend();
    }

    public interface ITestomeshalka
    {
        void KneadDough();
    }

    public interface IKitchenProcessorFactory
    {
        KitchenProcessor CreateChopper(string name, string type);
        KitchenProcessor CreateMeatGrinder(string name, string type);
        KitchenProcessor CreateMultiFunctionalProcessor(string name, string type);
    }

}
