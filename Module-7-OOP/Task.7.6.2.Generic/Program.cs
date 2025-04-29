using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Task._7._6._2.Generic  //здесь так-же задача 7.6.7
{
    class Program
    {
        static void Main(string[] args)
        {

            GasCar gasCar = new GasCar();

            Battery battery = new Battery();

            gasCar.ChangePart<Battery>(battery);

            

        }

        //7.6.2
        //Создайте класс-обобщение Car для автомобиля.Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый).
        //Для типов двигателей также создайте классы — ElectricEngine и GasEngine.
        //В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр 

        //7.6.7
        //Добавьте к схеме классов автомобиля следующие классы частей автомобиля:
        //Battery, Differential, Wheel.Также добавьте в класс Car виртуальный обобщённый метод без реализации — ChangePart,
        //который будет принимать один параметр — newPart универсального типа.


        // 7.6.9
       // Установите ограничения на универсальные типы в классе Car.Такие,
       // чтобы поле Engine могло принимать тип ElectricEngine и GasEngine,
       // а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).
      //Для этого вам может понадобиться использовать один из ранее изученных принципов ООП.


       

        abstract class Engine  { }
        class ElectricEngine : Engine {
            public ElectricEngine()
            {
                Console.WriteLine("Method ElectricEngine");
            }
        } 
        class GasEngine : Engine {
            public GasEngine()
            {
                Console.WriteLine("Method GasEngine");
            }
        }
      


         abstract class PartCar { }
        class Battery : PartCar { } 
        class Differential : PartCar { }
       class Wheel : PartCar { }



        abstract  class Car<TEngine> where TEngine :Engine 
        {
            protected TEngine Engine;
            public virtual void ChangePart<TPartCar>(PartCar newPart) where TPartCar:PartCar
            {
      
            }

        }

        class ElectricCar : Car<ElectricEngine> 
        {
            public ElectricCar()
            {
                Engine = new ElectricEngine();
            }

            public override void ChangePart<TPartCar>(PartCar newPart)
            {

            }
        }
        class GasCar : Car<GasEngine> 
        {
            public GasCar()
            {
                Engine = new GasEngine();
            }

            public override void ChangePart<TPartCar>(PartCar newPart)
            { 

            }
        }




    }
}
