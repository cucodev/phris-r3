//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class personAddress
    {
        public int ID { get; set; }
        public Nullable<int> IDV { get; set; }
        public string Address { get; set; }
        public string AddressPhone { get; set; }
        public string AddressKel { get; set; }
        public Nullable<int> AddressKec { get; set; }
        public Nullable<int> AddressKab { get; set; }
        public Nullable<int> AddressProv { get; set; }
        public Nullable<int> AddressCountry { get; set; }
        public Nullable<int> AddressPostalCode { get; set; }
        public Nullable<int> vCreatedBy { get; set; }
        public Nullable<int> vUpdatedBy { get; set; }
        public Nullable<int> isDeleted { get; set; }
    
        public virtual person person { get; set; }
    }
}