public class Hotel
{
    private List<IRoom> rooms;

    public Hotel()
    {
        rooms = new List<IRoom>();
    }

    public void AddRoom(IRoom room)
    {
        rooms.Add(room);
    }

    public double GetAveragePrice()
    {
        return rooms.Average(room => room.GetPrice());
    }
}