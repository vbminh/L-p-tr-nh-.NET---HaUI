using System;

namespace HinhChuNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double C, S;

            Console.WriteLine("\tHINH CHU NHAT");
            Console.WriteLine("\nNhap do dai cac canh: ");
            do
            {
                Console.Write("Nhap chieu dai: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.Write("Nhap chieu rong: ");
                b = Convert.ToDouble(Console.ReadLine());

                if (a <= 0 || b <= 0) Console.WriteLine("Moi nhap lai");

            } while (a <= 0 || b <= 0);

            C = (a + b) * 2;
            S = a * b;

            Console.WriteLine("Ket qua: ");
            Console.WriteLine("Chu vi cua hinh chu nhat la: {0}", C);
            Console.WriteLine("Dien tich cua hinh chu nhat la: {0}", S);

            Console.ReadLine();
        }
    }
}
