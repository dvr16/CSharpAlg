using System;
using System.Collections.Generic;
using System.Text;

namespace LinkListApp
{
    class LinkList
    {
        private Link first;    // Ссылка на первый элемент списка

        public LinkList()      // Конструктор
        {
            first = null;      // Список пока не содержит элементов
        }

        public bool isEmpty()  // true, если список пуст
        {
            return (first == null);
        }

        public void insertFirst(int id, double dd)
        {                         // Создание нового элемента
            Link newLink = new Link(id, dd);
            newLink.next = first; // newLink --> старое значение first
            first = newLink;      // first --> newLink
        }

        public Link deleteFirst() // Удаление первого элемента
        {                         // (предполагается, что список не пуст)
            Link temp = first;    // Сохранение ссылки
            first = first.next;   // Удаление: first-->ссылка на второй элемент
            return temp;          // Метод возвращает ссылку на удаленный элемент
        }

        public void displayList()
        {
            Console.Write("List (first-->last): ");
            Link current = first;       // От начала списка
            while (current != null)     // Перемещение до конца списка
            {
                current.displayLink();  // Вывод данных
                current = current.next; // Переход к следующему элементу
            }
            Console.WriteLine("");
        }
    }
}
