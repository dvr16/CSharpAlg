using System;

namespace PriorityQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQ thePQ = new PriorityQ(5);
            thePQ.insert(30);
            thePQ.insert(50);
            thePQ.insert(10);
            thePQ.insert(40);
            thePQ.insert(20);

            while (!thePQ.isEmpty())
            {
                long item = thePQ.remove();
                Console.Write(item + " "); // 10, 20, 30, 40, 50
            }
            Console.WriteLine("");
        }
    }
}
