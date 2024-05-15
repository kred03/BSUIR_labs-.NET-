public class Room : IRoom
{
    public string Number { get; set; }
    public double Price { get; set; }
    public IPriceStrategy PriceStrategy { get; set; }

    public Room(string number, double price, IPriceStrategy priceStrategy)
    {
        Number = number;
        Price = price;
        PriceStrategy = priceStrategy;
    }

    public double GetPrice()
    {
        return PriceStrategy.CalculatePrice(this);
    }
}