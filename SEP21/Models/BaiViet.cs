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
    
    public partial class BaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BaiViet()
        {
            this.DangKyHoatDongs = new HashSet<DangKyHoatDong>();
        }
    
        public int ID { get; set; }
        public System.DateTime NgayDangBai { get; set; }
        public string TieuDe { get; set; }
        public string NoiDung { get; set; }
        public int LoaiBaiViet { get; set; }
        public string picture { get; set; }
        public string Title { get; set; }
    
        public virtual LoaiBaiViet LoaiBaiViet1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DangKyHoatDong> DangKyHoatDongs { get; set; }
    }
}
