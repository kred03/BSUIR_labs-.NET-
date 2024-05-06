abstract class Toy
{
    protected string name;
    protected decimal price;

    public Toy(string name, decimal price)
    {
        this.name = name;
        this.price = price;
    }

    public abstract string Play();

    public virtual string ShowInfo()
    {
        return "Название игрушки: " + name + "\nЦена: $" + price;
    }
}