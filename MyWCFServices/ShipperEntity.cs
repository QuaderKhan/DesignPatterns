//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyWCFServices
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShipperEntity
    {
        public ShipperEntity()
        {
            this.Orders = new HashSet<OrderEntity>();
        }
    
        public int ShipperID { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<OrderEntity> Orders { get; set; }
    }
}
