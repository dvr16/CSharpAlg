using System;

namespace ObjectSortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxSize = 100; // Размер массива
            ArrayInOb arr; // Ссылка на массив
            arr = new ArrayInOb(maxSize); // Создание массива
            arr.insert("Evans", "Patty", 24);
            arr.insert("Smith", "Lorraine", 37);
            arr.insert("Yee", "Tom", 43);
            arr.insert("Adams", "Henry", 63);
            arr.insert("Hashimoto", "Sato", 21);
            arr.insert("Stimson", "Henry", 29);
            arr.insert("Velasquez", "Jose", 72);
            arr.insert("Lamarque", "Henry", 54);
            arr.insert("Vang", "Minh", 22);
            arr.insert("Creswell", "Lucinda", 18);
            Console.WriteLine("Before sorting:");
            arr.display(); // Вывод содержимого
            arr.insertionSort(); // Сортировка методом вставки
            Console.WriteLine("After sorting:");
            arr.display(); // Повторный вывод
        }
    }
}
