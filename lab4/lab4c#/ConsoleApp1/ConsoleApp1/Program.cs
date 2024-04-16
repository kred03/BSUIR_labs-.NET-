using System;
public class Program
{
    public static void Main()
    {
        Hotel hotel = Hotel.GetInstance();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1. Заселить гостя");
            Console.WriteLine("2. Выселить гостя");
            Console.WriteLine("3. Количество комнат");
            Console.WriteLine("4. Количество гостей");
            Console.WriteLine("5. Изменить тариф");
            Console.WriteLine("6. Рассчитать общую выручку");
            Console.WriteLine("0. Выйти");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        int guestsToCheckIn;
                        while (true)
                        {
                            Console.Write("Введите количество гостей для заселения: ");
                            if (int.TryParse(Console.ReadLine(), out guestsToCheckIn) && guestsToCheckIn > 0)
                                break;
                            else
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
                        }
                        hotel.CheckIn(guestsToCheckIn);
                        break;
                    case 2:
                        int guestsToCheckOut;
                        while (true)
                        {
                            Console.Write("Введите количество гостей для выселения: ");
                            if (int.TryParse(Console.ReadLine(), out guestsToCheckOut) && guestsToCheckOut > 0)
                                break;
                            else
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
                        }
                        hotel.CheckOut(guestsToCheckOut);
                        break;
                    case 3:
                        int occupiedRooms = hotel.GetOccupiedRooms();
                        Console.WriteLine("Количество комнат: " + occupiedRooms);
                        break;
                    case 4:
                        int numberOfGuests = hotel.GetNumberOfGuests();
                        Console.WriteLine("Количество людей: " + numberOfGuests);
                        break;
                    case 5:
                        decimal newRate;
                        while (true)
                        {
                            Console.Write("Введите новую стоимость проживания за день: ");
                            if (decimal.TryParse(Console.ReadLine(), out newRate) && newRate > 0)
                                break;
                            else
                                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
                        }
                        hotel.ChangeTariff(newRate);
                        break;
                    case 6:
                        decimal totalRevenue = hotel.CalculateTotalRevenue();
                        Console.WriteLine("Общая выручка гостиницы: $" + totalRevenue);
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, выберите опцию из списка.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный выбор. Пожалуйста, выберите опцию из списка.");
            }

            Console.WriteLine();
        }
    }
}