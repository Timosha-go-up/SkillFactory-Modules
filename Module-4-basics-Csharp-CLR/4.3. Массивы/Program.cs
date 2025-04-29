using System;

namespace _4._3.Массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;


            Console.WriteLine("Задание 4.3.11");

            int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            {
                    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
                    Console.Write(array[k, i] + " ");       
            }
            for(int i = 0; i < n;i++) Console.WriteLine();



            Console.WriteLine("Задание 4.3.12");

            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            for (int i = 0;i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1; j++) if (arr[j] > arr[j+1])
                
                  (arr[j+1], arr[j]) = (arr[j], arr[j+1]);                           
            }

            for (int i = 0; i < arr.Length ; i++) Console.Write(arr[i]+" ");

            for (int i = 0; i < n; i++) Console.WriteLine();




            Console.WriteLine("Задание 4.3.13");

            var arr2 = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            int result = 0;

            for (int i = 0; i < arr2.Length; i++) result+=arr2[i];

            Console.Write(result);

            for (int i = 0; i < n; i++) Console.WriteLine();



            Console.WriteLine("Задание 4.3.14");

            int[][] array2 = new int[3][];

            array2[0] = new int[2] { 1, 2 };
            array2[1] = new int[3] { 1, 2, 3 };
            array2[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var num in array2)
            {
                foreach (var item in num)
                {
                    Console.Write(item + " ");
                }
            }
            for (int i = 0; i < n; i++) Console.WriteLine();



            Console.WriteLine("Задание 4.3.15");

            int[] arr3 = new int[] { 5, 6,-7,-45,8,-5,6,15 };
            int sum = 0;

            for (int i = 0; i < arr3.Length;i++) if (arr3[i] > 0) sum += 1;

            Console.Write(sum);

            for (int i = 0; i < n; i++) Console.WriteLine();



            Console.WriteLine("Задание 4.3.16");

            int[,] arr4 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int counter = 0;

            foreach(var item in arr4) if(item > 0) counter++;

            Console.Write(counter);

            for (int i = 0; i < n; i++) Console.WriteLine();



            Console.WriteLine("Задание 4.3.16");

            int[,] arr5 = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            Console.WriteLine("before sorting");

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)

                    Console.Write(arr5[i,j]+" ");

                Console.WriteLine();
            }

            

                Console.WriteLine();

            

                for (int i = 0; i < arr5.GetLength(0) ; i++)
                {
                   for (int j = 0; j < arr5.GetLength(1) - 1; j++)
                   { 
                       for (int k = 0; k < arr5.GetLength(1) - 1; k++) 

                       if (arr5[i,k] > arr5[i,k + 1])  (arr5[i,k + 1], arr5[i,k]) = (arr5[i,k], arr5[i,k + 1]);        
                   }
                }

                Console.WriteLine("after sorting") ;

            for (int i = 0; i < arr5.GetLength(0); i++)
            {
                for (int j = 0; j < arr5.GetLength(1); j++)

                    Console.Write(arr5[i, j] + " ");

                    Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
