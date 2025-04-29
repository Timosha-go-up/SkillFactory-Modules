using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3.Transmitting_parameters_Task5._3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 6;
            GetArrayFromConsole(ref size);
        }

        static int[] GetArrayFromConsole( ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

           
            foreach (int i in result) Console.Write(i + " ");

            return result;
        }

       static void GetAge(in string Name, in byte Age)
        {
           
        }
    }
}
