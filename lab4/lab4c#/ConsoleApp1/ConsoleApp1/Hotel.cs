public class Hotel
{
    private static Hotel instance;
    private string hotelName;
    private int availableRooms;
    private int occupiedRooms;
    private int totalRooms;
    private Tariff tariff;

    private Hotel(string name, int totalRooms, decimal dailyRate)
    {
        hotelName = name;
        this.totalRooms = totalRooms;
        availableRooms = totalRooms;
        occupiedRooms = 0;
        tariff = new Tariff(dailyRate);
    }

    public static Hotel GetInstance()
    {
        if (instance == null)
        {
            Console.Write("Введите название гостиницы: ");
            string name = Console.ReadLine();

            int totalRooms;
            while (true)
            {
                Console.Write("Введите общее количество комнат: ");
                if (int.TryParse(Console.ReadLine(), out totalRooms) && totalRooms > 0)
                    break;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            }

            int numberOfGuests;
            while (true)
            {
                Console.Write("Введите количество гостей для заселения: ");
                if (int.TryParse(Console.ReadLine(), out numberOfGuests) && numberOfGuests > 0 && numberOfGuests <= totalRooms)
                    break;
                else if (numberOfGuests > totalRooms)
                    Console.WriteLine("Недостаточное количество комнат. Пожалуйста, введите другое количество гостей.");
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            }

            decimal dailyRate;
            while (true)
            {
                Console.Write("Введите стоимость проживания за день: ");
                if (decimal.TryParse(Console.ReadLine(), out dailyRate) && dailyRate > 0)
                    break;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
            }
            instance = new Hotel(name, totalRooms, dailyRate);
            instance.CheckIn(numberOfGuests);
        }
        return instance;
    }

    public decimal CalculateTotalRevenue()
    {
        return tariff.CalculateTotalRevenue(occupiedRooms);
    }

    public void ChangeTariff(decimal newRate)
    {
        tariff.SetDailyRate(newRate);
    }

    public void CheckIn(int numberOfGuests)
    {
        if (numberOfGuests <= availableRooms)
        {
            occupiedRooms += numberOfGuests;
            availableRooms -= numberOfGuests;
            Console.WriteLine($"Успешное заселение {numberOfGuests} гостей.");
        }
        else
        {
            Console.WriteLine("Извините, нет достаточного количества свободных комнат.");
        }
    }

    public void CheckOut(int numberOfGuests)
    {
        if (numberOfGuests <= occupiedRooms)
        {
            occupiedRooms -= numberOfGuests;
            availableRooms += numberOfGuests;
            Console.WriteLine($"Выселение {numberOfGuests} гостей прошло успешно.");
        }
        else
        {
            Console.WriteLine("Недостаточное количество заселенных гостей.");
        }
    }

    public int GetTotalRooms()
    {
        return totalRooms;
    }

    public int GetOccupiedRooms()
    {
        return occupiedRooms;
    }

    public int GetNumberOfGuests()
    {
        return occupiedRooms;
    }
}