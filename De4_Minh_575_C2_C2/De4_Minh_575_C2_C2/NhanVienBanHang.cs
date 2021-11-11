using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De4_Minh_575_C2_C2
{
    class NhanVienBanHang:NhanVien
    {
        private int _soluongban;

        protected int soluongban
        {
            get { return _soluongban; }
            set
            {
                if (value > 0)
                    _soluongban = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nSo luong ban phai lon hon 0");
                    Console.ResetColor();
                }
            }
        }

        public NhanVienBanHang():base()
        {

        }
        public NhanVienBanHang(string hoten) : base(hoten)
        {

        }
        public NhanVienBanHang(string hoten, DateTime ngaytuyendung) : base(hoten,ngaytuyendung)
        {

        }
        public NhanVienBanHang(string hoten, DateTime ngaytuyendung, int soluongban) : base(hoten, ngaytuyendung)
        {
            this.soluongban = soluongban;
        }

        Func<int, double> tienhoahong = (int x) =>
        {
            int tongtien = 0;
            if (x < 100)
                tongtien = 1000;
            else if (x < 500)
                tongtien = 2000;
            else
                tongtien = 3000;

            return tongtien;
        };

        public override string ToString()
        {
            return string.Format($"{hoten,-20} {ngaytuyendung:d}\t {soluongban,15} {tienhoahong(soluongban),15}");
        }
    }
}
