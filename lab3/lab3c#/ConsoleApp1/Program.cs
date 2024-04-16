using System;

class Program
{
    static void Main(string[] args)
    {
        NumberOperations operations = new NumberOperations();

        while (true)
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            double inputNumber;
            if (!double.TryParse(input, out inputNumber))
            {
                Console.WriteLine("Ошибка ввода. Необходимо ввести число.");
                continue;
            }

            double modifiedNumber = operations.ModifyNumber(inputNumber);
            Console.WriteLine("Модифицированное число: " + modifiedNumber);

            Console.WriteLine("Выберите действие: ");
            Console.WriteLine("1. Продолжить\t2. Закончить");

            string choice;
            bool validChoice = false;

            while (!validChoice)
            {
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        validChoice = true;
                        break;
                    case "2":
                        validChoice = true;
                        return;
                    default:
                        Console.WriteLine("Ошибка ввода. Введите 1 или 2.");
                        break;
                }
            }
        }
    }
}