class Ball : Toy
{
    private double diameter;
    private string color;

    public Ball(string name, decimal price, double diameter, string color) : base(name, price)
    {
        this.diameter = diameter;
        this.color = color;
    }

    public override string Play()
    {
        return "Игра с мячом";
    }

    public override string ShowInfo()
    {
        return base.ShowInfo() + "\nДиаметр: " + diameter + " см" + "\nЦвет: " + color;
    }
}