using System;
using System.Collections.Generic;

namespace Bài1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t======Sinh Vien======");

            List<SinhVien> sv = new List<SinhVien>();

            string choose = "";
            try {
                while (choose != "e")
                {
                    Console.WriteLine("\nNhap thong tin sinh vien: ");
                    SinhVien tmp = new SinhVien();
                    tmp.input();
                    sv.Add(tmp);

                    Console.Write("\nNhap \"e\" neu ban da nhap xong.\nAn phim bat ki de tiep tuc:  ");
                    choose = Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }
            

            Console.WriteLine("\n\n\t\t======Danh Sach Sinh Vien======\n");
            Console.WriteLine($"{"Ho Ten",20} {"Gioi Tinh",10} {"Nam sinh",10} {"Dia Chi",10} {"Diem Chu",10}");

            foreach(SinhVien item in sv)
            {
                item.output();
            }

            Console.ReadKey();
        }
    }
}
