namespace Task_9_1_4_TryCatchPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Собственное исключения");

            exception.HelpLink = "www.google.ru";
        }
    }
}
