using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2_Minh_575
{
    class KhachHang
    {
        private string _MaKH;
        private DateTime _Ngaysinh;
        private int _slmua;
        private double _dongia;

        protected string MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        protected DateTime Ngaysinh
        {
            get { return _Ngaysinh; }
            set
            {
                if (value < DateTime.Today)
                    _Ngaysinh = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nNgay sinh phai nho hon ngay hien tai");
                    Console.ResetColor();
                }
            }
        }

        protected int slmua
        {
            get { return _slmua; }
            set
            {
                if (value > 0)
                    _slmua = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nSo luong mua phai lon hon 0");
                    Console.ResetColor();
                }
            }
        }

        protected Double dongia
        {
            get { return _dongia; }
            set
            {
                if (value > 0)
                    _dongia = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nDon gia phai lon hon 0");
                    Console.ResetColor();
                }
            }
        }

        public KhachHang()
        {

        }

        public KhachHang(string MaKH):this()
        {
            this.MaKH = MaKH;
        }

        public KhachHang(string MaKH, DateTime Ngaysinh):this(MaKH)
        {
            this.Ngaysinh = Ngaysinh;
        }

        public KhachHang(string MaKH, DateTime Ngaysinh, int slmua) : this(MaKH,Ngaysinh)
        {
            this.slmua = slmua;
        }

        public KhachHang(string MaKH, DateTime Ngaysinh, int slmua, double dongia) : this(MaKH, Ngaysinh,slmua)
        {
            this.dongia = dongia;
        }

        public virtual Double tongtien()
        {
            return (Double)slmua * dongia;
        }

        public override bool Equals(object obj)
        {
            KhachHang kh = (KhachHang)obj;
            return this.MaKH.Equals(kh.MaKH);
        }

        public override string ToString()
        {
            return string.Format($"{MaKH,-8} {Ngaysinh:dd MM yyyy}\t {slmua,10} {dongia,10} {tongtien(),10}");
        }
    }
}
