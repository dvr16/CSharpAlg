using System;

namespace LinkListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList theList = new LinkList(); // Создание нового списка
            theList.insertFirst(22, 2.99);     // Вставка четырех элементов
            theList.insertFirst(44, 4.99);
            theList.insertFirst(66, 6.99);
            theList.insertFirst(88, 8.99);

            theList.displayList();             // Вывод содержимого списка

            while (!theList.isEmpty()) // Пока остаются элементы,
            {
                Link aLink = theList.deleteFirst(); // Удаление элемента
                Console.Write("Deleted "); // Вывод удаленного элемента
                aLink.displayLink();
                Console.WriteLine("");
            }
            theList.displayList(); // Вывод содержимого списка
        }
    }

    }


