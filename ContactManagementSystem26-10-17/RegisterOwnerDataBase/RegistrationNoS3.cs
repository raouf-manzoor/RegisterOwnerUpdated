//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ContactManagementSystem26_10_17.RegisterOwnerDataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class RegistrationNoS3
    {
        public RegistrationNoS3()
        {
            this.BridgeRegNoItemsS3 = new HashSet<BridgeRegNoItemsS3>();
        }
    
        public int Id { get; set; }
        public string RegNo { get; set; }
        public Nullable<int> userId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<bool> PaidStatus { get; set; }
        public Nullable<System.TimeSpan> TimeStamp { get; set; }
    
        public virtual ICollection<BridgeRegNoItemsS3> BridgeRegNoItemsS3 { get; set; }
        public virtual User User { get; set; }
    }
}
