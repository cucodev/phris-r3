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
    
    public class C_purposeEntities
    {
       
        public int purposeID { get; set; }
        public string purposeName { get; set; }
        public string purposeDescription { get; set; }
    
        public virtual ICollection<C_transactionEntities> C_transaction { get; set; }
    }
}