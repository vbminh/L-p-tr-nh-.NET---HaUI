using System;
using System.Collections.Generic;

#nullable disable

namespace Bai11._1_Minh.Models
{
    public partial class Product
    {
        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public double? DonGia { get; set; }
        public string Mau { get; set; }
        public string MaHang { get; set; }

        public virtual Brand MaHangNavigation { get; set; }
    }
}
