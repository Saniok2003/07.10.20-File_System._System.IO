using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            do
            {
                Console.Clear();
                DirectoryInfo dir = new DirectoryInfo(path);

                Console.WriteLine("Directory: \t{0}", dir.FullName);
                Console.WriteLine("CreationTime: {0}", dir.CreationTime);
                Console.WriteLine("Extension: {0}", dir.Extension);
                Console.WriteLine("LastAccessTime: {0}", dir.LastAccessTime);
                Console.WriteLine("LastWriteTime: {0}", dir.LastWriteTime);
                Console.WriteLine("Name: {0}", dir.Name);

                Console.WriteLine("Directories ----------------------");
                foreach (var d in dir.GetDirectories())
                {
                    Console.WriteLine($"Directory: {d.Name}  time:  {d.CreationTime} atr: {d.Attributes}");
                }
                Console.WriteLine("Files --------------------------");
                foreach (var file in dir.GetFiles())
                {
                    Console.WriteLine($"File: {file.Name}  time:  {file.CreationTime} atr: {file.Attributes}");
                }

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(path + @"\");
                string next = Console.ReadLine();
                Console.ResetColor();

                path = Path.Combine(path, next);
            } while (true);
        }
        
    }
}

