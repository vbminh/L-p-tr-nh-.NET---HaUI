using System;
using System.Collections.Generic;

namespace VuBinhMinh_2019604575_project62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=====Vehicles=====");

            List<Car> car = new List<Car>();
            List<Truck> truck = new List<Truck>();
            int choose;
            Boolean flag = true;

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
                                car.Add(car1);

                                Console.Write("\nNhap \"0\" de ket thuc nhap. Nhan enter de tiep tuc.");
                                n = Console.ReadLine();
                            }

                            string m = "";
                            while (m != "0")
                            {
                                Console.WriteLine("\nNhap thong tin truck: ");
                                Truck truck1 = new Truck();
                                truck1.input();
                                truck.Add(truck1);

                                Console.Write("\nNhap \"0\" de ket thuc nhap. Nhan enter de tiep tuc.");
                                m = Console.ReadLine();
                            }

                            Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 2:
                            Console.WriteLine("\n=====Hien thi du lieu=====");

                            Console.WriteLine("\nCar: ");
                            Console.WriteLine($"{"Id",10} {"Maker",15} {"Model",15} {"Year",10} {"Price",10} {"Color",10}");
                            foreach(Car item in car)
                            {
                                item.output();
                            }

                            Console.WriteLine("\nTruck: ");
                            Console.WriteLine($"{"Id",10} {"Maker",15} {"Model",15} {"Year",10} {"Price",10} {"TruckLoad",10}");
                            foreach (Truck item in truck)
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

                            for(int i = 0; i < car.Count; i++)
                            {
                                if (car[i].id == id)
                                    car[i].input();
                            }
                            Console.WriteLine();
                            for (int i = 0; i < truck.Count; i++)
                            {
                                if (truck[i].id == id)
                                    truck[i].input();
                            }

                            Console.WriteLine("\nNhan \"Enter\" den tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 4:
                            flag = true;
                            break;

                        case 5:
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
