using System;

class Program
{
    static void Main(string[] args)
    {
        Operations operations = new Operations();

        while (true)
        {
            double inputNumber; // Объявляем переменную до использования в TryParse

            Console.Write("Введите z: ");
            string input = Console.ReadLine();

            if (!double.TryParse(input, out inputNumber))
            {
                Console.WriteLine("Ошибка ввода. Необходимо ввести число.");
                continue;
            }

            double y = Math.Log(inputNumber + 0.5) + (Math.Pow(Math.E, inputNumber) - Math.Pow(Math.E, -inputNumber));

            double modifiedNumber = operations.ModifyNumber(inputNumber);

            Console.WriteLine("Результат: " + modifiedNumber);
            Console.WriteLine("Номер ветки: " + operations.BranchNumber);

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