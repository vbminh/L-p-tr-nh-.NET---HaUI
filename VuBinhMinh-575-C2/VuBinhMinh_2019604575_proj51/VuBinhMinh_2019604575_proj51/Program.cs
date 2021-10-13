using System;
using System.Collections.Generic;

namespace VuBinhMinh_2019604575_proj51
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t======BANG DIEM======");

            List<ThisinhA> ts = new List<ThisinhA>();
            int choose = 0;
            Boolean flag = true;
            try
            {
                Console.WriteLine("\n1. Nhap thong tin 1 thi sinh");
                Console.WriteLine("2. Hien thi danh sach cac thi sinh");
                Console.WriteLine("3. Hien thi cac thi sinh theo tong diem");
                Console.WriteLine("4. Hien thi cac thi sinh theo dia chi");
                Console.WriteLine("5. Tim kiem theo so bao danh");
                Console.WriteLine("6. Ket thuc chuong trinh");
                do
                {
                    do
                    {
                        Console.Write("\nMoi ban chon: ");
                        choose = int.Parse(Console.ReadLine());
                        if (choose < 1 || choose > 6)
                            Console.Write("\nLua chon khong dung. Hay chon lai");
                    } while (choose < 1 || choose > 6);

                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("\n----------Nhap vao thong tin 1 thi sinh----------\n");
                            string e = "";
                            while(e != "e")
                            {
                                ThisinhA tsA = new ThisinhA();
                                tsA.input();
                                ts.Add(tsA);

                                Console.WriteLine("\nThem thanh cong!");
                                Console.Write("\nNhan \"e\" de ket thuc nhap.\nAn phim bat ki de tiep tuc:  ");
                                e = Console.ReadLine();
                            }
                            flag = true;
                            break;

                        case 2:
                            Console.WriteLine("\n---------Danh sach thi sinh----------\n");

                            Console.WriteLine($"{"So bd",10} {"Ho ten",20} {"Dia chi",15} {"Toan",5} {"Ly",5} {"Hoa",5} {"Diem uu tien",10} {"Tong diem",10}");
                            foreach (ThisinhA i in ts)
                            {
                                i.output();
                            }

                            Console.WriteLine("\nTong so thi sinh: " + ts.Count);
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n----------Danh sach thi sinh theo tong diem----------\n");
                            Console.Write("\nNhap tong diem cua thi sinh: ");
                            double sum = double.Parse(Console.ReadLine());

                            Console.WriteLine("----Ket qua-----\n");
                            Console.WriteLine($"{"So bd",10} {"Ho ten",20} {"Dia chi",15} {"Toan",5} {"Ly",5} {"Hoa",5} {"Diem uu tien",10} {"Tong diem",10}");

                            for(int i = 0; i < ts.Count; i++)
                            {
                                if (ts[i].tongdiem(ts[i].toan, ts[i].ly, ts[i].hoa, ts[i].diemut) >= sum)
                                    ts[i].output();
                            }
                            Console.WriteLine();
                            flag = true;
                            break;

                        case 4:
                            Console.WriteLine("\n----------Danh sach thi sinh theo dia chi----------\n");
                            Console.Write("\nNhap dia chi cua thi sinh: ");
                            string address = Console.ReadLine();

                            Console.WriteLine("----Ket qua-----\n");
                            Console.WriteLine($"{"So bd",10} {"Ho ten",20} {"Dia chi",15} {"Toan",5} {"Ly",5} {"Hoa",5} {"Diem uu tien",10} {"Tong diem",10}");

                            for (int i = 0; i < ts.Count; i++)
                            {
                                if (ts[i].diachi == address)
                                    ts[i].output();
                            }
                            Console.WriteLine();
                            flag = true;
                            break;

                        case 5:
                            Console.WriteLine("\n----------Danh sach thi sinh theo so bao danh----------\n");
                            Console.Write("\nNhap tong diem cua thi sinh: ");
                            string  id = Console.ReadLine();

                            Console.WriteLine("----Ket qua-----\n");
                            Console.WriteLine($"{"So bd",10} {"Ho ten",20} {"Dia chi",15} {"Toan",5} {"Ly",5} {"Hoa",5} {"Diem uu tien",10} {"Tong diem",10}");

                            for (int i = 0; i < ts.Count; i++)
                            {
                                if (ts[i].sobd == id)
                                    ts[i].output();
                            }
                            Console.WriteLine();
                            flag = true;
                            break;

                        case 6:
                            Console.WriteLine("\nHen gap lai");
                            flag = false;
                            break;
                    }
                } while (flag);
            }
            catch(Exception e)
            {
                Console.WriteLine("\nError: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
