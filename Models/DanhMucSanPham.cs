using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class DanhMucSanPham
    {
        public DanhMucSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public int MaDm { get; set; }
        public string TenDm { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
