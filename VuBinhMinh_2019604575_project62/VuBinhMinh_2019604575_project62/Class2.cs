using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_project62
{
    class Car:Vehicles
    {
        protected string color { get; set; }

        public Car()
        {

        }

        public Car(string id, string maker, string model, int year, double price, string color) : base(id, maker, model, year, price)
        {
            this.color = color;
        }

        public override void input()
        {
            base.input();

            Console.Write("\nNhap mau: ");
            color = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine($"{color,10}");
        }
    }
}
