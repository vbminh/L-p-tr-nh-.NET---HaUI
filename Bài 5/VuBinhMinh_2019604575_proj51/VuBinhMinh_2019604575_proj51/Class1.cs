using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_proj51
{
    class ThisinhA
    {
        public string sobd { get; set; }
        public string hoten { get; set; }
        public string diachi { get; set; }

        private double _toan;
        private double _ly;
        private double _hoa;
        private double _diemut;
        public double toan
        {
            get
            {
                return _toan;
            }
            set
            {
                if (0 <= value && value <= 10)
                    _toan = value;
                else
                    throw new Exception("\nDiem toan phai lon hon 0 va nho hon 10");
            }
        }
        public double ly
        {
            get
            {
                return _ly;
            }
            set
            {
                if (0 <= value && value <= 10)
                    _ly = value;
                else
                    throw new Exception("\nDiem ly phai lon hon 0 va nho hon 10");
            }
        }
        public double hoa
        {
            get
            {
                return _hoa;
            }
            set
            {
                if (0 <= value && value <= 10)
                    _hoa = value;
                else
                    throw new Exception("\nDiem hoa phai lon hon 0 va nho hon 10");
            }
        }
        public double diemut
        {
            get
            {
                return _diemut;
            }
            set
            {
                if (0 <= value && value <= 10)
                    _diemut = value;
                else
                    throw new Exception("\nDiem uu tien phai lon hon 0 va khong vuot qua 4d");
            }
        }

        public ThisinhA()
        {

        }

        public ThisinhA(string sobd, string hoten, string diachi, double toan, double ly, double hoa, double diemut)
        {
            this.sobd = sobd;
            this.hoten = hoten;
            this.diachi = diachi;
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
            this.diemut = diemut;
        }

        public double tongdiem(double toan, double ly, double hoa, double diemut)
        {
            return toan + ly + hoa + diemut;
        }

        public void input()
        {
            Console.Write("\nNhap so bao danh: ");
            sobd = Console.ReadLine();
            Console.Write("\nNhap ho ten thi sinh: ");
            hoten = Console.ReadLine();
            Console.Write("\nNhap dia chi: ");
            diachi = Console.ReadLine();
            try
            {
                do
                {
                    Console.Write("\nNhap diem toan: ");
                    toan = double.Parse(Console.ReadLine());

                    if (toan < 0 || toan > 10)
                        Console.WriteLine("\nDiem nhap khong hop le. Moi nhap lai");
                } while (toan < 0 || toan > 10);

                do
                {
                    Console.Write("\nNhap diem ly: ");
                    ly = double.Parse(Console.ReadLine());

                    if (ly < 0 || ly > 10)
                        Console.WriteLine("\nDiem nhap khong hop le. Moi nhap lai");
                } while (ly < 0 || ly > 10);

                do
                {
                    Console.Write("\nNhap diem toan: ");
                    hoa = double.Parse(Console.ReadLine());

                    if (hoa < 0 || hoa > 10)
                        Console.WriteLine("\nDiem nhap khong hop le. Moi nhap lai");
                } while (hoa < 0 || hoa > 10);

                do
                {
                    Console.Write("\nNhap diem uu tien: ");
                    hoa = double.Parse(Console.ReadLine());

                    if (diemut < 0)
                        Console.WriteLine("\nDiem uu tien khong hop le. Moi nhap lai");
                    if(diemut > 4)
                        Console.WriteLine("\nDiem uu tien khong qua 4d. Moi nhap lai");
                } while (diemut < 0 || diemut > 4);
            }
            catch(Exception)
            {
                Console.WriteLine("\nLoi: Diem cua thi sinh phai la 1 so");
            }
        }

        public void output()
        {
            Console.WriteLine($"{sobd,10} {hoten,20} {diachi,15} {toan,5} {ly,5} {hoa,5} {diemut,10} {tongdiem(toan, ly, hoa,diemut),10}");
        }
    }
}
