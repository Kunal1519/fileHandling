using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileHandling
{
    public class FileWrite
    {

        public void FileWriting()
        {
            Directory.CreateDirectory(@"C:\Users\HP\OneDrive\Documents\Kunal(Projects)\FileHandling");
            string Files = @"C:\Users\HP\OneDrive\Documents\Kunal(Projects)\FileHandling\Write.txt";
            StreamWriter sw = new StreamWriter(Files,true);
            Console.WriteLine("\nEnter What ever you want to write in the File : ");
            sw.WriteLine(Console.ReadLine());
            sw.Close();
        }

        public void FileReader()
        {
            string Files = @"C:\Users\HP\OneDrive\Documents\Kunal(Projects)\FileHandling\Write.txt";
            StreamReader sw = new StreamReader(Files);
            Console.WriteLine("\n This is ReadToEnd");
            Console.WriteLine(sw.ReadToEnd());
            sw.Close();
        }
    }
}
