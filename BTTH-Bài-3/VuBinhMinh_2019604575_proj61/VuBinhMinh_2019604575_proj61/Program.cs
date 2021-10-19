using System;
using System.Collections.Generic;

namespace VuBinhMinh_2019604575_proj61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t=====Student====");

            List<Student> std = new List<Student>();
            int choose;
            Boolean flag = true;

            try
            {
                do
                {
                    Console.WriteLine("\n1. Them 1 sinh vien");
                    Console.WriteLine("\n2. Hien thi danh sach sinh vien");
                    Console.WriteLine("\n3. Tim kiem sinh vien theo id");
                    Console.WriteLine("\n4. Tim kiem sinh vien theo address");
                    Console.WriteLine("\n5. Xoa 1 sinh vien theo id");
                    Console.WriteLine("\n6. Ket thuc chuong trinh");
                    Console.Write("\nMoi ban chon: ");
                    do
                    {
                        choose = int.Parse(Console.ReadLine());
                        if (choose < 1 || choose > 6)
                            Console.WriteLine("\nLua chon khong dung. Moi chon lai");
                    } while (choose < 1 || choose > 6);

                    switch(choose)
                    {
                        case 1:
                            Console.WriteLine("\n=====Them 1 sinh vien=====");
                            string n1 = "";
                            while(n1 != "0")
                            {
                                Student temp = new Student();
                                temp.input();
                                std.Add(temp);

                                Console.WriteLine("\nAn 0 de ket thuc nhap. An phim bat ki de tiep tuc them sinh vien");
                                n1 = Console.ReadLine();
                            }

                            flag = true;
                            break;
                        case 2:
                            Console.WriteLine("\n=====Hien thi danh sach sinh vien=====\n");

                            if (std.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDanh sach sinh vien trong. Hay nhap them sinh vien");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine($"{"id",10} {"name",20} {"address",20} {"math",10} {"physics",10} {"Total",10}");

                                foreach (Student item in std)
                                {
                                    item.output();
                                }
                            }

                            Console.ReadLine();
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n=====Tim kiem sinh vien theo id=====");

                            if (std.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDanh sach sinh vien trong. Hay nhap them sinh vien");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nNhap id ban muon tim:  ");
                                int id3 = int.Parse(Console.ReadLine());

                                Console.WriteLine($"{"id",10} {"name",20} {"address",20} {"math",10} {"physics",10} {"Total",10}");

                                for (int i = 0; i < std.Count; i++)
                                {
                                    if (std[i].id == id3)
                                        std[i].output();
                                }
                            }

                            Console.ReadLine();
                            flag = true;
                            break;

                        case 4:
                            Console.WriteLine("\n=====Tim kiem sinh vien theo address=====");

                            if (std.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDanh sach sinh vien trong. Hay nhap them sinh vien");
                                Console.ResetColor();
                            }
                             else
                            {
                                Console.Write("\nNhap address ban muon tim: ");
                                string address4 = Console.ReadLine();

                                Console.WriteLine($"{"id",10} {"name",20} {"address",20} {"math",10} {"physics",10} {"Total",10}");

                                for (int i = 0; i < std.Count; i++)
                                {
                                    if (std[i].address == address4)
                                        std[i].output();
                                }
                            }

                            Console.ReadLine();
                            flag = true;
                            break;

                        case 5:
                            Console.WriteLine("\n=====Tim kiem sinh vien theo id=====");

                            if (std.Count == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("\nDanh sach sinh vien trong. Hay nhap them sinh vien");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write("\nNhap id sinh vien ban muon xoa: ");
                                int id5 = int.Parse(Console.ReadLine());
                                int count5 = 0;
                                int dem = std.Count;

                                for (int i = 0; i < std.Count; i++)
                                {
                                    if (std[i].id == id5)
                                    {
                                        std.RemoveAt(i);
                                        Console.WriteLine("\nXoa thanh cong sinh vien co id \"{0}\" ra khoi danh sach", id5);
                                    }
                                    else count5++;
                                }

                                if (count5 == dem)
                                {
                                    Console.WriteLine("\nKhong ton tai sinh vien co id \"{0}\" trong danh sach", id5);
                                }
                            }

                            Console.ReadLine();
                            flag = true;
                            break;

                        case 6:
                            Console.WriteLine("\nSee you again");
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
