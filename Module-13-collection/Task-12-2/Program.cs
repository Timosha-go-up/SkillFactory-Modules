using System.Collections;
using static System.Console;

class MyClass
{

}


internal class Program
{
    private static void Main(string[] args)
    {
        var list = new ArrayList() { 2, "Lol", 12.2 };
        foreach (object o in list) WriteLine(o);
        WriteLine("Таким образом, в одном списке присутствуют объекты разных типов");
        WriteLine("=================================================================");


        WriteLine("Add(object value) Добавляет объект в список.");
        var arrayList = new ArrayList
        {


              1,
            "Чупакабра",
            new MyClass()
        };
        foreach (var item in arrayList) WriteLine(item);
        WriteLine();


        WriteLine("AddRange(ICollection col)  Добавляет в список все объекты переданной коллекции.");

        var strangeCreatures = new ArrayList();

        strangeCreatures.AddRange(new[]
        {
             "Чупакабра",
             "Лох-Несское Чудовище",
             "Снежный человек"
            });

        foreach (object o in strangeCreatures) WriteLine(o);





        ReadKey();
    }
}