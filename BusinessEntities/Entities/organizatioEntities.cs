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

    public class organization
    {
       
        public int orgID { get; set; }
        public int orgParentID { get; set; }
        public string orgCode { get; set; }
        public string orgName { get; set; }
        public string orgLocation { get; set; }
    
        public virtual ICollection<personEntities> people { get; set; }
    }
}
