using System;
using System.Collections.Generic;

#nullable disable

namespace VuBinhMinh_575.Model
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public int MaPhong { get; set; }
        public string TenPhong { get; set; }

        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
