namespace ConsoleApp1
{ 
   class Car
        {
            public string? Model { get; set; }
        }
        class BMW : Car { }


    internal class Program
    {     
        delegate Car CarDelegate(string name);
        static void Main(string[] args)
        {
            CarDelegate carDelegate;
            carDelegate = BuildBMW; // ковариантность
            Car c = carDelegate("X6");
            Console.WriteLine(c.Model);
            Console.Read();
        }
        private static BMW BuildBMW(string model)
        {
            return new BMW { Model = model };
        }
    }
}
