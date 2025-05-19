using BenchmarkDotNet.Running;

namespace Task_12_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var summary = BenchmarkRunner.Run<Testing>();
        }
    }
}
