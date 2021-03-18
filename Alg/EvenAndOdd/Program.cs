using System;

namespace EvenAndOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Введите целое число: ");

            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("число четное");
            }
            else
            {
                Console.WriteLine("число нечетное");
            }

            Console.ReadLine();
        }
    }
}
