using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._4.Кортежи
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var anketa = (name: "Jane", age: 27);

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //Console.WriteLine("Ваше имя: {0}", anketa.Item1);
            //Console.WriteLine("Ваш возраст: {0}", anketa.Item2);

            //(string name, int age) anketa;

            //Console.Write("Your name : ");
            //anketa.name =  Console.ReadLine();

            //Console.Write("Your age : ");
            //anketa.age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your name : " + anketa.name + "\n" + "Your age : " + anketa.age);




            (string Name, string Type, double Age, int NameCount) Pet;

            string[] description = new string[] { "Pet's name : ", "Type of pet : ", "Pet's age : ", "Length of pet's name : " };




            Console.Write(description[0]);
            Pet.Name = Console.ReadLine();
            description[0] += Pet.Name;

            Console.Write(description[1]);
            Pet.Type = Console.ReadLine();
            description[1] += Pet.Type;

            Console.Write(description[2]);
            Pet.Age = double.Parse(Console.ReadLine());
            description[2] += Pet.Age;

            Console.WriteLine();
            
            Pet.NameCount = Pet.Name.Length;
            description[3] += Pet.NameCount;

            for (int i = 0; i < description.Length; i++) Console.WriteLine(description[i]);
            


        }
    }
}
