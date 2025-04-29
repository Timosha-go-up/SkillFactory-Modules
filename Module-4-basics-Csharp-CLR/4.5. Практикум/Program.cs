using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._5.Практикум
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Задание 4.5.1");

            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User;


            // Console.WriteLine("Задание 4.5.2");

            for(int i = 0;i < 3;i++)  
            {
                Console.WriteLine("Введите имя");

                User.Name = Console.ReadLine();

                Console.WriteLine("Введите фамилию");

                User.LastName = Console.ReadLine();

                Console.WriteLine("Введите логин");

                User.Login = Console.ReadLine();


                //  Console.WriteLine("Задание 4.5.3");

                User.LoginLength = User.Login.Length;


                // Console.WriteLine("Задание 4.5.4");

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                if (Console.ReadLine() == "Да") User.HasPet = true;

                else User.HasPet = false;


                //  Console.WriteLine("Задание 4.5.5");

                Console.WriteLine("Введите возраст пользователя");

                User.Age = double.Parse(Console.ReadLine());


                User.favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int j = 0; j < User.favcolors.Length; j++) User.favcolors[i] = Console.ReadLine();

            }
        }
    }
}
