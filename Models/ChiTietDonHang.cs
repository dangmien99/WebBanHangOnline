using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class ChiTietDonHang
    {
        public string MaCtdh { get; set; }
        public string MaDh { get; set; }
        public string MaSp { get; set; }
        public int? Sl { get; set; }
        public int? DonGia { get; set; }
        public int? ThanhTien { get; set; }

        public virtual DonDatHang MaDhNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
