namespace Task_13_3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {                       
            while (true)
            {
                //пишем что-нибудь в кансоль
                Console.WriteLine("Enter text");
                string str = Console.ReadLine()??"empty string";
                //выводим что ввели ск лавиатуры
                Console.WriteLine($"simbols in string {str.Length}");
                //получаем массив char с уникальными символами
                HashSet<char> UnicSimbols = [.. str];
                //выводлим массив char с уникальными символами
                Console.WriteLine($"unic simbols in string {UnicSimbols.Count}");
                // сохраняем числовые символы в массив Char
                var numbers = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                //  Проверяем, есть ли цифры
                bool containsNumbers = UnicSimbols.Overlaps(numbers);
                Console.WriteLine($"Коллекция содержит цифры: {containsNumbers}");
               // сохраняем знаки препинания в массив Char
               var signs = new[] { ',', ' ', '.' };
               // Отбрасываем знаки препинания и заново считаем
               UnicSimbols.ExceptWith(signs);
               Console.WriteLine($"Символов без знаков препинания:: {UnicSimbols.Count}");
            }
        }
    }
}
