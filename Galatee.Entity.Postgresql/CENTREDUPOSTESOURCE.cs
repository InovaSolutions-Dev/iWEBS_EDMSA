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
    
    public partial class CENTREDUPOSTESOURCE
    {
        public int FK_IDPOSTESOURCE { get; set; }
        public int FK_IDCENTRE { get; set; }
        public System.DateTime DATEDEBUTVALIDITE { get; set; }
        public Nullable<System.DateTime> DATEFINVALIDITE { get; set; }
    
        public virtual CENTRE CENTRE { get; set; }
        public virtual POSTESOURCE POSTESOURCE { get; set; }
    }
}
