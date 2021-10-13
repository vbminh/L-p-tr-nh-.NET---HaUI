using System;

namespace Bài_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t=======Circle========");
            Circle a = new Circle(3.5);

            Console.WriteLine("\nChu vi cua hinh tron a la: " + a.Perimeter());
            Console.WriteLine("Dien tich cua hinh tron a la: " + a.Area());

            Circle b = new Circle();

            b.input();
            Console.WriteLine("\nChu vi cua hinh tron b la: " + b.Perimeter());
            Console.WriteLine("Dien tich cua hinh tron b la: " + b.Area());

            Console.ReadKey();
        }
    }
}
