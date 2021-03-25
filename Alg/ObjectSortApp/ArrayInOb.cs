using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectSortApp
{
    class ArrayInOb
    {
        private Person[] a; // Ссылка на массив a
        private int nElems; // Количество элементов данных

        public ArrayInOb(int max) // Конструктор
        {
            a = new Person[max]; // Создание массива
            nElems = 0; // Пока нет ни одного элемента
        }

        // Включение записи в массив
        public void insert(String last, String first, int age)
        {
            a[nElems] = new Person(last, first, age);
            nElems++; // Увеличение размера
        }

        public void display() // Вывод содержимого массива
        {
            for (int j = 0; j < nElems; j++) // Для каждого элемента
                a[j].displayPerson(); // Вывод
            Console.WriteLine("");
        }


        public void insertionSort()
        {
            int _in, _out;
            for (_out = 1; _out < nElems; _out++) // _out - разделительный маркер
            {
                Person temp = a[_out]; // Скопировать помеченный элемент
                _in = _out; // Начать перемещения с _out
                while (_in > 0 && // Пока не найден меньший элемент
                a[_in - 1].getLast().CompareTo(temp.getLast()) > 0)
                {
                    a[_in] = a[_in - 1]; // Сдвинуть элемент вправо
                    --_in; // Перейти на одну позицию влево
                }
                a[_in] = temp; // Вставить помеченный элемент
            }
        }
    }
}
         
  
