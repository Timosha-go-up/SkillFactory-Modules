using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2._8
{
    internal class Program
    {
       static int[] ShowArray(int[] arr,bool sorted = false) 
        {
            if (!sorted)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }

            else
            {
                SortArray(arr);
            }
            return arr;
        }


        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static int[] SortArray(int[]array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1]) (array[j + 1], array[j]) = (array[j], array[j + 1]);

            foreach (int i in array) Console.Write(i + " ");

            return array;
        }




        static void Main(string[] args)
        {
            int[] result = GetArrayFromConsole(10);

           ShowArray(result,true);

            Console.ReadKey();
        }
    }
}
