namespace Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names =  {
               "Игорь",   // повторяющееся значение
               "Андрей",
               "Васиий",
               "София",
               "Елена",
               "Анна",
               "Игорь"  //  повторяющееся значение
           };

            // Выведем длину массива в консоль
            Console.WriteLine("Длина массива " + names.Length);
            Console.WriteLine();
            Console.WriteLine("Данные в массиве");
            foreach (var n in names)
            Console.WriteLine(n);
            Console.WriteLine();


            // Создаем хэш-сет, передавая в конструктор наш массив
            HashSet<string> hSet = [.. names];
            // Посчитаем объекты в массиве
            Console.WriteLine("Длина хэш-сета " + hSet.Count);
            Console.WriteLine();
            // Выведем все элементы в консоль и посмотрим, есть ли дубликаты
            Console.WriteLine("Элементы в хэшсете:");
            foreach (var n in hSet)
            Console.WriteLine(n);
            Console.WriteLine();    
            // UnionWith()Используется для объединения сета с другой коллекцией.
            hSet.UnionWith(["Дмитрий", "Сергей", "Игорь"]);

            Console.WriteLine("Элементы после объединения с новой коллекцией:");


           

            foreach (var n in hSet)
            Console.WriteLine(n);

           
        }
    }
}
