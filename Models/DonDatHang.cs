using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class DonDatHang
    {
        public DonDatHang()
        {
            ChiTietDonHangs = new HashSet<ChiTietDonHang>();
            VanChuyens = new HashSet<VanChuyen>();
        }

        public int MaDh { get; set; }
        public int MaKh { get; set; }
        public DateTime? NgayDh { get; set; }
        public string TrangThaiDh { get; set; }
        public int MaTt { get; set; }
        public string Dcgh { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual ThanhToan MaTtNavigation { get; set; }
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual ICollection<VanChuyen> VanChuyens { get; set; }
    }
}
