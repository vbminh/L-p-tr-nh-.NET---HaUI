using System;

namespace DemoAnonymousType
{
    class Program
    {
        static void Main(string[] args)
        {
            //khai báo đối tượng kiểu vô danh gồm có các thuộc tính: ID, HoTen, Tuoi
            var  sv = new 
            {ID = 123,
             HoTen = "Nguyen Van A",
             Tuoi=20};
            //Lấy giá trị các thuộc tính của đối tượng kiểu vô danh 
            Console.WriteLine("{0}\t{1}", sv.ID, sv.Tuoi);
            


            Console.ReadLine();
        }
    }
}
