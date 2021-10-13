using System;
using System.Collections.Generic;
namespace DemoListT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dsSoNguyen = Test.NhapCacPhanTuCuaDanhSach();

        }
    }

    class Test
    {
        public static List<int> NhapCacPhanTuCuaDanhSach()
        {
            List<int> dsSoNguyen = new List<int>();
            string luaChon = "";
            while (luaChon !="N")
            {
                Console.Write("\nNhap vao 1 so nguyen: ");
                dsSoNguyen.Add(int.Parse(Console.ReadLine()));
                Console.Write("\nNhan n de ket thuc nhap du lieu: ");
                luaChon = Console.ReadLine().ToUpper();
            }
            return dsSoNguyen;
        }
    }
}
