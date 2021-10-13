using System;

namespace DemoMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("\nNhap so nguyen thu 1: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so nguyen thu 2: ");
            int no2 = int.Parse(Console.ReadLine());

            double ketQua = Chia2So(no1,no2);

            Console.WriteLine($"\n10 : 4 = {ketQua}");

            Console.ReadLine();
        }
        //phương thức chia 2 số nguyên
        private static double Chia2So(int so1, int so2)
        {
            return (double) so1 / so2;
        }
    }
}
