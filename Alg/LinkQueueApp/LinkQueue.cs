using System;
using System.Collections.Generic;
using System.Text;

namespace LinkQueueApp
{
    class LinkQueue
    {
        private FirstLastList theList;
        
        public LinkQueue() // Конструктор
        { 
            theList = new FirstLastList(); 
        } // Создание 2-стороннего списка
                                           
        public bool isEmpty() // true, если очередь пуста
        { 
            return theList.isEmpty(); 
        }
        
        public void insert(long j) // Вставка элемента в конец очереди
        { 
            theList.insertLast(j); 
        }
        
        public long remove() // Удаление элемента в начале очереди
        { 
            return theList.deleteFirst(); 
        }

        public void displayQueue()
        {
            Console.Write("Queue (front-->rear): ");
            theList.displayList();
        }
    }
}
