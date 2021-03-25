using System;

namespace OddAndEvenNymbers
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0; 
            uint evenNumbersCount = 0;

            int oddNumberSum = 0;
            int evenNumberSum = 0;

            Console.Write("Введите первое число: ");

            int currentValue = int.Parse(Console.ReadLine());

            Console.Write("Введите последнее число: ");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumberSum += currentValue;
                    evenNumbersCount++;
                }
                else
                {
                    oddNumberSum += currentValue;
                    oddNumbersCount++;
                }
                currentValue++;
            }

            Console.WriteLine("Количество нечётных чисел: " + oddNumbersCount);
            Console.WriteLine("Количество чётных чисел: " + evenNumbersCount);
            Console.WriteLine("Сумма нечётных чисел: " + oddNumberSum);
            Console.WriteLine("Сумма чётных чисел: " + evenNumberSum);
            Console.ReadLine();
        }
    }
}
