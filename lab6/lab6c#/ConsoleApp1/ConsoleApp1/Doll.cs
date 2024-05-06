class Doll : Toy
{
    private string material;
    private decimal size;

    public Doll(string name, decimal price, string material, decimal size) : base(name, price)
    {
        this.material = material;
        this.size = size;
    }

    public override string Play()
    {
        return "Игра с куклой";
    }

    public override string ShowInfo()
    {
        return base.ShowInfo() + "\nМатериал: " + material + "\nРазмер: " + size + " см";
    }
}