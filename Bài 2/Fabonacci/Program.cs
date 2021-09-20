using System;

namespace Fabonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("\tFabonacci");
            do
            {
                Console.Write("\nNhap n = ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0) Console.WriteLine("Hay nhap so nguyen duong. Moi nhap lai: ");
            } while (n <= 0);

            Console.WriteLine("{0} so Fabonacci dau tien la: ", n);
            for(int i = 1; i <= n; i++)
            {
                Console.Write(fabonacci(i) + " ");
            }

            Console.ReadLine();
        }

        static int fabonacci(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;
            else return fabonacci(n - 2) + fabonacci(n - 1);
        }

    }
}
