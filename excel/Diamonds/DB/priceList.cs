//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class priceList
    {
        public int pricrId { get; set; }
        public Nullable<int> cleanLevelId { get; set; }
        public Nullable<int> colorId { get; set; }
        public Nullable<int> shapeId { get; set; }
        public Nullable<double> minCT { get; set; }
        public Nullable<double> maxCT { get; set; }
        public Nullable<int> price { get; set; }
    
        public virtual cleanLevels cleanLevels { get; set; }
        public virtual colors colors { get; set; }
        public virtual shapes shapes { get; set; }
    }
}
