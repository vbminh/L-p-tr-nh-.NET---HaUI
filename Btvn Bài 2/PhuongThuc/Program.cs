using System;

namespace PhuongThuc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tKiem tra so nguyen to");

            Console.Write("\nNhap so phan tu mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("\nNhap phan tu thu {0}: ", (i + 1));
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nMang so nguyen vua nhap la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\n\nCac so nguyen to la: ");
            for (int i = 0; i < n; i++)
            {
                if (isPrime(arr[i]))  {
                    Console.Write(arr[i] + " ");
                }
            }

            Console.ReadKey();

        }

        public static Boolean isPrime(int n)
        {
            if (n < 2)
                return false;
            
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
             }
            
            return true;
        }
    }
}
