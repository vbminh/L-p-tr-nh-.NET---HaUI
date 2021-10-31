using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_project62
{
    class Vehicles : IVehiche, IComparable
    {
        public string id { get; set; }
        public string maker { get; set; }
        protected string model { get; set; }

        private int _year;
        public int year
        {
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
        protected double price
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

        public Vehicles():base()
        {

        }

        public Vehicles(string id)
        {
            this.id = id;
        }

        public Vehicles(string id, string maker, string model, int year, double price) : this(id)
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
            return (this.id.Equals(ve.id));
        }

        public override string ToString()
        {
            return string.Format($"{id,10} {maker,15} {model,15} {year,10} {price,10}");
        }

        public int CompareTo(object obj)
        {
            Vehicles vh = (Vehicles)obj;
            return (this.price.CompareTo(vh.price));
        }
    }

    class sortbyyear : IComparer<Vehicles>
    {
        public int Compare(Vehicles x, Vehicles y)
        {
            return (x.year - y.year);
        }
    }
}
