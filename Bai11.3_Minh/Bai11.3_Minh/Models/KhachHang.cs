﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Bai11._3_Minh.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string SoDt { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
