
using System;

class Program
{
    static void Main()
    {
        bool endProgram = false;
        while (!endProgram)
        {

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1. Получить день недели для введенной даты\t2. Определить количество дней до введенной даты");
            string choice_1 = Console.ReadLine();
            // Попробуем получить день недели для введенной даты
            switch (choice_1)
            {
                case "1":
                    Console.Write("Введите дату (формат дд.мм.гггг): ");
                    string inputDate = Console.ReadLine();
                    try
                    {
                        string dayOfWeek = DateService.GetDay(inputDate);
                        Console.WriteLine($"День недели для введенной даты: {dayOfWeek}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case "2":

                    // Попробуем определить количество дней до введенной даты

                    Console.Write("Введите день: ");
                    //int day = Convert.ToInt32(Console.ReadLine());
                    int day;
                    try
                    {
                        day = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                        continue;
                    }

                    Console.Write("Введите месяц: ");
                    int month;
                    try
                    {
                        month = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                        continue;
                    }

                    Console.Write("Введите год: ");
                    int year;
                    try
                    {
                        year = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                        continue;
                    }

                    try
                    {
                        int daysSpan = DateService.GetDaysSpan(day, month, year);
                        Console.WriteLine($"Количество дней до даты {day}.{month}.{year}: {daysSpan}");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова.");
                    break;
            }
            bool validChoice = false;
            while (!validChoice)
            {
                Console.WriteLine("Выберите действие: ");
                Console.WriteLine("1. Продолжить\t2. Закончить");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        validChoice = true;
                        break;
                    case "2":
                        endProgram = true;
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, попробуйте снова.");
                        break;
                }
            }
        }
    }
}
