//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appeal
    {
        public Appeal()
        {
            this.UserAppeals = new HashSet<UserAppeal>();
        }
    
        public int Id { get; set; }
        public string AppliedFor { get; set; }
        public int Sid { get; set; }
    
        public virtual Service Service { get; set; }
        public virtual ICollection<UserAppeal> UserAppeals { get; set; }
    }
}