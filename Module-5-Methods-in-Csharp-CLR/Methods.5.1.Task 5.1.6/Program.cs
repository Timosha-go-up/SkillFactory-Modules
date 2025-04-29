using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods._5._1.Task_5._1._6
{
    internal class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < result.Length -1; i++)
             for (int j = 0; j < result.Length -1; j++)
              if (result[j] > result[j + 1]) (result[j + 1], result[j]) = (result[j], result[j + 1]);
                   
            foreach (int i in result) Console.Write(i + " ");

            return result;
        }



        static void Main(string[] args)
        {
            int[] result = GetArrayFromConsole();

            Console.ReadKey();  
        }
    }
}
