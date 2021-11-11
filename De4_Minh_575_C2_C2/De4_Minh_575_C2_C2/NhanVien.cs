using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De4_Minh_575_C2_C2
{
    class NhanVien:IComparable
    {
        private string _hoten;
        private DateTime _ngaytuyendung;

        protected string hoten
        {
            get { return _hoten; }
            set { _hoten = value; }
        }

        protected DateTime ngaytuyendung
        {
            get { return _ngaytuyendung; }
            set
            {
                if(value < DateTime.Today)
                {
                    _ngaytuyendung = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nNgay tuyen dung phai nho hon ngay hien tai");

                    Console.ResetColor();
                }
            }
        }

        public NhanVien()
        {

        }

        public NhanVien(string hoten)
        {
            this.hoten = hoten;
        }

        public NhanVien(string hoten, DateTime ngaytuyendung):this(hoten)
        {
            this.ngaytuyendung = ngaytuyendung;
        }

        public override string ToString()
        {
            return string.Format($"{hoten,-20} {ngaytuyendung:d}\t {"-",15} {"-",15}");
        }

        public override bool Equals(object obj)
        {
            NhanVien nv = (NhanVien)obj;
            return this.hoten.Equals(nv.hoten);
        }

        public int CompareTo(object obj)
        {
            NhanVien nv = (NhanVien)obj;
            return this.ngaytuyendung.CompareTo(nv.ngaytuyendung);
        }

        public string name()
        {
            return hoten;
        }
    }

    class CompareToName : IComparer<NhanVien>
    {
        public int Compare(NhanVien x, NhanVien y)
        {
            return x.name().CompareTo(y.name());
        }
    }
}
