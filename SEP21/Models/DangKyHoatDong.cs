//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SEP21.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DangKyHoatDong
    {
        public int ID { get; set; }
        public int HoatDong { get; set; }
        public string MSSV { get; set; }
        public System.DateTime ThoiGianDangKy { get; set; }
        public string hd_mssv { get; set; }
    
        public virtual BaiViet BaiViet { get; set; }
    }
}