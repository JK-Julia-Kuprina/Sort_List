using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> link = new LinkedList<string>(); // Создаем связный список
            
            link.AddFirst("Alena"); // Добавляем несколько элементов
            link.AddFirst("Dima");
            link.AddFirst("Boris");
            link.AddFirst("Dasha");

            LinkedListNode<string> node; // Выводим список в прямом направлении
            Console.WriteLine("Наш список: ");
            for (node = link.First; node != null; node = node.Next)
                Console.Write(node.Value + "\t");

            Console.WriteLine("\nСписок в обратном направлении: "); // Выводим список в обратном направлении
            for (node = link.Last; node != null; node = node.Previous)
                Console.Write(node.Value + "\t");

            
        }
    }
}
