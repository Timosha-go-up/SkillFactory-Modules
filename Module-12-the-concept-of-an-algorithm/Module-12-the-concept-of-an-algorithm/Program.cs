internal class Program
{
    private static void Main(string[] args)
    {
        var array = Enumerable.Range(1,10).ToArray();

        Console.WriteLine(BinarySearch(7,array));
       
    }
    static int BinarySearch(int value, int[] array)
    {
        if (array[array.Length / 2] == value) return value;

        else if (array[array.Length / 2] < value)
        {
            for (int i = array.Length / 2; i < array.Length; i++) if (array[i] == value) return i;
        }
        else  for (int i = 0; i < array.Length/2; i++) if (array[i] == value) return i;  
                  
       return -1;                
    }

    
}