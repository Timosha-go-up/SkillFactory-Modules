namespace Task_13_3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>," +
               " учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            Console.WriteLine($"simbols in string {str.Length}");

            HashSet<char> UnicSimbols = [.. str];

            Console.WriteLine(UnicSimbols.Count);
            // сохраняем знаки препинания в массив Char
            var signs = new[] { ',', ' ', '.' };

            // сохраняем числовые символы в массив Char
            var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //  Проверяем, есть ли цифры
            bool containsNumbers = UnicSimbols.Overlaps(numbers);
            Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");

            // Отбрасываем знаки препинания и заново считаем
            UnicSimbols.ExceptWith(signs);
            Console.WriteLine($"Символов без знаков препинания:: {UnicSimbols.Count}");
        }
    }
}
