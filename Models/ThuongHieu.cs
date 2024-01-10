using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class ThuongHieu
    {
        public ThuongHieu()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaTh { get; set; }
        public string TenTh { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
