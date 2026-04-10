using System;
using System.Collections.Generic;

namespace PMT_BTDBFirst.Models;

public partial class KhachHang
{
    public int MaKh { get; set; }

    public string? TenKh { get; set; }

    public virtual ICollection<DonHang> DonHangs { get; set; } = new List<DonHang>();
}
