using System;
using System.Collections.Generic;
using System.Text;

namespace VuBinhMinh_2019604575_proj63
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            Boolean flag = true;

            try
            {
                do
                {
                    Console.WriteLine("\n\t============= Menu ============");

                    Console.WriteLine("\n1. Them mot khoa hoc");
                    Console.WriteLine("2. Hien thi cac khoa hoc");
                    Console.WriteLine("3. Tim kiem khoa hoc");
                    Console.WriteLine("4. Tim kiem sinh vien");
                    Console.WriteLine("5. Xoa mot khoa hoc");
                    Console.WriteLine("6. Ket thuc chuong trinh");
                    Console.Write("\nYour choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("\n\t======= Them mot khoa hoc ======\n");

                            Course course1 = new Course();
                            course1.InputCourse();

                            courses.Add(course1);

                            Console.WriteLine("\nNhan \"enter\" de tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 2:
                            Console.WriteLine("\n\t======= Hien thi cac khoa hoc ======");

                            if (courses.Count != 0)
                            {
                                foreach (var item in courses)
                                {
                                    Console.WriteLine("----------------------------------");
                                    item.DisplayCourseAndStudents();
                                }
                            }
                            else
                                Console.WriteLine("\nChua co khoa hoc nao. Hay them mot khoa hoc");

                            Console.WriteLine("\nNhan \"enter\" de tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 3:
                            Console.WriteLine("\n\t======= Tim kiem khoa hoc ======");

                            if (courses.Count != 0)
                            {
                                Console.Write("\nNhap Course ID can tim: ");
                                string courseID3 = Console.ReadLine();
                                int count3 = 0;

                                foreach(Course item in courses)
                                {
                                    if(item.courseID.Equals(courseID3))
                                    {
                                        Console.WriteLine("\nTim thay:");
                                        item.DisplayCourseAndStudents();
                                        count3++;
                                    }    
                                }

                                if (count3 == 0)
                                    Console.WriteLine("\nKhong tim thay khoa hoc co id {0} trong danh sach", courseID3);
                            }
                            else
                                Console.WriteLine("\nChua co khoa hoc nao. Hay them mot khoa hoc");

                            Console.WriteLine("\nNhan \"enter\" de tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 4:
                            Console.WriteLine("\n\t======= Tim kiem mot sinh vien ======");

                            if (courses.Count != 0)
                            {
                                Console.Write("\nNhap Student ID can tim: ");
                                int studentID4 = int.Parse(Console.ReadLine());
                                int count4 = 0;

                                foreach (Course item in courses)
                                {
                                    if (item.studentID == studentID4)
                                    {
                                        Console.WriteLine("\nTim thay:");
                                        item.DisplayCourseAndStudents();
                                        count4++;
                                    }
                                }

                                if (count4 == 0)
                                    Console.WriteLine("\nKhong tim thay sinh vien co id {0} trong danh sach", studentID4);
                            }
                            else
                                Console.WriteLine("\nChua co khoa hoc nao. Hay them mot khoa hoc");

                            Console.WriteLine("\nNhan \"enter\" de tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 5:
                            Console.WriteLine("\n\t======= Xoa mot khoa hoc ======");

                            if (courses.Count != 0)
                            {
                                Console.Write("\nNhap Course ID can xoa: ");
                                string courseID5 = Console.ReadLine();
                                int count5 = 0;

                                for(int i = 0; i < courses.Count; i++)
                                {
                                    if(courses[i].courseID == courseID5)
                                    {
                                        courses.RemoveAt(i);
                                        count5++;
                                        Console.WriteLine("\nXoa thanh cong khoa hoc co id {0}", courseID5);
                                    }    
                                } 

                                if (count5 == 0)
                                    Console.WriteLine("\nKhong tim thay khoa hoc co id {0} trong danh sach", courseID5);
                            }
                            else
                                Console.WriteLine("\nChua co khoa hoc nao.");

                            Console.WriteLine("\nNhan \"enter\" de tiep tuc");
                            Console.ReadLine();
                            flag = true;
                            break;

                        case 6:
                            Console.WriteLine("\nBan chon \"Thoat\".Hen gap lai.");
                            flag = false;
                            break;
                    }

                } while (flag);
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError: " + e.Message);
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
