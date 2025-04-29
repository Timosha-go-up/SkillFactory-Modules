namespace Task_9_2_3_RankException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new RankException("Сообщение об ошибке");
            }

            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }

            finally
            {
                Console.Read();
            }
        }
    }
}
