using System;

namespace DemoByValByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 6;
            AddOne(ref number);
            Console.WriteLine(number);

            Console.ReadLine();
        }
        static void AddOne(ref int var)
        {
            var++;
        }

    }
}
