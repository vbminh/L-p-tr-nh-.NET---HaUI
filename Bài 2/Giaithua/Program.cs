using System;

namespace Giaithua
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("\tGiai thua");
            do
            {
                Console.Write("\nNhap n = ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0) Console.WriteLine("Hay nhap so nguyen duong. Moi nhap lai: ");
            } while (n <= 0);

            Console.WriteLine("Giai thua cua {0} là {1}", n, giaithua(n));
            Console.ReadLine();
        }

        static int giaithua(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            else return giaithua(n - 1) * n;
        }
    }
}
