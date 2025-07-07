namespace Task_15_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(Average(num));
        }

        static double Average(int[] numbers)
        {          
            return numbers.Sum() / (double)numbers.Length;
        }
    }
}
