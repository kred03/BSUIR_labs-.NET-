public class NoDiscount : IPrice
{
    private double price;

    public NoDiscount(double price)
    {
        this.price = price;
    }

    public double GetPrice()
    {
        return price;
    }
}