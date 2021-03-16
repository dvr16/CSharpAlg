using System;

namespace SumAndMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third;

            Console.Write("Введите первое число: ");
            first = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            second = double.Parse(Console.ReadLine());

            Console.Write("Введите третье число: ");
            third = double.Parse(Console.ReadLine());

            double sum = first + second + third;
            double mult = first * second * third;

            Console.WriteLine($"Сумма трех этих чисел равно {sum}");
            Console.WriteLine($"Произведение трех этих чисел равно {mult}");

            Console.ReadLine();
        }
    }
}
