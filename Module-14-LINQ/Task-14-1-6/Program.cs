namespace Task_14_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
            {
             new[] {2, 3, 7, 1},
             new[] {45, 17, 88, 0},
             new[] {23, 32, 44, -6},
            };

            var orderedNums = numsList.SelectMany(s => s).OrderBy(s => s);
            // выводим
            foreach (var ord in orderedNums)
            Console.WriteLine(ord);
        }
    }
}
