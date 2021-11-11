using System;

namespace DemoFunc
{
    class Program
    {

        static void Main(string[] args)
        {
            //2. Khởi tạo ủy quyền
            Func<double,string> uq1;
            uq1 = (double diemTK) =>
            {
                if (diemTK < 4)
                    return "F";
                else if (diemTK < 5.5)
                    return "D";
                else if (diemTK < 7)
                    return "C";
                else if (diemTK < 8.5)
                    return "B";
                else
                    return "A";
            };
            //3. Gọi ủy quyền --> thực thi phương thức XacDinhDiemChu
            Console.WriteLine(uq1(3.5));

            Console.ReadLine();
        }


    }
}
