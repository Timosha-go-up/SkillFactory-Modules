using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3.Transmitting_parameters_Task5._3._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 0, 3, 2, 7, 1 };
            int[] arr2 = new int [arr.Length];

            Console.WriteLine();

            int[] arr3 = new int[arr.Length];
            SortArray(in arr,out arr2,out arr3);

            
        }

        static void SortArray(in int[] array,out int[]sortArrayAsc, out int[]sortArrayDesc)
        {
            sortArrayAsc = SortArrayAsc(array);
            Console.WriteLine();
            sortArrayDesc = SortArrayDesc(array);                     
        }
       

        static int[] SortArrayDesc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] < array[j + 1]) (array[j + 1], array[j]) = (array[j], array[j + 1]);

            foreach (int i in array) Console.Write(i + " ");

            return array;
        }

        static int[] SortArrayAsc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = 0; j < array.Length - 1; j++)
                    if (array[j] > array[j + 1]) (array[j + 1], array[j]) = (array[j], array[j + 1]);

            foreach (int i in array) Console.Write(i + " ");

            return array;
        }
    }
}
