using System;

namespace Bài_1._4
{
    class Program
    {
        static double diem;
        static Boolean flag;

        static void Main(string[] args)
        {
            
            Console.WriteLine("\tBang diem");

            Console.WriteLine("\nMoi ban chon: ");
            Console.WriteLine("1. Nhap moi diem cua 1 hoc sinh");
            Console.WriteLine("2. In ket qua cua 1 hoc sinh");
            Console.WriteLine("3. Cap nhap lai diem va in lai ket qua");
            Console.WriteLine("Nham phim bat ki de thoat.\n");
            do
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("\nBan chon \"Nhap diem\":");
                        do
                        {
                            Console.Write("Diem: ");
                            diem = Convert.ToDouble(Console.ReadLine());
                            if (diem < 0 || diem > 10)
                                Console.WriteLine("Diem khong hop le. Moi nhap lai:");
                        } while (diem < 0 || diem > 10);
                        flag = true;
                        break;
                    case 2:
                        Console.WriteLine("\nBan chon \"In ket qua\":");

                        if (diem == null) Console.WriteLine("Ban chua nhap diem.");
                        else
                        {
                            if (diem < 5) Console.WriteLine("\nKet qua xep loai: YEU");
                            if (diem >= 5 && diem < 6.5) Console.WriteLine("\nKet qua xep loai: TRUNG BINH");
                            if (diem >= 6.5 && diem < 8) Console.WriteLine("\nKet qua xep loai: KHA");
                            if (diem >= 8) Console.WriteLine("\nKet qua xep loai: GIOI");
                        }
                        flag = true;
                        break;
                    case 3:
                        Console.WriteLine("\nBan chon \"Cap nhat diem va in lai ket qua\":");
                        if (diem == null) Console.WriteLine("Ban chua nhap diem.");
                        else
                        {
                            Console.Write("Nhap lai diem: ");
                            diem = Convert.ToDouble(Console.ReadLine());

                            if (diem < 5) Console.WriteLine("\nKet qua xep loai: YEU");
                            if (diem >= 5 && diem < 6.5) Console.WriteLine("\nKet qua xep loai: TRUNG BINH");
                            if (diem >= 6.5 && diem < 8) Console.WriteLine("\nKet qua xep loai: KHA");
                            if (diem >= 8) Console.WriteLine("\nKet qua xep loai: GIOI");
                        }
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Ban chon \"Thoat\"." +
                            "Hen gap lai.");
                        flag = false;
                        break;
                }
            } while (flag == true);

        }
    }
}
