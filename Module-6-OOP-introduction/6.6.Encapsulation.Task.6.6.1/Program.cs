using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._6.Encapsulation.Task._6._6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //Напишите класс светофор(TrafficLight) с 2 методами:
            //Закрытый метод ChangeColor, принимающий 1 строковый параметр color.
            //Открытый метод GetColor, который не принимает параметры, но выдает строковое значение цвета.
        }

        class TrafficLight
        {
           private string ChangeColor(string color)
            { 
                return color;
            }

            public string GetColor()
            {
                return "green";
            }


        }
    }
}
