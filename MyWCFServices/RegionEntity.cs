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
    
    public partial class RegionEntity
    {
        public RegionEntity()
        {
            this.Territories = new HashSet<TerritoryEntity>();
        }
    
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }
    
        public virtual ICollection<TerritoryEntity> Territories { get; set; }
    }
}
