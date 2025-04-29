using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3.Transmitting_parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            (string Name, int Age) = ("Vasia", 30);

            Console.WriteLine(Name);
            Console.WriteLine(Age +" yars");

            GetName(Name);

            Console.WriteLine(Name);
            Console.WriteLine(Age);

            ChangeAge(ref Age);

            Console.WriteLine(Age);

            Console.ReadKey();
        }

        static void GetName(string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
        }

        static void ChangeAge(ref int Age)
        {
            Console.WriteLine($"Enter your age");

            Age = int.Parse(Console.ReadLine());   
        }
    }
}
