using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class NhanVien
    {
        public int MaNv { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public int? MaNd { get; set; }
        public int? MaPq { get; set; }
    }
}
