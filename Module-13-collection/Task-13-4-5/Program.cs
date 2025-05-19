using System.Diagnostics;

namespace Task_13_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            // Создаем сортированный словарь
            SortedDictionary<string, int> sortedDictionary = new();
            // Добавим несколько элементов в случайном порядке
            sortedDictionary.Add("zebra", 5);
            sortedDictionary.Add("cat", 2);
            sortedDictionary.Add("dog", 9);
            sortedDictionary.Add("mouse", 4);
            sortedDictionary.Add("programmer", 100);
            // Ищем собаку
            if (sortedDictionary.ContainsKey("dog"))
                Console.WriteLine("Нашли собаку");
            // Ищем зебру
            if (sortedDictionary.ContainsKey("zebra"))
                Console.WriteLine("Нашли зебру");
            // Ищем обезьяну
            if (sortedDictionary.ContainsKey("ape"))
                Console.WriteLine("Нашли обезьяну");

            Console.WriteLine();

            // Теперь посмотрим, кто у нас живёт и в каком порядке
            Console.WriteLine("Посмотрим всех:");

            foreach (KeyValuePair<string, int> p in sortedDictionary)

            Console.WriteLine($"{p.Key} = {p.Value}");

            sw.Stop();
            
            // смотрим, сколько операция заняла, в миллисекундах
            Console.WriteLine(sw.Elapsed);
        }
    }
}
