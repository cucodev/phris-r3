//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusinessEntities
{
    using System;
    using System.Collections.Generic;
    
    public  class personCertificationEntities
    {
        public int ID { get; set; }
        public Nullable<int> IDV { get; set; }
        public string certificationName { get; set; }
        public Nullable<int> issuedCountry { get; set; }
        public Nullable<int> issuedCity { get; set; }
        public Nullable<System.DateTime> issuedDate { get; set; }
        public Nullable<System.DateTime> issuedExpiredDate { get; set; }
        public Nullable<int> vCreatedBy { get; set; }
        public Nullable<int> vUpdatedBy { get; set; }
        public Nullable<int> isDeleted { get; set; }
        public Nullable<System.DateTime> createTime { get; set; }
        public Nullable<System.DateTime> updateTime { get; set; }

        public virtual personEntities person { get; set; }
    }
}
