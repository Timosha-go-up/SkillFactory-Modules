using System;

namespace _5._5.Recursive_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Напишите что-то");
            // var str = Console.ReadLine();

            // Console.WriteLine("Укажите глубину эха");
            // var deep = int.Parse(Console.ReadLine());

            //// Echo(str, deep);
            ///
            Console.WriteLine(PowerUp(2, 3));

            Console.ReadKey();
        }

        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

           Console.BackgroundColor = (ConsoleColor)deep;

            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {

                if (pow == 1)
                {
                    return N;

                }
                else
                {
                    return N * PowerUp(N, --pow);

                }
            }
        }
    }
}
