using System;


namespace Task._7._2._3
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                BaseClass baseClass = new BaseClass();

                baseClass.Display();

                DerivedClass derivedClass = new DerivedClass();

                derivedClass.Display();
            }



            //Реализуйте в классе BaseClass виртуальный метод Display с типом void и без параметров,который будет выводить сообщение "Метод класса BaseClass" в консоль,
            //а затем переопределите его в DerivedClass, чтобы он выводил сообщение "Метод класса DerivedClass".

            class BaseClass
            {
                public virtual void Display()
                {
                    Console.WriteLine("Метод класса BaseClass");
                }
            }

            class DerivedClass : BaseClass
            {
                public override void Display()
                {
                    base.Display();
                    Console.WriteLine("Метод класса DerivedClass");
                }
            }
    }
    
}
