using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string id { get; set; }
        private string name { get; set; }
        private int mark { get; set; }

        private int schoolarship;
     
        public Student()
        {

        }

        public Student(string id)
        {
            this.id = id;
        }

        public Student(string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }

        public void input()
        {
            Console.Write("\nNhap ma sv: ");
            id = Console.ReadLine();
            Console.Write("\nNhap ho ten sv: ");
            name = Console.ReadLine();
            do
            {
                Console.Write("\nNhap diem: ");
                mark = int.Parse(Console.ReadLine());

                if (mark < 0 || mark > 10)
                    Console.WriteLine("\nDiem khong hop le. Moi nhap lai");
            } while (mark < 0 || mark > 10);
        }

        public void output()
        {
            if (mark > 8) schoolarship = 500;
            else
            {
                if (mark >= 7 && mark <= 8) schoolarship = 300;
                else schoolarship = 0;
            }
            Console.WriteLine($"{id,5} {name,20} {mark,5} {schoolarship,15}");
        }
    }
}
