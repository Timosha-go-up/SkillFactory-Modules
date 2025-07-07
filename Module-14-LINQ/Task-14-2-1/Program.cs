namespace Task_14_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = ["Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха"];

            var wordsInfo = words.Select(w => new { Name = w, w.Length}).OrderBy(word => word.Length); 

                // Выборка в анонимный тип

                // Длину слова сохраняем сразу в свойство нового анонимного типа
          
           //  сортируем коллекцию по длине


            // выводим
            foreach (var word in wordsInfo)
            Console.WriteLine($"{word.Name} - {word.Length} букв");
        }
    }
}
