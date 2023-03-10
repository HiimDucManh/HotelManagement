//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhachSan.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROOM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROOM()
        {
            this.BILLs = new HashSet<BILL>();
            this.BOOKROOMs = new HashSet<BOOKROOM>();
            this.BOOKROOMs1 = new HashSet<BOOKROOM>();
        }
    
        public string RO_ID { get; set; }
        public string RO_TYPE { get; set; }
        public Nullable<decimal> PRICE_HOUR { get; set; }
        public Nullable<decimal> PRICE_DAY { get; set; }
        public Nullable<decimal> PRICE_NIGHT { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILL> BILLs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKROOM> BOOKROOMs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BOOKROOM> BOOKROOMs1 { get; set; }
    }
}
