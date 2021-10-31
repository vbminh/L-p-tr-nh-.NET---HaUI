using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoooo
{
    class TinhLuong
    {
        protected string Hoten { get; set; }
        protected string Diachi { get; set; }

        private double _HsLuong;

        protected double HsLuong
        {
            get { return _HsLuong; }
            set
            {
                if (value > 0)
                    _HsLuong = value;
                else
                    throw new Exception("He so luong phai lon hon 0");
            }
        }

        protected static double Luong = 1000000;

        public TinhLuong()
        {

        }

        public TinhLuong(string name, string address)
        {
            Hoten = name;
            Diachi = address;
        }

        public virtual double tinhluong()
        {
            return HsLuong * Luong;
        }

    }
}
