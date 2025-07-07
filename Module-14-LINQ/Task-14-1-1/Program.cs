namespace Task_14_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>
            {
                new("Москва", 11900000),
                new("Санкт-Петербург", 4991000),
                new("Волгоград", 1099000),
                new("Казань", 1169000),
                new("Севастополь", 449138)
            };

            var bigCities = russianCities.Where(c => c.Name.Length > 10).OrderBy(c => c.Name.Length);

            foreach (var city in bigCities)  Console.WriteLine(city.Name + "   " + city.Population); 
  
        }
    }

    public class City(string name, long population)
    {
        public string Name { get; set; } = name;
        public long Population { get; set; } = population;
    }
}
