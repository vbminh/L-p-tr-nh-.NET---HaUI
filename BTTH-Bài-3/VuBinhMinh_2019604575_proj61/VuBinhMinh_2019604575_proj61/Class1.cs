using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_proj61
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public Person( )
        {

        }
        public Person(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public virtual void input()
        {
            Console.Write("\nNhap id:   ");
            id = int.Parse(Console.ReadLine());

            Console.Write("\nNhap ten:  ");
            name = Console.ReadLine();

            Console.Write("\nNhap dia chi:  ");
            address = Console.ReadLine();
        }

        public virtual void output()
        {
            Console.Write($"{id,10} {name,20} {address,20}");
        }
    }
}
