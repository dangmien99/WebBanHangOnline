using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DanhGiaKhs = new HashSet<DanhGiaKh>();
            DonDatHangs = new HashSet<DonDatHang>();
        }

        public int MaKh { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string Dc { get; set; }
        public string Email { get; set; }
        public int? MaPq { get; set; }

        public virtual ICollection<DanhGiaKh> DanhGiaKhs { get; set; }
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
