using System;
using System.Collections.Generic;

namespace De4_Minh_575_C2_C2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> NV = new List<NhanVien>();

            Boolean flag = true;
            int opt;
            try
            {
                do
                {
                    Console.WriteLine("\n\t======MENU=======");

                    Console.WriteLine("\n1. Nhap thong tin");
                    Console.WriteLine("2. Hien thi danh sach");
                    Console.WriteLine("3. Sap xep");
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
                    } while (opt < 0 || opt > 4);

                    switch (opt)
                    {
                        case 1:
                            Console.WriteLine("\n--------Nhap thong tin----------");
                            Console.WriteLine("\n1. Nhan vien");
                            Console.WriteLine("2. Nhan vien ban hang");

                            Console.Write("\nYour choice: ");
                            int opt1 = int.Parse(Console.ReadLine());
                            string n1 = "";
                            int index = 0;

                            switch (opt1)
                            {
                                case 1:
                                    while (n1 != "0")
                                    {
                                        Console.WriteLine("\nNhap thong tin Nhan vien:");
                                        string name1;
                                        do
                                        {
                                            Console.Write("-Nhap ten nhan vien: ");
                                            name1 = Console.ReadLine();

                                            NhanVien nv1 = new NhanVien(name1);
                                            index = NV.IndexOf(nv1);
                                            
                                            if (index != -1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nTen nhan vien nay da ton tai. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (index != -1);

                                        Console.WriteLine("-Nhap ngay tuyen dung: ");
                                        int ngay;
                                        do
                                        {
                                            Console.Write("Nhap ngay: ");
                                            ngay = int.Parse(Console.ReadLine());
                                            if (ngay <= 0 || ngay > 31)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nNgay khong hop le. Hay nhap lai ");
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

                                        DateTime ngaytuyendung1 = new DateTime(nam, thang, ngay);

                                        NhanVien nv = new NhanVien(name1, ngaytuyendung1);
                                        NV.Add(nv);

                                        Console.Write("\nNhap \"0\" neu ban da nhap thong tin xong ");
                                        n1 = Console.ReadLine();
                                    }
                                    break;

                                case 2:
                                    while (n1 != "0")
                                    {
                                        Console.WriteLine("\nNhap thong tin Nhan vien:");
                                        string name1;
                                        do
                                        {
                                            Console.Write("-Nhap ten nhan vien: ");
                                            name1 = Console.ReadLine();

                                            NhanVien nv1 = new NhanVien(name1);
                                            index = NV.IndexOf(nv1);

                                            if (index != -1)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nTen nhan vien nay da ton tai. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (index != -1);

                                        Console.WriteLine("-Nhap ngay tuyen dung: ");
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

                                        DateTime ngaytuyendung1 = new DateTime(nam, thang, ngay);

                                        int soluongban = 0;
                                        do
                                        {
                                            Console.Write("\nNhap so luong ban: ");
                                            soluongban = int.Parse(Console.ReadLine());

                                            if(soluongban < 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nSo luong ban phai lon hon 0. Hay nhap lai ");
                                                Console.ResetColor();
                                            }
                                        } while (soluongban < 0);

                                        NhanVienBanHang nvbh = new NhanVienBanHang(name1, ngaytuyendung1,soluongban);
                                        NV.Add(nvbh);

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

                            if (NV.Count > 0)
                            {
                                Console.WriteLine($"{"Ho Ten",-20} {"Ngay tuyen dung"}\t {"So luong ban",15} {"Tien hoa hong",15}");

                                foreach (NhanVien item in NV)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nChua co nhan vien trong danh sach. Hay chon them moi");
                                Console.ResetColor();
                            }

                            Console.Write("\nNhan \"Enter\" de tiep tuc ");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n--------Sap xep nhan vien----------\n");

                            if (NV.Count > 0)
                            {
                                Console.WriteLine("\nDanh sach truoc khi sap xep:");
                                Console.WriteLine($"{"Ho Ten",-20} {"Ngay tuyen dung"}\t {"So luong ban",15} {"Tien hoa hong",15}");

                                foreach (NhanVien item in NV)
                                {
                                    Console.WriteLine(item);
                                }

                                NV.Sort();

                                for(int i = 0; i < NV.Count; i++)
                                {
                                    for(int j = 0; j < NV.Count; j++)
                                    {
                                       if(NV[i].CompareTo(NV[j]) == 0) 
                                        {
                                            NV.Sort(new CompareToName());
                                        } 
                                    }
                                }

                                Console.WriteLine("\nDanh sach sau khi sap xep:");
                                Console.WriteLine($"{"Ho Ten",-20} {"Ngay tuyen dung"}\t {"So luong ban",15} {"Tien hoa hong",15}");

                                foreach (NhanVien item in NV)
                                {
                                    Console.WriteLine(item);
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nChua co nhan vien trong danh sach. Hay chon them moi");
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
