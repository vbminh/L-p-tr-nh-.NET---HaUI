using System;

namespace DemoMethodByVal
{
    class Program
    {
        static void Main(string[] args)
        {
            int tong, hieu, tich;
            double thuong;
            Console.Write("\nNhap so nguyen thu 1: ");
            int no1 = int.Parse(Console.ReadLine());
            Console.Write("\nNhap so nguyen thu 2: ");
            int no2 = int.Parse(Console.ReadLine());

            Process2Number.XuLy2So(no1, no2, out tong, out hieu, out tich, out thuong);

            Console.WriteLine($"\nHai so {no1}, {no2} co: tong = {tong}, hieu = {hieu}, tich = {tich}, thuong={thuong}");

            Console.ReadLine();
        }
        //phương thức chia 2 số nguyên
        
    }
    class Process2Number
    {
        //public static void XuLy2So(int so1, int so2,ref int tong, ref int hieu, ref int tich, ref double thuong)
        //{
        //    //tong = so1 + so2;
        //    hieu = so1 - so2;
        //    tich = so1 * so2;
        //    thuong = (double) so1 / so2;
        //}
        public static void XuLy2So(int so1, int so2, out int tong,  out int hieu, out int tich, out double thuong)
        {
            tong = so1 + so2;
            hieu = so1 - so2;
            tich = so1 * so2;
            thuong = (double)so1 / so2;
        }
    }
}
