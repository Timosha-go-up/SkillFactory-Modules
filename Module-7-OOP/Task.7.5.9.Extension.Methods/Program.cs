using System;


namespace Task._7._5._9.Extension.Methods
{ 
   
    static class intExtensions 
    {
        public static int GetNegative(this int negative) 
        {
            if (negative > 0) return negative *-1;
            else return negative;
        }
        public static int GetPositive(this int positive)
        {
            if (positive > 0) return positive;
            else return positive ;
        }

    }


    class Program
    {
      

        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = -13;
            int num3 = 0;

            Console.WriteLine(num1.GetNegative()); //-7
            Console.WriteLine(num1.GetPositive()); //7
            Console.WriteLine(num2.GetNegative()); //-13
            Console.WriteLine(num2.GetPositive()); //13
            Console.WriteLine(num3.GetNegative()); //0
            Console.WriteLine(num3.GetPositive()); //0

        }


    }
}
