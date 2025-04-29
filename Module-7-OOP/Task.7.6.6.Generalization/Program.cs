using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._7._6._6.Generalization
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        //Реализуйте класс-обобщение Record, у которого будут два универсальных параметра:
        //один — для идентификатора записи(Id), другой — для значения записи(Value). Также в классе реализуйте поле Date типа DateTime.

        class Record<T, T1> 
        {
            public DateTime Date;
        }
    }
}
