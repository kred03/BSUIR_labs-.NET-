using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        Console.WriteLine("Добро пожаловать в систему гостиницы!");

        while (true)
        {
            Console.WriteLine("""
                              Выберите действие: 
                              1. Добавить информацию о номере и его стоимости;
                              2. Зарегистрировать клиента и заказать номер;
                              3. Вывести список доступных номеров;
                              4. Вывести стоимость проживания клиента;
                              5. Выход
                              """ );
            Console.Write("Введите номер действия: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Введите номер комнаты: ");
                    int roomNumber;
                    while (!int.TryParse(Console.ReadLine(), out roomNumber) || !IsNumberValid(roomNumber))
                    {
                        Console.WriteLine("Ошибка: Некорректный ввод номера комнаты. Пожалуйста, введите положительное целое число.");
                        Console.Write("Введите номер комнаты: ");
                    }

                    Console.Write("Введите стоимость проживания: ");
                    decimal roomPrice;
                    while (!decimal.TryParse(Console.ReadLine(), out roomPrice))
                    {
                        Console.WriteLine("Ошибка: Некорректный ввод стоимости проживания. Пожалуйста, введите положительное целое число.");
                        Console.Write("Введите стоимость проживания: ");
                    }

                    hotel.AddRoom(roomNumber, roomPrice);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.Write("Введите фамилию клиента: ");
                    string clientLastName = Console.ReadLine();
                    Console.Write("Введите номер комнаты для заказа: ");
                    int clientRoomNumber;
                    while (!int.TryParse(Console.ReadLine(), out clientRoomNumber) || !IsNumberValid(clientRoomNumber))
                    {
                        Console.WriteLine("Ошибка: Некорректный ввод номера комнаты. Пожалуйста, введите положительное целое число.");
                        Console.Write("Введите номер комнаты для заказа: ");
                    }

                    if (hotel.RegisterClient(clientLastName, clientRoomNumber))
                        Console.WriteLine("Клиент успешно зарегистрирован и заказал номер.");
                    else
                        Console.WriteLine("Ошибка: Номер комнаты {0} недоступен.", clientRoomNumber);
                    Console.WriteLine();
                    break;
                case "3":
                    hotel.DisplayAvailableRooms();
                    Console.WriteLine();
                    break;
                case "4":
                    Console.Write("Введите фамилию клиента: ");
                    string clientLastNameBill = Console.ReadLine();
                    decimal clientBill = hotel.GetClientBill(clientLastNameBill);
                    if (clientBill >= 0)
                    {
                        Console.WriteLine("Стоимость проживания клиента {0}: {1:C}", clientLastNameBill, clientBill);
                    }
                    else
                    {
                        Console.WriteLine("Клиент с фамилией {0} не найден.", clientLastNameBill);
                    }
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("До свидания!");
                    return;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите номер действия от 1 до 5.");
                    Console.WriteLine();
                    break;
            }
        }
    }

    static bool IsNumberValid(int number)
    {
        return number > 0;
    }
}