namespace Task_9_3_8_template_delegate
{
    internal class Program
    {

     
        static void Main(string[] args)
        {
            Action action = new Action (ShowMessage);

            action.Invoke();

           Func<int,int,int,int> sumDelegate = Sum;
            
            Console.WriteLine(sumDelegate.Invoke(1, 30, 120));

            Predicate<string>predicate = CheckLength;
            
            Console.WriteLine(predicate.Invoke("skill_factory"));

            Console.ReadLine();
        }

        static void ShowMessage()
        {
            Console.WriteLine("Hello World!");
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }

}
