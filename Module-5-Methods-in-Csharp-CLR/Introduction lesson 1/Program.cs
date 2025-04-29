using System;

namespace Introduction_lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name,string[] FavDishes)User;

            Console.WriteLine("Введите ваше имя");

           User.Name = Console.ReadLine();

            User.FavDishes = new string[5];

            for (int i = 0; i < User.FavDishes.Length; i++)
            {
                Console.WriteLine("Введите ваше любимое блюдо: " + (i + 1));
                User.FavDishes[i] = Console.ReadLine();
            }
            Console.ReadKey();
        }   
    }
}
