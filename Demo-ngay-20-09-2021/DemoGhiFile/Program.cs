using System;
using System.IO;
namespace DemoGhiFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dsSoNguyen = new int[] { 2, 4, 6, 7, 8 };

            StreamWriter sw = new StreamWriter(@"E:\test.txt");
            foreach (var item in dsSoNguyen)
            {
                sw.WriteLine(item); 
            }
            sw.Close();
        }
    }
}
