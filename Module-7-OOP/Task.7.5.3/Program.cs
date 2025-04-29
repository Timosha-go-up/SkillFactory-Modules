using System;
 
namespace Task._7._5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 15;
            int two = 30;
            Helper.Swap(ref one,ref two);

            Console.WriteLine(one);
            Console.WriteLine(two);

        }

        //  Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.
        //int num1 = 3;
        //int num2 = 58;

        //Helper.Swap();
        ///*передача num1 и num2 в метод*/
        
        //     Console.WriteLine(num1); //58
        // Console.WriteLine(num2);      //3


        class Helper
        {
            static public void Swap(ref int one,ref int two) 
            {
                (one, two) = (two, one);
            }
        }


    }
}
