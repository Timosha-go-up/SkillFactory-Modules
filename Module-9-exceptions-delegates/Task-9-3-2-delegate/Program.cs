namespace Task_9_3_2_delegate

    //здесь также задача 9-3-3
{
   using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            SubD subdel = Sub;

            WriteLine(subdel.Invoke(18, 6));
            WriteLine(subdel(18, 6));
        }


        static int Sub(int a,int b)
        {
            return a - b;
        }

        delegate int SubD(int a,int b);
    }
}
