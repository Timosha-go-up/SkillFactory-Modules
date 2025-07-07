namespace Task_14_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new Dictionary<string, string[]>
            {
                { "Apple", ["Mobile", "Desktop"] },
                { "Samsung", ["Mobile"] },
                { "IBM", ["Desktop"] }
            };
                                            // смотрим те из выборки, значения в которых содержат искомое
            var mobileCompanies = companies.Where(c => c.Value.Contains("Mobile"));
                                
            foreach (var company in mobileCompanies)
                Console.WriteLine(company.Key);
        }
    }
}
