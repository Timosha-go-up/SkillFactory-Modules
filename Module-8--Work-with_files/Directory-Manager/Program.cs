using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory_Manager
{

    

    class Program
    {
        static void CatalogInfo(DirectoryInfo dirInfo)
        { 
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}"); 
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}"); Console.WriteLine($"Корневой каталог: {dirInfo.Root}\n");
        }

        static void DeleteFolder(string FolderName)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("C:\\" + FolderName);
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Каталог удален\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void MoveFolder( string path,string newpath)
        {
            
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);

                if (dirInfo.Exists && !Directory.Exists(newpath))
                    dirInfo.MoveTo(newpath);

                Console.WriteLine($"Папка успешно перемещена по пути  {newpath}");
            }
            catch (IOException exp)
            {
                Console.WriteLine(exp.Message);
            }
        }



        static void Main(string[] args)
        {           
            DirectoryInfo directory = new DirectoryInfo("C:\\");

            CatalogInfo(directory);

            GetCatalogs("C:\\"); //   Вызов метода получения директорий

            GetLengthFObject(directory);

            Newfile(directory, "NewFolder");

            GetLengthFObject(directory);

            DeleteFolder("NewFolder");

            GetLengthFObject(directory);

            Newfile(directory, "NewFolder");
            Newfile(directory, "Newfolder\\NewFolder");



            MoveFolder("C:\\NewFolder", "C:\\$RECYCLE.BIN");



            Console.ReadKey();

        }

        static void GetCatalogs(string NamePath)
        {
            string dirName = NamePath; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")

            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");

                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
                Console.WriteLine();
            }


        }
        static void GetLengthFObject(DirectoryInfo directoryInfo)
        {
            try
            {                
                if (directoryInfo.Exists)
                {
                    Console.WriteLine($"Количество обьектов {directoryInfo.GetDirectories().Length + directoryInfo.GetFiles().Length}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();

        }
        

         static void Newfile(DirectoryInfo directoryInfo,string FolderName)
         {                                            
            try
            {
                if (directoryInfo.Exists)
                {
                   directoryInfo.Create();

                   directoryInfo.CreateSubdirectory(FolderName);

                    Console.WriteLine("Каталог создан");


                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine();
         }

        

        

    }
}
