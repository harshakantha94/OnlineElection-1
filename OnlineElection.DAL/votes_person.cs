//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineElection.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class votes_person
    {
        public System.Guid Person_ID { get; set; }
        public System.Guid Poll_ID { get; set; }
        public Nullable<System.DateTime> vote_date { get; set; }
    
        public virtual Poll Poll { get; set; }
        public virtual person person { get; set; }
    }
}
