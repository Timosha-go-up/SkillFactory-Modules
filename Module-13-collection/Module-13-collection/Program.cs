using static System.Net.Mime.MediaTypeNames;

namespace Module_13_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\Roman-PC\\source\\repos\\SkillFactory-Modules\\Module-13-collection\\cdev_Text.txt";

            var fileInfo = new FileInfo(path);

            using StreamReader sr = fileInfo.OpenText();
            var str = sr.ReadToEnd();

            string[] ArrayString = str.Split([' ','\n','\r'], StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(ArrayString.Length);
           
        }
    }
}