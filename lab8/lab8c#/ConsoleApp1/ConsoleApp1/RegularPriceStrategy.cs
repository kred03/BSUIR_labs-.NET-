public class RegularPriceStrategy : IPriceStrategy
{
    public double CalculatePrice(Room room)
    {
        return room.Price;
    }
}