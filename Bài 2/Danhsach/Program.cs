using System;

namespace Danhsach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list;
            int n;

            Console.WriteLine("\tDanh sach");
            do
            {
                Console.Write("\nNhap so phan tu cua danh sach: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0) Console.WriteLine("So phan tu phai lon hon 0. Moi nhap lai: ");
            } while (n <= 0);

            list = new int[n];

            Console.WriteLine("Nhap danh sach: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write("\nNhap phan tu thu {0}: ", (i + 1));
                list[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nDanh sach sau khi nhap : ");
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(list[i] + " ");
            }

            Console.Write("\n\nCac so chan la: ");

            for (int i = 0; i < n; i++)
            {
                if(list[i] % 2 == 0)
                    Console.Write(list[i] + " ");
            }

            Console.Write("\n\nCac so le la: ");

            for (int i = 0; i < n; i++)
            {
                if (list[i] % 2 != 0)
                    Console.Write(list[i] + " ");
            }

            Console.Write("\n\nCac so nguyen to la: ");

            for (int i = 0; i < n; i++)
            {
                if (Prime(list[i]))
                    Console.Write(list[i] + " ");
            }

            Console.ReadLine();
        }

        static bool Prime(int n)
        {
            if (n < 2) return false;
            for(int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
