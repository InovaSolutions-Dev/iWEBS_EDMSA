//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Galatee.Entity.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbDetailRemiseScelles
    {
        public System.Guid Id_DetailRemise { get; set; }
        public System.Guid Id_Remise { get; set; }
        public string Lot_Id { get; set; }
        public Nullable<System.Guid> Id_Scelle { get; set; }
    
        public virtual Scelles Scelles { get; set; }
        public virtual tbLot tbLot { get; set; }
        public virtual tbRemiseScelles tbRemiseScelles { get; set; }
    }
}