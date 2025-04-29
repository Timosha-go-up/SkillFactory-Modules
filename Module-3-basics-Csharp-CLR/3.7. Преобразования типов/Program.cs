using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._7.Преобразования_типов
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
           
            int age;

            Console.Write("Enter your age: ");

            try
            {
               age = int.Parse(Console.ReadLine());    
            }
            catch (Exception)
            {
                age = -1;
            }

            Console.Write("Enter your birthdate :"); 
            string Birthdate = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(" Your name is \t\t{0} \n Your age is \t\t{1} \n Your birthdate is \t{2}", name, age,Birthdate);

            Console.ReadKey();
        }
    }
}
