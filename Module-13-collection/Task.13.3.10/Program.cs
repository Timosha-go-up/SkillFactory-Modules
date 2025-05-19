namespace Task._13._3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Подсчитайте, сколько уникальных символов в этом предложении, используя HashSet<T>," +
                " учитывая знаки препинания, но не учитывая пробелы в начале и в конце предложения.";

            Console.WriteLine(str.Length);

            HashSet<char> UnicSimbols = [.. str];

            Console.WriteLine(UnicSimbols.Count);
        }
    }
}
