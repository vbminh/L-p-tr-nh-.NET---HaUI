using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH_Minh
{
    class Diem
    {
        private string masv { get; set; }

        private double _diemlt;

        protected double diemlt
        {
            get { return _diemlt; }
            set
            {
                if (value >= 0)
                    _diemlt = value;
                else
                    throw new Exception("Điểm lý thuyết không hợp lệ");
            }
        }

        private double _diemth;

        protected double diemth
        {
            get { return _diemth; }
            set
            {
                if (value >= 0)
                    _diemth = value;
                else
                    throw new Exception("Điểm thực hành không hợp lệ");
            }
        }

        private double _diemut;

        protected double diemut
        {
            get { return _diemut; }
            set
            {
                if (value >= 0 && value <=2)
                    _diemut = value;
                else
                    throw new Exception("Điểm ưu tiên không hợp lệ");
            }
        }

        public Diem()
        {

        }

        public Diem(string masv)
        {
            this.masv = masv;
        }

        public Diem(string masv, double diemlt):this(masv)
        {
            this.diemlt = diemlt;
        }
        public Diem(string masv, double diemlt, double diemth) : this(masv,diemlt)
        {
            this.diemth = diemth;
        }
        public Diem(string masv, double diemlt, double diemth, double diemut) : this(masv,diemlt,diemth)
        {
            this.diemut = diemut;
        }
    }
}
