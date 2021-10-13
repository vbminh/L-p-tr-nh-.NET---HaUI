using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài1
{
    class Person
    {
        public string hoten { get; set; }
        public string gioitinh { get; set; }
        public int namsinh { get; set; }
        public string diachi { get; set; }

        public Person()
        {

        }

        public Person(string hoten, string gioitinh, int namsinh, string diachi)
        {
            this.hoten = hoten;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.diachi = diachi;
        }

        public virtual void input()
        {
            Console.Write("\nNhap ho ten:   ");
            hoten = Console.ReadLine();
            Console.Write("\nNhap gioi tinh:    ");
            gioitinh = Console.ReadLine();
            Console.Write("\nNhap nam sinh:   ");
            namsinh = int.Parse(Console.ReadLine());
            Console.Write("\nNhap dia chi:   ");
            diachi = Console.ReadLine();
        }

        public virtual void output()
        {
            Console.Write($"{hoten,20} {gioitinh,10} {namsinh,10} {diachi,10}");
        }
    }
}
