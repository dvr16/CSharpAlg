using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSortApp
{
    class ArrayBub
    {
        private long[] a; // Ссылка на массив a
        private int nElems; // Количество элементов данных

        public ArrayBub(int max) // Конструктор
        {
            a = new long[max]; // Создание массива
            nElems = 0; // Пока нет ни одного элемента
        }

        public void insert(long value) // Вставка элемента в массив
        {
            a[nElems] = value; // Собственно вставка
            nElems++; // Увеличение размера
        }

        public void display() // Вывод содержимого массива
        {
            for (int j = 0; j < nElems; j++) // Для каждого элемента
                Console.Write(a[j] + " ");
            Console.WriteLine("");

        }


        public void bubbleSort()
        {
            int _out, _in;
            for (_out= nElems - 1; _out> 1; _out--) // Внешний цикл (обратный)
for (_in= 0; _in<_out; _in++) // Внутренний цикл (прямой)
if (a[_in] > a[_in +1]) // Порядок нарушен?
                swap(_in, _in +1); // Поменять местами
        }

        private void swap(int one, int two)
        {
            long temp = a[one];
            a[one] = a[two];
            a[two] = temp;
        }
    }
}

