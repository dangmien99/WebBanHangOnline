using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class DanhGiaKh
    {
        public int MaDg { get; set; }
        public int MaKh { get; set; }
        public string NoiDung { get; set; }
        public int? DiemDanhGia { get; set; }
        public DateTime? NgayDanhGia { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
    }
}
