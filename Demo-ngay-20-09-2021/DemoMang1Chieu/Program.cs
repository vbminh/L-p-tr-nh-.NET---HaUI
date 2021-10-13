using System;

namespace DemoMang1Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nNhap so phan tu cua mang: ");
            int soPT = Convert.ToInt32(Console.ReadLine());
            int[] mangSoNguyen = NhapMang(soPT);
            //hiển thị danh sách các số đã nhập
            HienThiMang(mangSoNguyen);
            //sắp xếp tăng dần và hiển thị lại danh sách sau khi sắp
            Console.WriteLine("\nMang sau sap xep: ");
            Array.Sort(mangSoNguyen);
            Array.Reverse(mangSoNguyen);
            HienThiMang(mangSoNguyen);

            Console.ReadLine();
        }

        //Phương thức nhập các phần tử vào mảng số nguyên
        private static int[] NhapMang(int soPhanTu)
        {
            int[] danhSachSoNguyen = new int[soPhanTu];
            for (int i = 0; i < danhSachSoNguyen.Length; i++)
            {
                Console.Write("\nNhap phan tu thu {0}: ", i + 1);
                danhSachSoNguyen[i] = int.Parse(Console.ReadLine());
            }

            return danhSachSoNguyen;
        }
    
        private static void HienThiMang(int[] mangSoNguyen)
        {
            //for (int i = 0; i < mangSoNguyen.Length; i++)
            //{
            //    Console.Write($"\t{mangSoNguyen[i]}");
            //}
            foreach (int item in mangSoNguyen)
            {
                Console.Write($"\t{item}");
            }
        }
    

    }
}
