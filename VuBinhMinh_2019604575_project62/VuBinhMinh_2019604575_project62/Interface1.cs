using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_project62
{
    interface IVehiche
    {
        void input();
        void output();
    }

    class Vehicles : IVehiche
    {
        public string id { get; set; }
        public string maker { get; set; }
        public string model { get; set; }

        private int _year;
        public int year {
            get { return _year; }
            set
            {
                if (value > 0)
                    _year = value;
                else
                    throw new Exception("\nGia tien phai lon hon 0");
            }
        }

        private double _price;
        public double price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                    _price = value;
                else
                    throw new Exception("\nGia tien phai lon hon 0");
            }
        }

        public Vehicles()
        {

        }

        public Vehicles(string id)
        {
            this.id = id;
        }

        public Vehicles(string id, string maker, string model, int year, double price):this(id)
        {
            this.maker = maker;
            this.model = model;
            this.year = year;
            this.price = price;
        }

        public virtual void input()
        {
            Console.Write("\nNhap ma dinh danh:   ");
            id = Console.ReadLine();

            Console.Write("\nNhap hang san xuat:   ");
            maker = Console.ReadLine();

            Console.Write("\nNhap ten xe:   ");
            model = Console.ReadLine();

            Console.Write("\nNhap nam san xuat:   ");
           year = int.Parse(Console.ReadLine());
            
            Console.Write("\nNhap gia tien:   ");
            price = double.Parse(Console.ReadLine());

        }
        public virtual void output()
        {
            Console.Write($"{id,10} {maker,15} {model,15} {year,10} {price,10}");
        }

        public override bool Equals(object obj)
        {
            Vehicles ve = (Vehicles)obj;
            return ve.id.Equals(obj);
        }

        public override string ToString()
        {
            return string.Format($"{id,10} {maker,15} {model,15} {year,10} {price,10}");
        }
    }

    class Car:Vehicles
    {
        public string color { get; set; }

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

    class Truck:Vehicles
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
