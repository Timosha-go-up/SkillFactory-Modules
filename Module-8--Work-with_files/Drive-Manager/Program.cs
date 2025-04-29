namespace Drive_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип:\t  {drive.DriveType}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем:\t  {drive.TotalSize}");
                    Console.WriteLine($"Свободно: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка:\t {drive.VolumeLabel}");
                }
            }
        }
    }
}
