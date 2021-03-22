using System;
using System.Collections.Generic;
using System.Text;

namespace OrderedApp
{
    class OrdArray
    {
        private long[] a;         // Ссылка на массив
        private int nElems;       // Количество элементов данных

        public OrdArray(int max)  // Конструктор
        {
            a = new long[max];    // Создание массива
            nElems = 0;
        }

        public int size() 
        {
            return nElems;
        }

        public int find(long searchKey)
        {
            int lowBound = 0;
            int upperBound = nElems - 1;
            int curIn;

            while (true)
            {
                curIn = (lowBound + upperBound) / 2;
                if (a[curIn] == searchKey)
                    return curIn;                     // Элемент найден
                else if (lowBound > upperBound)  
                    return nElems;                    // Элемент не найден
                else                                  // Деление диапазона
                {
                    if (a[curIn] < searchKey)

                        lowBound = curIn + 1;         // В верхней половине
                    else
                        upperBound = curIn - 1;       // В нижней половине
                    
                }
            }
        }

        public void insert(long value)          // Вставка элемента в массив
        {
            int j;
            for (j = 0; j < nElems; j++)        // Определение позиции вставки
                if (a[j] > value)               // (линейный поиск)
                    break;
            for (int k = nElems; k > j; k--)    // Перемещение последующих элементов
                a[k] = a[k - 1];
            a[j] = value;                       // Вставка
            nElems++;                           // Увеличение размера
        }

        public bool delete(long value)
        {
            int j = find(value);
            if (j == nElems)                          // Найти не удалось
                return false;
            else                                      // Элемент найден
            {
                for (int k = j; k < nElems; k++)      // Перемещение последующих элементов
                    a[k] = a[k + 1];
                nElems--;                             // Уменьшение размера
                return true;
            }
        }

        public void display()                // Вывод содержимого массива
        {
            for (int j = 0; j < nElems; j++) // Пепебор всех элементов
                Console.Write(a[j] + " ");   // Вывод текущего элемента
            Console.WriteLine("");
        }
    }
}
