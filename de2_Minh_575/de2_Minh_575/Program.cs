using System;
using System.Collections.Generic;

namespace de2_Minh_575
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KhachHang> KH = new List<KhachHang>();

            Boolean flag = true;
            int opt;
            try
            {
                do
                {
                    Console.WriteLine("\n\t======MENU=======");

                    Console.WriteLine("\n1. Nhap thong tin");
                    Console.WriteLine("2. Hien thi danh sach");
                    Console.WriteLine("3. Tim khach hang");
                    Console.WriteLine("4. Thoat chuong trinh");

                    do
                    {
                        Console.Write("\nYour choice: ");
                        opt = int.Parse(Console.ReadLine());
                        if (opt < 0 || opt > 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nLua chon khong hop le. Hay chon lai ");
                            Console.ResetColor();
                        }
                    } while (opt < 0 || opt > 7);

                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("\n--------Nhap thong tin----------");
                            Console.WriteLine("\n1. Khach hang");
                            Console.WriteLine("2. Khach hang vip");
                            Console.Write("\nYour choice: ");
                            int opt1 = int.Parse(Console.ReadLine());
                            string n1 = "";
                            int index;
                            switch (opt1)
                            {
                                case 1:
                                    while (n1 != "0")
                                    {
                                        Console.WriteLine("\nNhap thong tin Khach hang:");
                                        string id1;
                                        do
                                        {
                                            Console.Write("-Nhap ma khach hang: ");
                                            id1 = Console.ReadLine();

                                            KhachHang kh1 = new KhachHang(id1);
                                            index = KH.IndexOf(kh1);

                                            if(index != -1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nMa nhan vien nay da ton tai. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (index != -1);

                                        Console.Write("-Nhap ngay sinh: ");
                                        int ngay;
                                        do
                                        {
                                            Console.Write("\nNhap ngay: ");
                                            ngay = int.Parse(Console.ReadLine());
                                            if (ngay <= 0 || ngay > 31)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nThang khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (ngay <= 0 || ngay > 31);

                                        int thang;
                                        do
                                        {
                                            Console.Write("\nNhap thang: ");
                                            thang = int.Parse(Console.ReadLine());
                                            if (thang <= 0 || thang > 12)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nThang khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (thang <= 0 || thang > 12);

                                        int nam;
                                        var today = DateTime.Today;
                                        var year = today.Year;
                                        do
                                        {
                                            Console.Write("Nhap nam: ");
                                            nam = int.Parse(Console.ReadLine());
                                            if (nam > year)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nNam khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (nam > year);

                                        DateTime ngaysinh = new DateTime(nam,thang,ngay);

                                        int slm;
                                        do
                                        {
                                            Console.Write("-Nhap so luong mua: ");
                                            slm = int.Parse(Console.ReadLine());
                                            if (slm <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nSo luong mua khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (slm < 0);

                                        double gia;
                                        do
                                        {
                                            Console.Write("-Nhap don gia: ");
                                            gia = double.Parse(Console.ReadLine());
                                            if (gia <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nDon gia khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (gia < 0);

                                        KhachHang khh = new KhachHang(id1, ngaysinh, slm, gia);
                                        KH.Add(khh);

                                        Console.Write("\nNhap \"0\" neu ban da nhap thong tin xong ");
                                        n1 = Console.ReadLine();
                                    }
                                    break;

                                case 2:
                                    while (n1 != "0")
                                    {
                                        Console.WriteLine("\nNhap thong tin Khach hang:");
                                        string id1;
                                        do
                                        {
                                            Console.Write("-Nhap ma khach hang: ");
                                            id1 = Console.ReadLine();

                                            KhachHang kh1 = new KhachHang(id1);
                                            index = KH.IndexOf(kh1);

                                            if (index != -1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nMa nhan vien nay da ton tai. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (index != -1);

                                        Console.Write("-Nhap ngay sinh: ");
                                        int ngay;
                                        do
                                        {
                                            Console.Write("Nhap ngay: ");
                                            ngay = int.Parse(Console.ReadLine());
                                            if (ngay <= 0 || ngay > 31)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nThang khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (ngay <= 0 || ngay > 31);

                                        int thang;
                                        do
                                        {
                                            Console.Write("Nhap thang: ");
                                            thang = int.Parse(Console.ReadLine());
                                            if (thang <= 0 || thang > 12)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nNam khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (thang <= 0 || thang > 12);

                                        int nam;
                                        var today = DateTime.Today;
                                        var year = today.Year;
                                        do
                                        {
                                            Console.Write("Nhap nam: ");
                                            nam = int.Parse(Console.ReadLine());
                                            if (nam > year)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nNam khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (nam > year);

                                        DateTime ngaysinh = new DateTime(nam, thang, ngay);

                                        int slm;
                                        do
                                        {
                                            Console.Write("-Nhap so luong mua: ");
                                            slm = int.Parse(Console.ReadLine());
                                            if (slm <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nSo luong mua khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (slm < 0);

                                        double gia;
                                        do
                                        {
                                            Console.Write("-Nhap don gia: ");
                                            gia = double.Parse(Console.ReadLine());
                                            if (gia <= 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nDon gia khong hop le. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (gia < 0);

                                        KhachHangVip khh1 = new KhachHangVip(id1, ngaysinh, slm, gia);
                                        KH.Add(khh1);

                                        Console.Write("\nNhap \"0\" neu ban da nhap thong tin xong ");
                                        n1 = Console.ReadLine();
                                    }
                                    break;
                            }

                            Console.Write("\nNhan \"Enter\" de tiep tuc ");
                            Console.ReadLine();

                            flag = true;
                            break;

                        case 2:
                            Console.WriteLine("\n--------Hien thi thong tin----------\n");

                            if (KH.Count > 0)
                            {
                                Console.WriteLine($"{"Ma KH",-8} {"Ngay sinh"}\t {"So luong mua",10} {"Don gia",10} {"Tong tien",10}");

                                foreach (KhachHang item in KH)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nChua co khach hang trong danh sach. Hay chon them moi");
                                Console.ResetColor();
                            }

                            Console.Write("\nNhan \"Enter\" de tiep tuc ");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n--------Tim khach hang----------\n");

                            if (KH.Count > 0)
                            {
                                List<KhachHang> KH2 = new List<KhachHang>();

                                double max = 0;

                                for(int i = 0; i < KH.Count; i++)
                                {
                                    if (KH[i].tongtien() > max)
                                        max = KH[i].tongtien();
                                }

                                for (int i = 0; i < KH.Count; i++)
                                {
                                    if (KH[i].tongtien() == max)
                                        KH2.Add(KH[i]);
                                }

                                foreach (KhachHang item in KH2)
                                    Console.WriteLine(item);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nChua co khach hang trong danh sach. Hay chon them moi");
                                Console.ResetColor();
                            }

                            Console.Write("\nNhan \"Enter\" de tiep tuc ");
                            Console.ReadLine();

                            flag = true;
                            break;

                        case 4:
                            Console.WriteLine("\nGoodbye. See you later");
                            flag = false;
                            break;
                    }
                } while (flag);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: " + e.Message);
                Console.ResetColor();
            }

            Console.ReadKey();

        }
    }
}
