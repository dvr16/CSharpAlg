using System;
using System.Collections.Generic;
using System.Text;

namespace InsertSortApp
{
    class ArrayIns
    {
        private long[] a; // Ссылка на массив a
        private int nElems; // Количество элементов данных
                            //--------------------------------------------------------------
        public ArrayIns(int max) // Конструктор
        {
            a = new long[max]; // Создание массива
            nElems = 0; // Пока нет ни одного элемента
        }
        //--------------------------------------------------------------
        public void insert(long value) // Вставка элемента в массив
        {
            a[nElems] = value; // Собственно вставка
            nElems++; // Увеличение размера
        }
        //--------------------------------------------------------------
        public void display() // Вывод содержимого массива
        {
            for (int j = 0; j < nElems; j++) // Для каждого элемента
                Console.Write(a[j] + " ");  // Вывод
            Console.WriteLine("");
        }

        public void insertionSort()
        {
            int _in, _out;
            for (_out = 1; _out < nElems; _out++) // out - разделительный маркер
            {
                long temp = a[_out]; // Скопировать помеченный элемент
                _in = _out; // Начать перемещения с out
                while (_in > 0 && a[_in - 1] >= temp) // Пока не найден меньший элемент
                {
                    a[_in] = a[_in - 1]; // Сдвинуть элемент вправо
                    --_in; // Перейти на одну позицию влево
                }
                a[_in] = temp; // Вставить помеченный элемент
            }
        }

        //--------------------------------------------------------------
    }
}

