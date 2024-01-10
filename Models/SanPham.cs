using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public int? GiaThanh { get; set; }
        public string Anh { get; set; }
        public string MaTh { get; set; }
        public int? SoLuong { get; set; }
        public string MaDm { get; set; }

        public virtual DanhMucSanPham MaDmNavigation { get; set; }
        public virtual ThuongHieu MaThNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}
