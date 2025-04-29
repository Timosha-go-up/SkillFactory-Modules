namespace Task._8._4._2_add_text_in_binary_file
{
   
    class programm
    { 
        static string filePath = @"C:/Users/SkillFactoryTest/BinaryFile.bin";
        public static void Main()
        {
            WriteValues();
            ReadValues();
        }

        static void WriteValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Open)))
                writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
        }

        static void ReadValues()
        {
            string StringValue;

            if (File.Exists(filePath))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
                {
                    StringValue = reader.ReadString();
                }

                Console.WriteLine(StringValue);
            }
        }

    }
}
