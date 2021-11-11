using System;

namespace DemLambda
{
    class Program
    {
        //1. Khai báo delegate tham chiếu đến các phương thức có 
        //1 tham số đầu vào kiểu double và trả về kiểu string
        private delegate string UyQuyen(double so);

        static void Main(string[] args)
        {
            //tạo phương thức vô danh băng biểu thức lamda
            //2. Khởi tạo ủy quyền
            UyQuyen uq1;
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

            ////Gọi phương thức XacDinhDiemChu theo cách thông thường
            //Console.WriteLine(XacDinhDiemChu(3.5));

            Console.ReadLine();
        }


    }
}
