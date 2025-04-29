namespace Task_8_3_1_output_program_cs
{
    class FileWriter
    {
        public static void Main()
        {
            string filePath = @"C:\Users\ohago\source\repos\SkillFactoty\Modules\Module-8--Work-with_files\Task-8-3-1-output-program-cs\Program.cs"; // Укажем путь

            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string ? str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }
    }
}
// Время запуска: 3/2/2025 12:26:10 AM
// Время запуска: 3/2/2025 12:26:32 AM
// Время запуска: 3/2/2025 12:27:09 AM
// Время запуска: 3/2/2025 12:27:51 AM
// Время запуска: 3/2/2025 12:28:11 AM
// Время запуска: 3/6/2025 12:08:43 AM
// Время запуска: 3/6/2025 12:08:52 AM
