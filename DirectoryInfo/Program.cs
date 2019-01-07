using System;
using System.IO;

namespace Directory_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo info = new FileInfo("C:\\file.txt");
            FileAttributes attributes = info.Attributes;
            Console.WriteLine(attributes);
            
            info = new FileInfo("C:\\");
            attributes = info.Attributes;
            Console.WriteLine(attributes);

            //DirectoryInfo dir = info.Directory;
            //Console.WriteLine(dir.Name);

            string name = info.DirectoryName;
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
