namespace ExceptWith_otherCollection_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создадим два множества
            SortedSet<char> lettersOne = [];
            SortedSet<char> lettersTwo = [];

            //  Добавим элементы в первую
            lettersOne.Add('A');
            lettersOne.Add('B');
            lettersOne.Add('C');
            lettersOne.Add('Z');

            // выведем
            PrintCollection(lettersOne, "Первая коллекция: ");

            // Добавим элементы во вторую
            lettersTwo.Add('X');
            lettersTwo.Add('Y');
            lettersTwo.Add('Z');

            // выведем
            PrintCollection(lettersTwo, "Вторая коллекция");

            //  Выполним вычитание множеств
            lettersOne.ExceptWith(lettersTwo);

            // Выведем результат
            PrintCollection(lettersOne, "Результат вычитания");
          
        }

        static void PrintCollection(SortedSet<char> ss, string s)
        {
            Console.WriteLine(s);
            foreach (char ch in ss)
                Console.Write(ch + " ");
            Console.WriteLine("\n");
        }
    }
}
