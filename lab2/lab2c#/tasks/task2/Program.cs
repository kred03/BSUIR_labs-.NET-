using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите координату x:");
            double x;
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            Console.WriteLine("Введите координату y:");
            double y;
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите число.");
            }

            double angle = Math.Atan2(y, x);

            if (Math.Abs(x) > 15 || Math.Abs(y) > 15 || x < 0 || y < 0)
            {
                Console.WriteLine("Нет");
            }
            else if ((y == x && x < 15) || y == -x || (x == 0 && y == 15) || (x * x + y * y == 225 && x == y))
            {
                Console.WriteLine("На границе");
            }
            else if (angle >= Math.PI / 4 && angle <= 3 * Math.PI / 4)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Продолжить");
            Console.WriteLine("2. Закончить");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    continue;
                case "2":
                    return;
                default:
                    Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте снова.");
                    break;
            }
        }
    }
}
