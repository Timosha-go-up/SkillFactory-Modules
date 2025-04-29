using System.Data;

namespace ConsoleApp2
{
    internal class Program
    {
        delegate int Delegsum(int x,int y);
        static void Main(string[] args)
        {
            Delegsum  delegsum  = (int a , int b) => a + b * 2;
            

            Console.WriteLine(delegsum(5, 5));
        } 
      
    }

   
}
