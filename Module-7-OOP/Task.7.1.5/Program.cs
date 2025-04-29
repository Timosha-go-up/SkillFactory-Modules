
global using System;

namespace Task._7._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //    Для следующего списка объектов создайте схему классов(объявите нужные классы и установите связи между ними) :
        //    Apple(яблоко);
        //    Banana(банан);
        //    Pear(груша);
        //    Potato(картофель);
        //    Carrot(морковь).
        //

        class Food { }
        class Fruit :Food { }


        class Apple : Fruit { }

        class Banana : Fruit { }

        class Pear : Fruit { }

        class Vegetable : Food { }

        class Potato : Vegetable { }

        class Carrot : Vegetable { }
    }

}
