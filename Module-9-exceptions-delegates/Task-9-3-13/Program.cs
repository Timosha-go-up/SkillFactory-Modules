namespace Task_9_3_13
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate =() =>   new Random().Next(0, 100);
           
            int result = randomNumberDelegate.Invoke();

            Console.WriteLine(result);

            Console.Read();
        }

    }
}
