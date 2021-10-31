using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_BonusBuoi6
{
    class NhanVienHopDong:NhanVien
    {
        private int _hour;
        public int hour
        {
            get { return _hour; }
            set
            {
                if (value > 0)
                    _hour = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nSo gio lam viec phai lon hon 0");
                    Console.ResetColor();
                }
            }
        }

        private Double _salaryPerHour;
        public Double salaryPerHour
        {
            get { return _salaryPerHour; }
            set
            {
                if (value > 0)
                    _salaryPerHour = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nLuong 1 gio phai lon hon 0");
                    Console.ResetColor();
                }
            }
        }

        public NhanVienHopDong():base()
        {

        }

        public NhanVienHopDong(string id, string name):base(id,name)
        {

        }

        public NhanVienHopDong(string id, string name,int birth) : base(id, name,birth)
        {

        }

        public NhanVienHopDong(string id, string name, int birth, int hour) : base(id, name, birth)
        {
            this.hour = hour;
        }

        public NhanVienHopDong(string id, string name, int birth, int hour, Double salaryPerHour):base(id,name,birth)
        {
            this.hour = hour;
            this.salaryPerHour = salaryPerHour;
        }

        public double salary()
        {
            return (double)hour * salaryPerHour;
        }

        public override string ToString()
        {
            return base.ToString() + string.Format($"{hour,20} {salaryPerHour,20} {salary(),20}");
        }
    }
}
