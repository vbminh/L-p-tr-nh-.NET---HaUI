using System;

namespace Bài_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double S, P;

            Console.WriteLine("\t\tTinh dien tich tam giac");
            Console.WriteLine("\nNhap do dai 3 canh: ");
            do
            {
                do
                {
                    Console.Write("a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    if (a <= 0) Console.WriteLine("Do dai canh phai lon hon 0. Moi nhap lai: ");
                } while (a <= 0);

                do
                {
                    Console.Write("b = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    if (b <= 0) Console.WriteLine("Do dai canh phai lon hon 0. Moi nhap lai: ");
                } while (b <= 0);

                do
                {
                    Console.Write("c = ");
                    c = Convert.ToDouble(Console.ReadLine());
                    if (c <= 0) Console.WriteLine("Do dai canh phai lon hon 0. Moi nhap lai: ");
                } while (c <= 0);

                if (a + b <= c || a + c <= b || b + c <= a)
                    Console.WriteLine("Tong hai canh bat ki phai lon hon canh con lai. Moi nhap lai: ");
            } while (a + b < c || a + c < b || b + c < a);


            P = (a + b + c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

            Console.WriteLine("\nDien tich cua tam giac co do dai 3 canh a = {0}, b = {1}, c = {2} la: {3}", a, b, c, S);
            Console.ReadLine();
        }
    }
}
