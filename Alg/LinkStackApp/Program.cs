using System;

namespace LinkStackApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkStack theStack = new LinkStack(); // Создание стека

            theStack.push(20); // Вставка элементов
            theStack.push(40);
            theStack.displayStack(); // Вывод содержимого стека
            theStack.push(60); // Вставка элементов
            theStack.push(80);
            theStack.displayStack(); // Вывод содержимого стека
            theStack.pop(); // Извлечение элементов
            theStack.pop();
            theStack.displayStack(); // Вывод содержимого стека
        }
    }
}
