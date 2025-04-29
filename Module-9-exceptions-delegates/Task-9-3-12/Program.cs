namespace Task_9_3_12
{
    internal class Program
    {
        
            delegate void ShowMessageDelegate(string _message);
            static void Main(string[] args)
            {
                  static void showMessageDelegate(string message) => Console.WriteLine(message);

                 showMessageDelegate("Hello World!");

                Console.Read();
            }

        
    }

       
}
