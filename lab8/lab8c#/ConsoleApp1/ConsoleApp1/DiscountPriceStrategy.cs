public class DiscountPriceStrategy : IPriceStrategy
{
    public double Discount { get; set; }

    public DiscountPriceStrategy(double discount)
    {
        Discount = discount;
    }

    public double CalculatePrice(Room room)
    {
        return room.Price * (1 - Discount / 100);
    }
}