namespace Task._7._1._7
{
    internal class Program
    {
        class SmartHelper
        {
            private string name;

            public SmartHelper(string name)
            {
                this.name = name;
            }

            public void Greetings(string name)
            {
               Console.WriteLine("Привет, {0}, я интеллектуальный помощник {1}",name,this.name);
            }
        }
        
            static void Main(string[] args)
            {
                SmartHelper helper = new SmartHelper("Олег");

                helper.Greetings("Грег");

                Console.ReadKey();
            }

        
    }
}
