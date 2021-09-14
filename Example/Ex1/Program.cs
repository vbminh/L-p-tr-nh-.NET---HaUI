using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            const double PI = 3.14;
            double C, S;

            Console.Write("Nhap ban kinh hinh tron: ");
            r = Convert.ToInt32(Console.ReadLine());

            C = 2 * PI * r;
            S = PI * r * r;

            Console.WriteLine("Chu vi cua hinh tron ban kinh r = {0} là {1}", r, C);
            Console.WriteLine("Dien tich cua hinh tron ban kinh r = {0} la {1}", r, S);

        }
    }
}
