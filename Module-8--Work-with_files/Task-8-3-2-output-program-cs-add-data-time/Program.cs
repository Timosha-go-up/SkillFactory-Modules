namespace Task_8_3_2_output_program_cs_add_data_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileInfo = new FileInfo(@"C:\Users\ohago\source\repos\SkillFactoty\Modules\Module-8--Work-with_files\Task-8-3-1-output-program-cs\Program.cs");

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
