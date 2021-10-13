using System;
using System.IO;

namespace DemoDocFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("D:/Practice/Source/student.txt");
            while (sr.Peek()!=-1)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
                
            }
            sr.Close();

            Console.ReadLine();
        }
    }
}
