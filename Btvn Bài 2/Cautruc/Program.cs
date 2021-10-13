using System;

namespace Cautruc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tHoc sinh");

            HocSinh[] hs;

            Console.Write("\nNhap so luong hoc sinh: ");
            int n = int.Parse(Console.ReadLine());
            hs = new HocSinh[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("\nNhap thong tin hoc sinh thu {0}: ", (i + 1));
                hs[i].Input();
            }

            Console.WriteLine("\nDanh sach hoc sinh vua nhap: ");
            Console.WriteLine("Ho ten \t\t Tuoi \t\t Gioi tinh");
            for (int i = 0; i < n; i++)
            {
                hs[i].output();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += hs[i].tuoi;
            }

            Console.WriteLine("\nTong so tuoi cua hoc sinh la: " + sum);

            Console.ReadKey();
        }

        struct HocSinh
        {
            public string hoTen;
            public int tuoi;
            public Boolean gioiTinh;
            public void Input()
            {
                Console.Write("\nNhap ten cua hoc sinh: ");
                hoTen = Console.ReadLine();
                Console.Write("\nNhap tuoi cua hoc sinh: ");
                tuoi = int.Parse(Console.ReadLine());
                Console.Write("\nNhap gioi cua hoc sinh: ");
                string gt = Console.ReadLine();

                if (gt == "nam") gioiTinh = true;
                else
                {
                    if (gt == "nu") gioiTinh = false;
                    else Console.WriteLine("\nLoi: Gioi tinh chi co the la \"nam\" hoac \"nu\"");
                }
            }

            public void output()
            {
                Console.WriteLine("{0} \t\t {1} \t\t {2}", hoTen, tuoi, gioiTinh);
            }
        }

    }
}
