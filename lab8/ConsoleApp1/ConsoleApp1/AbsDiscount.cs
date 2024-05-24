public class AbsDiscount : IPrice
{
    private double price;
    private double discount;

    public AbsDiscount(double price, double discount)
    {
        this.price = price;
        this.discount = discount;
    }

    public double GetPrice()
    {
        return price - discount;
    }
}