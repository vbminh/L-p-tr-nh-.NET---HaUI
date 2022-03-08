using System;
using System.Collections.Generic;

#nullable disable

namespace Bai11._1_Minh.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public string MaHang { get; set; }
        public string TenHang { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
