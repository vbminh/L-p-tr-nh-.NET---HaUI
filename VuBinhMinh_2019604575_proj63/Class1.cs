using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_proj63
{
    class Student
    {
        public int studentID { get; set; }
        protected string studentName { get; set; }
        protected string mark { get; set; }

        public override string ToString()
        {
            return string.Format($"{studentID,-8} {studentName, -10} {mark,5}");
        }

        public void inputStudent()
        {
            Console.Write("\nNhap ma sinh vien: ");
            studentID = int.Parse(Console.ReadLine());

            Console.Write("\nNhap ten sinh vien: ");
            studentName = Console.ReadLine();

            Console.Write("\nNhap diem: ");
            mark = Console.ReadLine();
        }
    }
}
