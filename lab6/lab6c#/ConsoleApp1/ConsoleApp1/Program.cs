using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите данные для мяча:");
        Console.Write("Название: ");
        string ballName = Console.ReadLine();

        Console.Write("Цена: ");
        decimal ballPrice;
        while (!decimal.TryParse(Console.ReadLine(), out ballPrice) || ballPrice <= 0)
        {
            Console.WriteLine("Некорректный ввод. Введите положительное число для цены снова: ");
        }

        Console.Write("Диаметр: ");
        double ballDiameter;
        while (!double.TryParse(Console.ReadLine(), out ballDiameter) || ballDiameter <= 0)
        {
            Console.WriteLine("Некорректный ввод. Введите положительное число для диаметра снова: ");
        }

        Console.Write("Цвет: ");
        string ballColor = Console.ReadLine();

        Ball ball = new Ball(ballName, ballPrice, ballDiameter, ballColor);

        Console.WriteLine();

        Console.WriteLine("Введите данные для куклы:");
        Console.Write("Название: ");
        string dollName = Console.ReadLine();

        Console.Write("Цена: ");
        decimal dollPrice;
        while (!decimal.TryParse(Console.ReadLine(), out dollPrice) || dollPrice <= 0)
        {
            Console.WriteLine("Некорректный ввод. Введите положительное число для цены снова: ");
        }

        Console.Write("Материал: ");
        string dollMaterial = Console.ReadLine();

        Console.Write("Размер: ");
        decimal dollSize;
        while (!decimal.TryParse(Console.ReadLine(), out dollSize) || dollSize <= 0)
        {
            Console.WriteLine("Некорректный ввод. Введите положительное число для размера снова: ");
        }

        Doll doll = new Doll(dollName, dollPrice, dollMaterial, dollSize);

        Console.WriteLine();

        Console.WriteLine("Информация о мяче:");
        Console.WriteLine(ball.ShowInfo());
        Console.WriteLine(ball.Play());

        Console.WriteLine();

        Console.WriteLine("Информация о кукле:");
        Console.WriteLine(doll.ShowInfo());
        Console.WriteLine(doll.Play());

        Console.ReadLine();
    }
}
