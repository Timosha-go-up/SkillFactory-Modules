namespace Task_8_3_2_output_program_cs_add_data_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new FileInfo("C:\\Users\\Roman-PC\\source\\repos\\SkillFactory-Modules\\Module-8--Work-with_files\\Task-8-3-2-output-program-cs-add-data-time\\Program.cs");

            using (StreamWriter sw = fileInfo.AppendText())
            {
                sw.WriteLine($"// Время запуска: {DateTime.Now}");
            }

            using (StreamReader sr = fileInfo.OpenText())
            {
                string ? str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);

            }

            Console.ReadKey();
        }
    }
}
// Время запуска: 5/8/2025 5:42:16 PM
// Время запуска: 5/8/2025 5:44:02 PM
// Время запуска: 5/8/2025 5:44:06 PM
// Время запуска: 5/8/2025 5:46:53 PM
// Время запуска: 5/8/2025 10:06:48 PM
// Время запуска: 5/8/2025 10:07:45 PM
