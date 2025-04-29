namespace Task_9_1_3_TryCatchPractices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Exception exception = new Exception();

            exception.Data.Add("Дата создания исключения : ", DateTime.Now);
        }
    }
}
