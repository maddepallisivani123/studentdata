using System;
using System.IO;

namespace fileoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileDemo();
        }
        static void FileDemo()
        {
            String dir = Directory.GetCurrentDirectory();
            String filename = dir + "\\data.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine(filename + " exists");
            }
            else
            {
                Console.WriteLine(filename + " does not exist");
                using (StreamWriter wrt = File.CreateText(filename))
                {
                    wrt.WriteLine("student name= m.sivani");
                    wrt.WriteLine("class=10");
                    wrt.WriteLine("percentage=99");
                    wrt.WriteLine("rollno=12433");
                }
                Console.WriteLine(filename + " created");
            }
            string text = File.ReadAllText(filename);
            Console.WriteLine(text);
        }
    }
}
