using System;
using System.Collections.Generic;
using System.Text;

namespace LinkStackApp
{
    class Link
    {
        public long dData; // Данные
        public Link next; // Следующий элемент в списке
                          // -------------------------------------------------------------
        public Link(long dd) // Конструктор
        { dData = dd; }
        // -------------------------------------------------------------
        public void displayLink() // Вывод содержимого элемента
        {
            Console.Write(dData + " "); 
        }
    }
}

