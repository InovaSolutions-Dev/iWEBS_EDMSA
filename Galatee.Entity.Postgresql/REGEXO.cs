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
    
    public partial class REGEXO
    {
        public string CENTRE { get; set; }
        public string PRODUIT { get; set; }
        public string REGROUPEMENT { get; set; }
        public string EXFAV { get; set; }
        public string EXFDOS { get; set; }
        public string EXFPOL { get; set; }
        public string TRAITFAC { get; set; }
        public string TRANS { get; set; }
        public Nullable<int> REFERENCEPUPITRE { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDPRODUIT { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDREGROUPEMENT { get; set; }
    
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual PRODUIT PRODUIT1 { get; set; }
        public virtual REGROUPEMENT REGROUPEMENT1 { get; set; }
    }
}
