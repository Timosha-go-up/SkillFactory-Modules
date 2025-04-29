namespace Task_9_3_4
{
    // here is also task 9.3.5

    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcDel testdel = Sub;
            testdel +=Add;

            testdel.Invoke(10, 5);

            WriteLine();

            testdel -= Add;

            testdel.Invoke(10, 5);

        }


        static void Sub(int a, int b)
        {
           WriteLine( a - b);
        }

        static void Add(int a, int b) 
        {
            WriteLine(a + b);
        }

        delegate void CalcDel(int a, int b);
    }
}
