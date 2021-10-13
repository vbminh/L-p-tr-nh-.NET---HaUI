using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_1
{
    class Person
    {
        private string id { get; set; }
        private string name { get; set; }
        private int age { get; set; }
        private string email { get; set; }
        private string address { get; set; }

        public Person()
        {

        }

        public Person(string id, string name, int age, string email, string address)
        {
            this.id = id;
            this.name = name;;
            this.age = age;
            this.email = email;
            this.address = address;
        }

        public void checkAge()
        {
            if (age > 18)
                Console.WriteLine("\nBan du tuoi bau cu");
            else
                Console.WriteLine("\nBan con nho");
        }

        public override string ToString()
        {
            return "id: " + id + "\nname: " + name + "\nage: " + age + "\nemail: " + email + "\naddress: " + address;
        }

        public void input()
        {
            Console.Write("\nNhap id: ");
            id = Console.ReadLine();

            Console.Write("\nNhap name: ");
            name = Console.ReadLine();

            Console.Write("\nNhap age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("\nNhap email: ");
            email = Console.ReadLine();

            Console.Write("\nNhap address: ");
            address = Console.ReadLine();
        }

        public void output()
        {
            Console.WriteLine("\n\t========Person Information==========");

            Console.WriteLine("\nid: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("age: " + age);
            Console.WriteLine("email: " + email);
            Console.WriteLine("address: " + address);
        }

    }
}
