using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class ChiTietDonHang
    {
        public int MaCtdh { get; set; }
        public int? MaDh { get; set; }
        public int? MaSp { get; set; }
        public int? Sl { get; set; }
        public int? DonGia { get; set; }
        public int? ThanhTien { get; set; }

        public virtual DonDatHang MaDhNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
