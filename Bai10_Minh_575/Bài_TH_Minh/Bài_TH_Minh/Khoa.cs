using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH_Minh
{
    class Khoa
    {
        private string khoaID { get; set; }
        private string khoaName { get; set; }
        private string truongkhoa { get; set; }
        private string vanphong { get; set; }

        public Khoa()
        {

        }
        public Khoa(string khoaID)
        {
            this.khoaID = khoaID;
        }
        public Khoa(string khoaID, string khoaName) : this(khoaID)
        {
            this.khoaName = khoaName;
        }

        public Khoa(string khoaID, string khoaName, string truongkhoa) : this(khoaID, khoaName)
        {
            this.truongkhoa = truongkhoa; ;
        }
        public Khoa(string khoaID, string khoaName, string truongkhoa, string vanphong) : this(khoaID,khoaName,truongkhoa)
        {
            this.vanphong = vanphong;
        }

        public override bool Equals(object obj)
        {
            Khoa khoa = (Khoa)obj;
            return this.khoaID.Equals(khoa.khoaID);
        }
    }
}
