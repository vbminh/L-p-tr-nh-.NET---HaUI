using System;

namespace Bài_1._5
{
    class Program
    {
        static int n, S;
        static double P;

        static void Main(string[] args)
        {
            Console.WriteLine("\nTinh tong");
            do
            {
                Console.Write("Nhap so nguyen duong n: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0) Console.WriteLine("Khong thoa man. Moi nhap lai: ");
            } while (n <= 0);

            for(int i = 1; i < n; i++)
            {
                S += i;
                P += 1 / i;
            }

            Console.WriteLine("Tong so nguyen duong tu 1 den n la {0}", S);
            Console.WriteLine("Tong so nguyen duong tu 1 den 1/n la {0}", P);

            Console.ReadLine();
        }
    }
}
