using System;

namespace DemoStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.id = 123;
            student1.name = "An";
            student1.age = 25;

            Console.WriteLine("{0}\t{1}\t{2}", student1.id, student1.name, student1.age);
            Console.ReadLine();
        }
    }

    struct Student
    {
        public int id;
        public string name;
        public int age;
    };

}
