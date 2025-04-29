using System;


namespace _5._2.Method_Parameters
{
    internal class Program
    {
        static string ShowColor(string UserName,int UserAge)
        {
            Console.WriteLine(UserName +"  " + UserAge + "  \n" + "Напишите свой любимый цвет с маленькой буквы");
            var color = Console.ReadLine();
            return color;
        }

        static void Getcolor(string color)
        {
            switch (color)
            {
                case "red":

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your favorit color is :" + color);
                    DefaultColor();
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your favorit color is :" + color);
                    DefaultColor();
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Your favorit color is :" + color);
                    DefaultColor();
                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

        }

        static void GetcolorResult(string color)
        {
            switch (color)
            {
                case "red":

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Black;

                    break;

                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

        }

        static void DefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }



        static void Main(string[] args)
        {

            string[] FavColor = new string[3];

            (string Name, int Age) = ("Name", 0);

            Console.Write("Enter your name:  ");
            Name = Console.ReadLine();

            Console.Write("Enter your age in numbers:  ");
            Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Your name: {0}", Name);
            Console.WriteLine("Your age: {0}", Age);

            for (int i = 0; i < FavColor.Length; i++)
            {
                FavColor[i] = ShowColor(Name,Age);

                Getcolor(FavColor[i]);
            }

            Console.WriteLine("\n" + Name +" " + Age + "  " +"Your favorit colors are:");


            foreach (string color in FavColor)
            {
                GetcolorResult(color);
                Console.WriteLine(color);
            }


            for (int i = 0; i < 5; i++) Console.WriteLine();


            Console.ReadKey();

        }
    }
}
