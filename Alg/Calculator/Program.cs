using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            double firstValue = double.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");

            string action;
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine($"Сумма этих чисел равна {firstValue + secondValue}");
                    break;
                case "-":
                    Console.WriteLine($"Разность этих чисел равна {firstValue - secondValue}");
                    break;
                case "*":
                    Console.WriteLine($"Произведение этих чисел равна {firstValue * secondValue}");
                    break;
                case "/":
                    Console.WriteLine($"Частное этих чисел равна {firstValue / secondValue}");
                    break;
                default:
                    Console.WriteLine("Такой операции не существует!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
