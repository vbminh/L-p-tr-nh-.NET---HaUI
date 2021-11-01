using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de2_Minh_575
{
    class KhachHangVip:KhachHang
    {
        public KhachHangVip():base()
        {

        }

        public KhachHangVip(string MaKH) : base(MaKH)
        {

        }

        public KhachHangVip(string MaKH, DateTime Ngaysinh) : base(MaKH,Ngaysinh)
        {

        }

        public KhachHangVip(string MaKH, DateTime Ngaysinh, int slmua) : base(MaKH, Ngaysinh,slmua)
        {

        }

        public KhachHangVip(string MaKH, DateTime Ngaysinh, int slmua, Double dongia) : base(MaKH, Ngaysinh,slmua,dongia)
        {

        }

        public override Double tongtien()
        {
            double tongtien = slmua * dongia;
            if (tongtien <= 1000)
                tongtien -= tongtien * 0.1;
            else
                tongtien -= tongtien * 0.2;
            return tongtien;
        }

        public override string ToString()
        { 
            return base.ToString();
        }
    }
}
