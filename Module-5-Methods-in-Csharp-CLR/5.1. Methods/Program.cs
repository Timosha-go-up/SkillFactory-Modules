using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1.Methods
{
    internal class Program
    {
        static string ShowColor() 
        {
            Console.WriteLine("Напишите свой любимый цвет с маленькой буквы");
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

            for (int i = 0; i < FavColor.Length; i++)
            {               
                FavColor[i] = ShowColor();

                Getcolor(FavColor[i]);
            } 
              
            Console.WriteLine("\nYour favorit colors are:");


           foreach(string color  in FavColor) 
            {
                GetcolorResult(color);
                Console.WriteLine(color);
            }


            for (int i = 0; i < 5; i++) Console.WriteLine();


                Console.ReadKey();

        }
    }
}
