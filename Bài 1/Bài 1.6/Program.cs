using System;

namespace Bài_1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tCan bac hai cua so a voi do chinh xac n");
            Console.Write("Nhap so a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap do chinh xac n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ket qua la: {0}", dequy(a,n));
        }

        static double dequy(int a, int n)
        {
            if (n == 0) return 1;
            else
                return (((a / dequy(a, n - 1)) + dequy(a, n - 1)) / 2);
        }
    }
}
