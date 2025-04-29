namespace IntrfacePractises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGarageManager<Car, Garage> garageManager = new GarageManagerBase();
            IGarageManager<Bike, Garage> garageManager2 = new GarageManagerBase();
            IGarageManager<Bike, House> garageManager3 = new GarageManagerBase();
        }

        
    }
    public class Car { }

    public class Bike : Car { }


    public class House { }
    public class Garage:House{ }

    public interface IGarageManager<in T,out Z>
    {
       Z GetGarageInfo();

            void Add(T car);
    }

    public class GarageManagerBase : IGarageManager<Car, Garage>
    {
        public void Add(Car car)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarageInfo()
        {
            throw new NotImplementedException();
        }
    }
}
