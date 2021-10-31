using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VuBinhMinh_2019604575_BonusBuoi6
{
    class NhanVien:IComparable
    {
        public string id { get; set; }
        public string name { get; set; }

        private int _birth;
        public int birth 
        {
            get { return _birth; }
            set
            {
                if (value > 0)
                    _birth = value;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    throw new Exception("\nNam sinh phai lon hon 0");
                    Console.ResetColor();
                }    
            }
        }

        public NhanVien()
        {

        }

        public NhanVien(string id)
        {
            this.id = id;
        }
        public NhanVien(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public NhanVien(string id, string name, int birth)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
        }

        public override string ToString()
        {
            return string.Format($"{id,-8} {name,-20} {birth,20}");
        }

        public override bool Equals(object obj)
        {
            NhanVien nv = (NhanVien)obj;
            return this.id.Equals(nv.id);
        }

        public int CompareTo(object obj)
        {
            NhanVien nv = (NhanVien)obj;
            return this.name.CompareTo(nv.name);
        }
    }

}
