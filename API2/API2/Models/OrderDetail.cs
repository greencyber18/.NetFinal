//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public OrderDetail()
        {
            this.OrderDetail1 = new HashSet<OrderDetail>();
        }
    
        public int Id { get; set; }
        public Nullable<int> pId { get; set; }
        public Nullable<int> oId { get; set; }
        public Nullable<int> Price { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail1 { get; set; }
        public virtual OrderDetail OrderDetail2 { get; set; }
        public virtual Product Product { get; set; }
    }
}
