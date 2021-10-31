using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_proj63
{
    class Course:Student
    {
        public string courseID { get; set; }
        protected string courseName { get; set; }
        private int _fee;

        protected int fee
        {
            get { return _fee; }
            set
            {
                if (value > 0)
                    _fee = value;
                else 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nHoc phi phai lon hon 0");
                    Console.ResetColor();
                }
              
            }
        }

        List<Student> listStd;

        public Course()
        {
            listStd = new List<Student>();
        }

        public void InputCourse()
        {
            Console.Write("\nNhap ma khoa hoc: ");
            courseID = Console.ReadLine();

            Console.Write("\nNhap ten khoa hoc: ");
            courseName = Console.ReadLine();

            do
            {
                Console.Write("\nNhap hoc phi: ");
                fee = int.Parse(Console.ReadLine());

                if (fee < 0)
                {
                    Console.Write("\nHoc phi phai lon hon 0. Hay nhap lai");
                }
            } while (fee < 0);

            Console.WriteLine("\n--------Nhap danh sach sinh vien---------\n");
            string n = "";
            while(n != "0")
            {
                Student std = new Student();
                std.inputStudent();

                listStd.Add(std);

                Console.Write("\nNhap \"0\" de ket thuc nhap    ");
                n = Console.ReadLine();
            }
        }

        public void DisplayCourseAndStudents()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("\nCourse ID: " + courseID);
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Fee: " + fee);

            Console.WriteLine("\n\t========Student=========\n");
            Console.WriteLine($"{"ID",-8} {"Name",-10} {"Mark",5}");
            
            foreach(Student item in listStd)
            {
                Console.WriteLine(item);
            }
        }
        public List<Student> GetAllStudents()
        {
            return listStd;
        }

    }

}
