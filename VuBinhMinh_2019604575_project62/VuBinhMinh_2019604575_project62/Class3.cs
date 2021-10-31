using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_project62
{
    class Truck : Vehicles
    {
        private int _truckload;

        public int truckload
        {
            get { return _truckload; }
            set
            {
                if (value > 0)
                    _truckload = value;
                else
                    throw new Exception("\nTai trong phai lon hon 0");
            }
        }
        public Truck()
        {

        }

        public Truck(string id, string maker, string model, int year, double price, int truckload) : base(id, maker, model, year, price)
        {
            this.truckload = truckload;
        }

        public override void input()
        {
            base.input();

            Console.Write("\nNhap trong tai: ");
            truckload = int.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine($"{truckload,10}");
        }
    }
   
}
