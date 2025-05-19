namespace Task_13_1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new FileInfo("C:\\Users\\Roman-PC\\source\\repos\\SkillFactory-Modules\\Module-8--Work-with_files\\Task-8-3-2-output-program-cs-add-data-time\\Program.cs");

           

            using (StreamReader sr = fileInfo.OpenText())
            {
                string? str;
                while ((str = sr.ReadLine()) != null)

                Console.WriteLine(str);

            }

            Console.ReadKey();

        }
    }
}
