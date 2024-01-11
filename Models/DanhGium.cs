using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class DanhGium
    {
        public int MaDg { get; set; }
        public int MaKh { get; set; }
        public string DanhGia { get; set; }
        public int? DiemDanhGia { get; set; }
        public DateTime? NgayDanhGia { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
    }
}
