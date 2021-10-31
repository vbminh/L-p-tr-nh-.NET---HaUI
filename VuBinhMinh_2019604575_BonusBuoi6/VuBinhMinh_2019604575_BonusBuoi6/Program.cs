using System;
using System.Collections.Generic;

namespace VuBinhMinh_2019604575_BonusBuoi6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> nv = new List<NhanVien>();
            
            Boolean flag = true;
            int opt;
            try
            {
                do
                {
                    Console.WriteLine("\n\t======MENU=======");

                    Console.WriteLine("\n1. Nhap thong tin");
                    Console.WriteLine("2. Hien thi danh sach da nhap");
                    Console.WriteLine("3. Xoa thong tin");
                    Console.WriteLine("4. Sap xeo theo ho ten");
                    Console.WriteLine("5. Sap xep theo ho ten, nam sinh");
                    Console.WriteLine("6. Tim thong tin sinh vien nhieu tuoi nhat");
                    Console.WriteLine("7. Sua thong tin");
                    Console.WriteLine("0. Thoat chuong trinh");

                    do
                    {
                        Console.Write("\nYour choice: ");
                        opt = int.Parse(Console.ReadLine());
                        if (opt < 0 || opt > 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nLua chon khong hop le. Hay chon lai ");
                            Console.ResetColor();
                        }
                    } while (opt < 0 || opt > 7);

                    switch(opt)
                    {
                        case 1:
                            Console.WriteLine("\n--------Nhap thong tin----------");
                            Console.WriteLine("\n1. Nhan vien");
                            Console.WriteLine("2. Nhan vien hop dong");
                            Console.Write("\nYour choice: ");
                            int opt1 = int.Parse(Console.ReadLine());
                            string n1 = "";
                            switch (opt1)
                            {
                                case 1:
                                    while (n1 != "0")
                                    {
                                        Console.WriteLine("\nNhap thong tin Nhan vien:");
                                        string id1;
                                        int count;
                                        do
                                        {
                                            count = 0;

                                            Console.Write("-Nhap ma nhan vien: ");
                                            id1 = Console.ReadLine();

                                            for(int i = 0; i < nv.Count; i++)
                                            {
                                                if(nv[i].id == id1)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\nMa nhan vien nay da ton tai. Hay nhap lai ");
                                                    Console.ResetColor();
                                                    count++;
                                                }    
                                            }
                                        } while (count != 0);

                                        Console.Write("-Nhap ten nhan vien: ");
                                        string name1 = Console.ReadLine();

                                        Console.Write("-Nhap nam sinh cua nhan vien: ");
                                        int birth1 = int.Parse(Console.ReadLine());

                                        NhanVien nv1 = new NhanVien(id1, name1, birth1);
                                        nv.Add(nv1);

                                        Console.Write("\nNhap \"0\" neu ban da nhap thong tin xong ");
                                        n1 = Console.ReadLine();
                                    }
                                    break;

                                case 2:
                                    while (n1 != "0")
                                    {
                                        Console.WriteLine("\nNhap thong tin Nhan vien:");

                                        string id1;
                                        int count;
                                        do
                                        {
                                            count = 0;

                                            Console.Write("-Nhap ma nhan vien: ");
                                            id1 = Console.ReadLine();

                                            for (int i = 0; i < nv.Count; i++)
                                            {
                                                if (nv[i].id == id1)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\nMa nhan vien nay da ton tai. Hay nhap lai ");
                                                    Console.ResetColor();
                                                    count++;
                                                }
                                            }
                                        } while (count != 0);

                                        Console.Write("-Nhap ten nhan vien: ");
                                        string name1 = Console.ReadLine();

                                        Console.Write("-Nhap nam sinh cua nhan vien: ");
                                        int birth1 = int.Parse(Console.ReadLine());

                                        Console.Write("-Nhap so gio lam viec: ");
                                        int hour1 = int.Parse(Console.ReadLine());

                                        Console.Write("-Nhap luong mot gio: ");
                                        int srh1 = int.Parse(Console.ReadLine());

                                        NhanVienHopDong nvhd1 = new NhanVienHopDong(id1, name1, birth1,hour1,srh1);
                                        nv.Add(nvhd1);

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

                            if(nv.Count > 0)
                            {
                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv)
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
                            Console.WriteLine("\n--------Xoa thong tin----------\n");

                            if (nv.Count > 0)
                            {
                                Console.WriteLine("-Danh sach nhan vien truoc khi xoa:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",15} {"Working Hours",15} {"Salary per Hour",15} {"Salary",15}");

                                foreach (NhanVien item in nv)
                                {
                                    Console.WriteLine(item);
                                }

                                Console.Write("\nNhap ma nhan vien ban muon xoa: ");
                                string id3 = Console.ReadLine();

                                for (int i = 0; i < nv.Count; i++)
                                {
                                    if (nv[i].id == id3)
                                    {
                                        nv.RemoveAt(i);
                                    }
                                }

                                Console.WriteLine("-Danh sach nhan vien sau khi xoa:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",10} {"Working Hours",10} {"Salary per Hour",15} {"Salary",15}");

                                foreach (NhanVien item in nv)
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
                            Console.WriteLine("\n--------Sap xep theo ho ten----------\n");
                            if (nv.Count > 0)
                            {
                                Console.WriteLine("-Danh sach nhan vien truoc khi sap xep:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv)
                                {
                                    Console.WriteLine(item);
                                }

                                nv.Sort();

                                Console.WriteLine("\n-Danh sach nhan vien sau khi sap xep:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv)
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

                            Console.Write("\nNhan \"Enter\" de tiep tuc");
                            Console.ReadLine();

                            flag = true;
                            break;

                        case 5:
                            Console.WriteLine("\n--------Sap xep theo ho ten (vip pro)----------\n");

                            if (nv.Count > 0)
                            {
                                Console.WriteLine("-Danh sach nhan vien truoc khi sap xep:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv)
                                {
                                    Console.WriteLine(item);
                                }

                                nv.Sort();

                                for (int i = 0; i < nv.Count; i++)
                                {
                                    for (int j = i + 1; j < nv.Count; j++)
                                    {
                                        if(nv[i].name == nv[j].name)
                                        {
                                            int year = nv[i].birth - nv[j].birth;
                                            if(year > 0)
                                            {
                                                NhanVien temp = nv[i];
                                                nv[i] = nv[j];
                                                nv[j] = temp;
                                            }
                                        }
                                    }
                                }
                                    
                                Console.WriteLine("\n-Danh sach nhan vien sau khi sap xep:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv)
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

                            Console.Write("\nNhan \"Enter\" de tiep tuc");
                            Console.ReadLine();

                            flag = true;
                            break;

                        case 6:
                            Console.WriteLine("\n-------Danh sach nhung nhan vien nhieu tuoi nhat------\n");

                            if (nv.Count > 0)
                            {
                                var today = DateTime.Today;
                                var year = today.Year;
                                int max = 0;

                                for (int i = 0; i < nv.Count; i++)
                                {
                                    int age1 = year - nv[i].birth;
                                    if (age1 > max)
                                        max = age1;
                                }

                                List<NhanVien> nv2 = new List<NhanVien>();

                                for (int i = 0; i < nv.Count; i++)
                                {
                                    int age2 = year - nv[i].birth;
                                    if (age2 == max)
                                        nv2.Add(nv[i]);
                                }

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv2)
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

                            Console.Write("\nNhan \"Enter\" de tiep tuc");
                            Console.ReadLine();

                            flag = true;
                            break;

                        case 7:
                            Console.WriteLine("\n-------Sua thong tin------\n");

                            if (nv.Count > 0)
                            {
                                Console.WriteLine("-Danh sach nhan vien truoc khi cap nhat:\n");

                                Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                foreach (NhanVien item in nv)
                                {
                                    Console.WriteLine(item);
                                }

                                Console.Write("\nNhap id nhan vien can sua: ");
                                string id7 = Console.ReadLine();

                                NhanVien nv7 = new NhanVien(id7);
                                int index = nv.IndexOf(nv7);

                                if(index != -1)
                                {
                                    Boolean flag7 = true;
                                    do
                                    {
                                        Console.WriteLine("\n1. Sua ten nhan vien");
                                        Console.WriteLine("2. Sua nam sinh");
                                        Console.WriteLine("3. Sua so gio lam viec va luong mot gio");
                                        Console.WriteLine("0. Ket thuc");

                                        Console.Write("\nYour choice: ");
                                        int opt7 = int.Parse(Console.ReadLine());

                                        switch(opt7)
                                        {
                                            case 1:
                                                Console.Write("\n-Nhap ten moi cua nhan vien: ");
                                                string name7 = Console.ReadLine();

                                                nv[index].name = name7;
                                                flag7 = true;
                                                break;

                                            case 2:
                                                Console.Write("\n-Nhap nam sinh moi cua nhan vien: ");
                                                int birth7 = int.Parse(Console.ReadLine());

                                                nv[index].birth = birth7;

                                                flag7 = true;
                                                break;

                                            case 3:
                                                Console.Write("\n-Nhap so gio lam viec moi: ");
                                                int hour7 = int.Parse(Console.ReadLine());

                                                Console.Write("-Nhap luong mot gio: ");
                                                int srh7 = int.Parse(Console.ReadLine());

                                                NhanVienHopDong nvhd7 = new NhanVienHopDong();
                                                nvhd7.id = id7;
                                                nvhd7.name = nv[index].name;
                                                nvhd7.birth = nv[index].birth;
                                                nvhd7.hour = hour7;
                                                nvhd7.salaryPerHour = srh7;

                                                nv[index] = nvhd7;

                                                flag7 = true;
                                                break;

                                            default:
                                                flag7 = false;
                                                break;
                                        }
                                    } while (flag7);

                                    Console.WriteLine("\n-Danh sach nhan vien sau khi cap nhat:\n");

                                    Console.WriteLine($"{"Id",-8} {"Name",-20} {"Year of Birth",20} {"Working Hours",20} {"Salary per Hour",20} {"Salary",20}");

                                    foreach (NhanVien item in nv)
                                    {
                                        Console.WriteLine(item);
                                    }
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nKhong ton tai nhan vien nay trong danh sach");
                                    Console.ResetColor();
                                }
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nChua co nhan vien trong danh sach. Hay chon them moi");
                                Console.ResetColor();
                            }
                            Console.Write("\nNhan \"Enter\" de tiep tuc");
                            Console.ReadLine();

                            flag = true;
                            break;

                        case 0:
                            Console.WriteLine("\nGoodbye. See you later");
                            flag = false;
                            break;
                    }
                } while (flag);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: " + e.Message);
                Console.ResetColor();
            }

            Console.ReadKey();


        }
    }
}
