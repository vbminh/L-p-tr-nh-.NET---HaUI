using System;
using System.Collections.Generic;

namespace DanhSach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> ThanhPho;

            Console.WriteLine("\tDanh sach thanh pho");
            Console.Write("\nNhap so luong thanh pho: ");
            int n = int.Parse(Console.ReadLine());

            ThanhPho = new List<string>(n);

            for(int i = 0; i < n; i++)
            {
                Console.Write("\nNhap ten thanh pho thu {0}: ", (i + 1));
                string tmp = Console.ReadLine();
                ThanhPho.Add(tmp);
            }

            ThanhPho.Sort();

            Console.WriteLine("\nDanh sach thanh pho sap xep tang dan theo ten la: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ThanhPho[i]);
            }

            ThanhPho.Remove("Ha Noi");
            Console.Write("\nNhap ten thanh pho muon them: ");
            string temp = Console.ReadLine();

            Console.Write("\nNhap vi tri muon them: ");
            int index = int.Parse(Console.ReadLine());
            ThanhPho.Insert(index - 1, temp);

            Console.WriteLine("\nDanh sach thanh pho sau khi xoa \"Ha Noi\" va them thanh pho " +
                "\"{0}\" vao vi tri {1} la: ",temp,index);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(ThanhPho[i]);
            }

            Console.ReadKey();
        }
    }
}
