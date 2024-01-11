using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DanhGia = new HashSet<DanhGium>();
            DonDatHangs = new HashSet<DonDatHang>();
        }

        public int MaKh { get; set; }
        public string TenKh { get; set; }
        public string Sdt { get; set; }
        public string Dc { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DanhGium> DanhGia { get; set; }
        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
