using System;

namespace Task._7._5._2.StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Obj.MaxValue += 10;

            Console.WriteLine(Obj.MaxValue);
           
        }
       // Создайте класс Obj, определите в нем поля Name, Description(тип строки) и статическое поле MaxValue типа int, равное 2000.

        class Obj
        {
           
            public static int MaxValue = 2000;
           public string Name;

          public  string Description;

        }
    }
}
