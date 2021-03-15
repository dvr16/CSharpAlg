using System;

namespace AVG
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstName, secondName;

            Console.Write("Введите первое число: ");
            firstName = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            secondName = double.Parse(Console.ReadLine());

            double result = (firstName + secondName) / 2;
            Console.WriteLine($"Среднее арифметическое значение равно {result}");

            Console.ReadLine();

        }
    }
}
