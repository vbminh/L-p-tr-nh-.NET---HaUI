using System;
using System.Collections.Generic;

#nullable disable

namespace De2_Minh_575.Models
{
    public partial class KhachHang
    {
        public string MaKh { get; set; }
        public DateTime? NgayMua { get; set; }
        public int? SoLuongMua { get; set; }
        public double? DonGia { get; set; }
    }
}
