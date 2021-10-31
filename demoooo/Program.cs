using System;
using System.Collections.Generic;

namespace demoooo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<NhanVien> nv = new List<NhanVien>();
            Boolean flag = true;
            try
            {
                do
                {
                    Console.WriteLine("\n\t==========Menu============\n");
                    Console.WriteLine("\n1. Them nhan vien");
                    Console.WriteLine("2. Hien thi danh sach nhan vien");
                    Console.WriteLine("3. Sap xep nhan vien");
                    Console.WriteLine("0. Thoat");
                    Console.Write("\nYour choice: ");
                    int choice = int.Parse(Console.ReadLine());

                   switch(choice)
                    {
                        case 1:
                            Console.WriteLine("\n=========Them nhan vien=========");
                            string n = "";
                            while(n != "0")
                            {
                                Console.Write("\nNhap ma nv: ");
                                string manv = Console.ReadLine();
                                Console.Write("\nNhap ten nv: ");
                                string ten = Console.ReadLine();
                                Console.Write("\nNhap dia chi nv: ");
                                string diachi = Console.ReadLine();
                                Console.Write("\nNhap chuc vu: ");
                                string chucvu = Console.ReadLine();

                                NhanVien temp = new NhanVien(ten, diachi, manv, chucvu);
                                nv.Add(temp);

                                Console.WriteLine("\nNhap 0 de ket thuc them nhan vien");
                                n = Console.ReadLine();
                            }

                            Console.Write("\nNhan \"enter\" de tiep tuc");
                            flag = true;
                            break;

                        case 2:
                            Console.WriteLine("\n=========Hien thi nhan vien=========");

                            foreach(NhanVien item in nv)
                            {
                                Console.WriteLine(item);
                            }

                            Console.Write("\nNhan \"enter\" de tiep tuc");
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n=========Sap xep nhan vien=========");
                            Console.WriteLine("\nTruoc khi sap xep");
                            foreach (NhanVien item in nv)
                            {
                                Console.WriteLine(item);
                            }

                            for(int i = 0; i < nv.Count; i++)
                            {
                                for(int j = i  +1; j < nv.Count; j++)
                                {
                                    if (nv[i].tinhluong() < nv[j].tinhluong())
                                    {
                                        NhanVien tmp = new NhanVien();
                                        tmp = nv[i];
                                        nv[i] = nv[j];
                                        nv[j] = tmp;
                                    }

                                }
                            }
                            Console.WriteLine("\nSau khi sap xep");
                            foreach (NhanVien item in nv)
                            {
                                Console.WriteLine(item);
                            }

                            Console.Write("\nNhan \"enter\" de tiep tuc");
                            flag = true;
                            break;

                        case 0:
                            Console.Write("\nSee you later");
                            flag = false;
                            break;
                    }

                } while (flag);
            }
            catch (Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }
        }
    }
}
