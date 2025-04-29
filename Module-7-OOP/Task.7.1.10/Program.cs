using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task._7._1._10
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        class BaseClass
        {
            protected string Name;

            public BaseClass(string name)
            {
                Name = name;
            }
        }

        class DerivedClass : BaseClass
        {
            public string Description;

            public int Counter;

            public DerivedClass(string name,string description) : base(name)
            {
                Description = description;
            }
            public DerivedClass(string name,string description,int counter) : this(name,description) 
            {
                Counter = counter;
            }

            //  Для класса DerivedClass создайте 2 конструктора:
            //  один, принимающий 2 параметра — name и description,
            //  второй — принимающий 3 параметра name, description и counter.
        }
    }
}
