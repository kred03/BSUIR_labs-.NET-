public class Hotel
{
    private List<Room> rooms = new List<Room>();
    private List<Client> clients = new List<Client>();

    public void AddRoom(int roomNumber, decimal roomPrice)
    {
        if (!IsRoomNumberDuplicate(roomNumber))
        {
            rooms.Add(new Room { Number = roomNumber, Price = roomPrice });
            Console.WriteLine("Успешное добавление номера комнаты.");
        }
        else
        {
            Console.WriteLine("Ошибка: Номер комнаты {0} уже существует.", roomNumber);
        }
    }

    public bool RegisterClient(string clientLastName, int roomNumber)
    {
        if (IsRoomAvailable(roomNumber))
        {
            clients.Add(new Client { LastName = clientLastName, RoomNumber = roomNumber });
            return true;
        }
        return false;
    }

    public void DisplayAvailableRooms()
    {
        Console.WriteLine("Доступные номера:");
        foreach (Room room in rooms)
        {
            if (!IsRoomOccupied(room.Number))
            {
                Console.WriteLine("Номер комнаты: {0}, Стоимость проживания: {1:C}", room.Number, room.Price);
            }
        }
    }

    public decimal GetClientBill(string clientLastName)
    {
        foreach (Client client in clients)
        {
            if (client.LastName == clientLastName)
            {
                Room room = GetRoomByNumber(client.RoomNumber);
                if (room != null)
                {
                    return room.Price;
                }
                return -1;
            }
        }
        return -1;
    }

    private bool IsRoomOccupied(int roomNumber)
    {
        foreach (Client client in clients)
        {
            if (client.RoomNumber == roomNumber)
            {
                return true;
            }
        }
        return false;
    }

    private Room GetRoomByNumber(int roomNumber)
    {
        foreach (Room room in rooms)
        {
            if (room.Number == roomNumber)
            {
                return room;
            }
        }
        return null;
    }

    private bool IsRoomAvailable(int roomNumber)
    {
        foreach (Room room in rooms)
        {
            if (room.Number == roomNumber)
            {
                return !IsRoomOccupied(roomNumber);
            }
        }
        return false;
    }

    private bool IsRoomNumberDuplicate(int roomNumber)
    {
        foreach (Room room in rooms)
        {
            if (room.Number == roomNumber)
            {
                return true;
            }
        }
        return false;
    }
}