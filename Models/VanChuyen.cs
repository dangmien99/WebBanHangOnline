using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class VanChuyen
    {
        public int MaVc { get; set; }
        public string TenNguoiVc { get; set; }
        public string Sdt { get; set; }
        public int MaDh { get; set; }

        public virtual DonDatHang MaDhNavigation { get; set; }
    }
}
