//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finances_Server
{
    using System;
    using System.Collections.Generic;
    
    public partial class Expenses
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int AreaId { get; set; }
        public string Description { get; set; }
        public string Observations { get; set; }
    
        public virtual Areas Areas { get; set; }
    }
}
