using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t=======Student=======");

            Student st1 = new Student("001");
            Console.WriteLine("\nStudent 1:");

            Console.WriteLine($"{"id",5} {"name",20} {"mark",5} {"schoolarship",15}\n");
            st1.output();

            Student st2 = new Student("002", "Nguyen Van A", 9);
            Console.WriteLine("\n\nStudent 2:");

            Console.WriteLine($"{"id",5} {"name",20} {"mark",5} {"schoolarship",15}\n");
            st2.output();

            Student st3 = new Student();
            Console.WriteLine("");
            st3.input();
            Console.WriteLine("\n\nStudent 3:");

            Console.WriteLine($"{"id",5} {"name",20} {"mark",5} {"schoolarship",15}\n");
            st3.output();

            Console.ReadKey();
        }
    }
}
