using System;

namespace DemoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int no1=0, no2=0;
            Console.Write("\nNhap so nguyen thu 1: ");
            try
            {
                no1 = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nBan phai nhap so thu nhat la so nguyen.");
                Console.ResetColor();
                Console.ReadLine();
                return;
            }
            Console.Write("\nNhap so nguyen thu 2: ");
            try
            {
                no2 = int.Parse(Console.ReadLine());
                double ketQua = Chia2So(no1, no2);

                Console.WriteLine($"\n{no1} : {no2} = {ketQua}");

            }
            catch (FormatException e1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nBan phai nhap so thu hai la so nguyen.");
                Console.ResetColor();
            }
            catch(DivideByZeroException e2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nKhong chia duoc cho 0");
                Console.WriteLine(e2.Message);
                Console.ResetColor();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("\nChua reset lai mau sau thong bao loi so1");

            Console.ReadLine();
        }
        //phương thức chia 2 số nguyên
        private static int Chia2So(int so1, int so2)
        {
            return so1 / so2;
        }
    }
}
