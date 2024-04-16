public class Tariff
{
    public decimal DailyRate { get; private set; }

    public Tariff(decimal rate)
    {
        SetDailyRate(rate);
    }

    public void SetDailyRate(decimal rate)
    {
        DailyRate = rate;
    }

    public decimal CalculateTotalRevenue(int occupiedRooms)
    {
        return DailyRate * occupiedRooms;
    }
}