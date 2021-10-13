using System;

namespace DemoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string chuoi = "Abc";
            double so = 1230.4567;
            DateTime ngayThang = DateTime.Now;

            string chuoiDinhDang = 
                String.Format("{0,-10}{1,-15:N2}{2,15:D}",chuoi, so, ngayThang);

            Console.WriteLine(chuoiDinhDang);

            Console.ReadLine();
        }
    }
}
