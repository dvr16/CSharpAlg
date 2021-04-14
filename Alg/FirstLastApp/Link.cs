using System;
using System.Collections.Generic;
using System.Text;

namespace FirstLastApp
{
    class Link
    {
        public long dData; // Данные
        public Link next; // Следующий элемент в списке

        public Link(long d) // Конструктор
        { 
            dData = d; 
        }

        public void displayLink() // Вывод содержимого элемента
        {
            Console.Write(dData + " "); 
        }
    }
}
