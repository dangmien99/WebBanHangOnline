using System;
using System.Collections.Generic;

#nullable disable

namespace WebBanHangOnline.Models
{
    public partial class ThanhToan
    {
        public ThanhToan()
        {
            DonDatHangs = new HashSet<DonDatHang>();
        }

        public int MaTt { get; set; }
        public string Pttt { get; set; }
        public string Tttt { get; set; }

        public virtual ICollection<DonDatHang> DonDatHangs { get; set; }
    }
}
