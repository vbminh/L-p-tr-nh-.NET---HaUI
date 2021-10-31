using System;
using System.Threading;
using System.IO;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Nguyen Ha Trang";
            string name;

            Console.Write("\nNhap ten ngiu ban: ");
            do
            {
                name = Console.ReadLine();
                if (String.Compare(str, name, false) != 0)
                {
                    Console.Write("\nSai ten ngiu roi (>.<) Nhap lai nao:  ");
                    name = Console.ReadLine();
                }
            } while (String.Compare(str, name, false) != 0);
            
            for(int i = 0; i <= 100; i+= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\nLoading.......{0}%", i);
                Console.ResetColor();
                Thread.Sleep(150);

                if(i == 100)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n......Hoan thanh......\n");
                    Console.ResetColor();
                }
                    
            }
            int Count = 0;
            using (StreamReader sr = new StreamReader("emiu.txt"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(line);
                    Console.ResetColor();
                    Thread.Sleep(50);
                    Count++;
                }
            }

            for(int i = Count; i >= 0; i--)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(50);
            }

            Console.ReadKey();
        }
    }
}
