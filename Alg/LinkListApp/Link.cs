using System;
using System.Collections.Generic;
using System.Text;

namespace LinkListApp
{
    class Link
    {
        public int iData; // Данные (ключ)
        public double dData; // Данные
        public Link next; // Следующий элемент в списке

        public Link(int id, double dd) // Конструктор
        {
            iData = id; // Инициализация данных
            dData = dd; // ('next' автоматически
        }               // присваивается null)

        public void displayLink() // Вывод содержимого элемента
        {
            Console.Write("{" + iData + ", " + dData + "} ");
        }
    }
}
