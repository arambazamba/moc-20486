//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleWebForms.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VoucherDetail
    {
        public System.Guid ID { get; set; }
        public System.Guid VoucherID { get; set; }
        public System.Guid AccountID { get; set; }
        public string Text { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}