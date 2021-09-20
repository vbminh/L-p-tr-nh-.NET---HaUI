using System;

namespace Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr;
            int n;

            Console.WriteLine("\nMang");

            do
            {
                Console.Write("\nNhap so phan tu mang: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n <= 0) Console.WriteLine("So phan tu mang phai lon hon 0. Moi nhap lai:");
            }while (n <= 0);

            arr = new int[n];
            Console.WriteLine("\nNhap mang:");
            for(int i = 0; i < n; i++)
            {
                Console.Write("\nNhap phan tu thu {0}: ", (i + 1));
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nXuat mang: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int max = arr[0];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > max) max = arr[i];
            }

            Console.Write("\nPhan tu lon nhat la: {0}", max);

            int min = arr[0];
            for (int i = 0; i < n; i++)
            {                
                if (arr[i] < min) min = arr[i];
            }
            Console.Write("\nPhan tu nho nhat la: {0}", min);

            Console.ReadLine();
        }
    }
}
