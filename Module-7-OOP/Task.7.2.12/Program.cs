namespace Task._7._2._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }

        class Obj
        {
            public int Value;

            public static Obj operator +(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value + b.Value
                };
            }
            public static Obj operator -(Obj a, Obj b)
            {
                return new Obj
                {
                    Value = a.Value - b.Value
                };
            }
        }
    }
}
