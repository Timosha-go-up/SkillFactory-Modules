using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._7._1._5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Obj obj = new Obj();

            Obj obj1 = new Obj("Ivan","Is from Russia");

        }
        class Obj
        {
            private string name;
            private string description;

            public Obj()
            {
                name = "Michael";
                description = "Is from Canada";
                Console.WriteLine("Вызван конструктор без параметров\t" + name +" "+ description);
            }

            public Obj(string name, string description) : this()
            {
                this.name = name;
                this.description = description;

                Console.WriteLine("Вызван конструктор с параметрами\t"+this.name+"\t"+this.description);
            }
        }
    }
}
