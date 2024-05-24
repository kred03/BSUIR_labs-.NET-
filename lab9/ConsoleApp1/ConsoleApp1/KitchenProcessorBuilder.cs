namespace _353505_Andrianov_9;

internal class KitchenProcessorBuilder
{
    private string _name;
    private string _type;

    public KitchenProcessorBuilder SetName(string name)
    {
        _name = name;
        return this;
    }

    public KitchenProcessorBuilder SetType(string type)
    {
        _type = type;
        return this;
    }

    public KitchenProcessor BuildChopper()
    {
        return new Chopper(_name, _type);
    }

    public KitchenProcessor BuildMeatGrinder()
    {
        return new MeatGrinder(_name, _type);
    }

    public KitchenProcessor BuildMultiFunctionalProcessor()
    {
        return new MultiFunctionalProcessor(_name, _type);
    }
}
