using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task._8._1._4.@class.about.local.disk
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalDisk disk = new LocalDisk("C",60000,20000);
            
            Console.Write($"{disk.Name} {disk.Capacity} {disk.FreeSpice}\n"); 


           
           

            Console.ReadKey();
        }

        class LocalDisk
        {
            public  string Name    { get; }
            public   long Capacity { get; }
            public long FreeSpice  { get; }
            
           public Folder folder;

            public LocalDisk()
            {
                
                Name = "D";
                Capacity = 120000;
                FreeSpice = 50000;
               
               
            }

            public LocalDisk(string name, long capacity, long freespice)
            {
                Name = "Local Disk ";
                Name += name;
                Capacity = capacity;
                FreeSpice = freespice;               
            }

            public class Folder
            {
                public List<string> Files { get; set; } = new List<string>();

              

                Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

                public void CreateFolder(string name)
                {
                    Folders.Add(name, new Folder());
                }
            }

            //public class Folder1
            //{
            //    public Folder1(string name)
            //    {
            //        Name = name;
            //    }

            //    string Name { get; set; }
            //    List<string> Files { get; set; } = new List<string>();

            //    void AddFile(string name)
            //    {
            //        if (!Files.Contains(name))
            //            Files.Add(name);
            //    }
            //}

        }
    }
}
