using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH_Minh
{
    class SinhVien
    {
        private string stuID { get; set; }
        private string stuName { get; set; }
        private string stuSex { get; set; }
        private string stuAddress { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string stuID)
        {
            this.stuID = stuID;
        }
        public SinhVien(string stuID, string stuName):this(stuID)
        {
            this.stuName = stuName;
        }

        public SinhVien(string stuID, string stuName,string stuSex) : this(stuID,stuName)
        {
            this.stuSex = stuSex;
        }
        public SinhVien(string stuID, string stuName, string stuSex,string stuAddress) : this(stuID, stuName,stuSex)
        {
            this.stuAddress = stuAddress;
        }

        public override bool Equals(object obj)
        {
            SinhVien sv = (SinhVien)obj;
            return this.stuID.Equals(sv.stuID);
        }
    }
}
