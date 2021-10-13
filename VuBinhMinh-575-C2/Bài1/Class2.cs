using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài1
{
    class SinhVien:Person
    {
        private double _diemtb;
        public double diemtb
        {
            get
            {
                return _diemtb;
            }
            set
            {
                if (0 <= value && value <= 10)
                    _diemtb = value;
                else
                    throw new Exception("\nDiem trung binh phai lon hon 0 va nho hon 10");
            }
        }

        public SinhVien()
        {

        }

        public SinhVien(string hoten, string gioitinh, int namsinh, string diachi, double diemtb) : base(hoten,gioitinh,namsinh,diachi)
        {
            this.diemtb = diemtb;
        }

        public string diemchu()
        {
            string diemchu = "";
            if (diemtb >= 8.5)
                diemchu = "A";

            if (diemtb >= 6.5 && diemtb < 8.5)
                diemchu = "B";

            if (diemtb >= 5.5 && diemtb < 6.5)
                diemchu = "C";

            if (diemtb >= 4 && diemtb < 5.5)
                diemchu = "D";

            if (diemtb < 4)
                diemchu = "F";

            return diemchu;
        }

        public override void input()
        {
            base.input();

            Console.Write("\nNhap diem trung binh:  ");
            diemtb = double.Parse(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine($"{diemchu(),10}");
        }
    }
}
