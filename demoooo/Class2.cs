using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoooo
{
    class NhanVien:TinhLuong
    {
        protected string Manv { get; set; }
        protected string Chucvu { get; set; }

        public NhanVien():base()
        {

        }

        public NhanVien(string name, string address, string id, string position):base(name, address)
        {
            Manv = id;
            Chucvu = position;
        }

        public override double tinhluong()
        {
            double phucapluong = 0;
            if(Chucvu == "Giam doc")
                phucapluong = 0.5;
                
            if (Chucvu == "Truong phong" || Chucvu == "Pho giam doc")
                phucapluong = 0.4;

            if (Chucvu == "Pho phong")
                phucapluong = 0.3;

            return (HsLuong + phucapluong) * Luong;
        }

        public override string ToString()
        {
            return string.Format($"{Manv,-8} {Hoten,-20} {Diachi,20} {Chucvu,15} {tinhluong(),10}");
        }

    }
}
