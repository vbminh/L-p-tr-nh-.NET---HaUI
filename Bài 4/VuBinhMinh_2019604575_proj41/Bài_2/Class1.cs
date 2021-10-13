using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    class Circle
    {
        private double radius { get; set; }
        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.radius = radius;
        } 
        public void input()
        {
            do
            {
                Console.Write("\nNhap ban kinh: ");
                radius = double.Parse(Console.ReadLine());
                if (radius < 0)
                    Console.WriteLine("\nDo dai ban kinh khong hop le. Moi nhap lai");
            } while (radius < 0);
        }
        public double Area()
        {
            return Math.Round((radius * radius * 3.14),2);
        }

        public double Perimeter()
        {
            return Math.Round((2 * radius * 3.14),2);
        }

    }
}
