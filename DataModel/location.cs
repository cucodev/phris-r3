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
    
    public partial class location
    {
        public int ID { get; set; }
        public string codeNumParent { get; set; }
        public Nullable<long> codeNum { get; set; }
        public string codeISOParent { get; set; }
        public string codeISO { get; set; }
        public string codeUN { get; set; }
        public string dialingCode { get; set; }
        public Nullable<int> locationType { get; set; }
        public string locationName { get; set; }
    }
}