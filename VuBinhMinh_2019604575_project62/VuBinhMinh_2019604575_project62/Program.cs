using System;
using System.Collections.Generic;

namespace VuBinhMinh_2019604575_project62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=====Vehicles=====");

            List<Vehicles> li = new List<Vehicles>();
            int choose;
            Boolean flag = true;

            Console.OutputEncoding.
            try
            {
                do
                {
                    Console.WriteLine("\n1. Nhap du lieu");
                    Console.WriteLine("2. Hien thi du lieu");
                    Console.WriteLine("3. Tim kiem theo id");
                    Console.WriteLine("4. Tim kiem theo maker");
                    Console.WriteLine("5. Sap xep theo price");
                    Console.WriteLine("6. Sap xep theo year");
                    Console.WriteLine("7. Ket thuc");
                    Console.Write("\nMoi ban chon:  ");

                    do
                    {
                        choose = int.Parse(Console.ReadLine());
                        if (choose < 1 || choose > 7)
                            Console.WriteLine("\nLua chon khong hop le. Moi nhap lai");
                    } while (choose < 1 || choose > 7);

                    switch(choose)
                    {
                        case 1:
                            Console.WriteLine("\n=====Nhap du lieu=====");

                            string n = "";
                            while(n != "0")
                            {
                                Console.WriteLine("\nNhap thong tin car: ");
                                Car car1 = new Car();
                                car1.input();
                                li.Add(car1);

                                Console.Write("\nNhap \"0\" de ket thuc nhap. Nhan enter de tiep tuc.");
                                n = Console.ReadLine();
                            }

                            string m = "";
                            while (m != "0")
                            {
                                Console.WriteLine("\nNhap thong tin truck: ");
                                Truck truck1 = new Truck();
                                truck1.input();
                                li.Add(truck1);

                                Console.Write("\nNhap \"0\" de ket thuc nhap. Nhan enter de tiep tuc.");
                                m = Console.ReadLine();
                            }

                            Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 2:
                            Console.WriteLine("\n=====Hien thi du lieu=====");

                            
                           
                            foreach(var item in li)
                            {
                                item.output();
                            }

                            Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n=====Tim kiem theo id=====");

                            Console.Write("\nNhap id can tim kiem:  ");
                            string id = Console.ReadLine();

                            foreach(var item in li)
                            {
                                if (item.id.Equals(id))
                                    item.output();
                            }

                            Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 4:
                            Console.WriteLine("\n=====Tim kiem theo marker=====");

                            Console.Write("\nNhap maker can tim kiem:  ");
                            string marker = Console.ReadLine();
                            List<Vehicles> list = new List<Vehicles>();

                            foreach (var item in li)
                            {
                                if (item.maker.Equals(marker))
                                    list.Add(item);
                            }
                            

                            Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 5:
                            Console.WriteLine("\n=====Sap xep theo price=====");

                            flag = true;
                            break;

                        case 6:
                            flag = true;
                            break;

                        case 7:
                            Console.WriteLine("\nSee you later!!!");
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
