//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteFeshFood
{
    using System;
    using System.Collections.Generic;
    
    public partial class CTHoaDonNhap
    {
        public long MaCTHDNhap { get; set; }
        public string MaHoaDonNhap { get; set; }
        public string MaSP { get; set; }
        public Nullable<double> SoLuong { get; set; }
        public Nullable<double> DonGia { get; set; }
        public Nullable<System.DateTime> HanSuDung { get; set; }
    
        public virtual HoaDonNhap HoaDonNhap { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
