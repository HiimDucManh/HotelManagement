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
    
    public partial class USER
    {
        public string US_ID { get; set; }
        public string US_USERNAME { get; set; }
        public string US_PASSWORD { get; set; }
        public string STAFF_ID { get; set; }
        public string DISPLAYNAME { get; set; }
        public Nullable<int> ROLE_ID { get; set; }
        public string SOURCES { get; set; }
    
        public virtual STAFF STAFF { get; set; }
        public virtual STAFF STAFF1 { get; set; }
        public virtual USERSROLE USERSROLE { get; set; }
        public virtual USERSROLE USERSROLE1 { get; set; }
    }
}
