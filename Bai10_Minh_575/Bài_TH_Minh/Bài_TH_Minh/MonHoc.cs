using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_TH_Minh
{
    class MonHoc
    {
        private string subID { get; set; }
        private string subName { get; set; }
        private string trinhdo { get; set; }

        public MonHoc()
        {

        }
        public MonHoc(string subID)
        {
            this.subID = subID;
        }
        public MonHoc(string subID, string subName) : this(subID)
        {
            this.subName = subName;
        }

        public MonHoc(string subID, string subName, string trinhdo) : this(subID, subName)
        {
            this.trinhdo = trinhdo;
        }
    }
}
