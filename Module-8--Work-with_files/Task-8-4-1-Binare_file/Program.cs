namespace Task_8_4_1_Binare_file
{
    internal class Program
    {

        public static void Main()
        {
            // сохраняем путь к файлу (допустим, вы его скачали на рабочий стол)
            string filePath = @"C:/Users/SkillFactoryTest/BinaryFile.bin";

            // при запуске проверим, что файл существует
            if (File.Exists(filePath))
            {
                // строковая переменная, в которую будем считывать данные
                string stringValue;

                // считываем, после использования высвобождаем задействованный ресурс BinaryReader
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    stringValue = reader.ReadString();
                }

                // Вывод
                Console.WriteLine("Из файла считано:");
                Console.WriteLine(stringValue);

               

            }
        }
    }
}
