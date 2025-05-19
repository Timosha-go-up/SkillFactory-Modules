namespace Task_13_5_4
{
    internal class Program
    {
        public static Stack<string> words = new();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в стек.");
            Console.WriteLine();

            while (true)
            {
                var input = Console.ReadLine();
               
               
                
                switch (input)
                {
                    //   если  команда pop - пробуем достать элемент
                    case "pop":
                        words.TryPop(out string popResult);
                        break;
                    //   если  команда peek - пробуем  просмотреть элемент
                    case "peek":
                        Console.WriteLine(words.TryPeek(out string peekResult)); 
                        break;
                    default:
                        // если ни одна из команд не распознана - простов стек добавляем то что введено
                        words.Push(input);
                        break;
                }

                Console.WriteLine("\nВ стеке:");

               if(input!="peek") foreach (var word in words) Console.WriteLine(" " + word);
                
                Console.WriteLine("\n");
            }
        }
    }
}
