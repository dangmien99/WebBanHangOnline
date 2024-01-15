using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class GioHang
    {
        public int MaGio { get; set; }
        public int? MaKh { get; set; }
        public int? MaSp { get; set; }
        public int? Sl { get; set; }
        public int? GiaThanh { get; set; }
        public DateTime? NgayThem { get; set; }
        public string Anh { get; set; }
        public string Ten { get; set; }
        public int? Total
        {
            get {return Sl*GiaThanh; }
        }
        public GioHang()
        {

        }
        public GioHang(SanPham sanPham)
        {
            MaSp = sanPham.MaSp;
            Sl = 1;
            GiaThanh = sanPham.GiaThanh;
            Anh = sanPham.Anh;
            Ten = sanPham.TenSp;
        }
    }
}
