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
    
    public partial class REGROUPEMENT
    {
        public REGROUPEMENT()
        {
            this.AFFECTATIONGESTIONAIRE = new HashSet<AFFECTATIONGESTIONAIRE>();
            this.CAMPAGNEGC = new HashSet<CAMPAGNEGC>();
            this.CAMPAGNESGC = new HashSet<CAMPAGNESGC>();
            this.CLIENT = new HashSet<CLIENT>();
            this.DCLIENT = new HashSet<DCLIENT>();
            this.DTRANSFERT = new HashSet<DTRANSFERT>();
            this.REGEXO = new HashSet<REGEXO>();
        }
    
        public string CODE { get; set; }
        public string NOM { get; set; }
        public string ADRESSE { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public string CATEGORIE { get; set; }
    
        public virtual ICollection<AFFECTATIONGESTIONAIRE> AFFECTATIONGESTIONAIRE { get; set; }
        public virtual ICollection<CAMPAGNEGC> CAMPAGNEGC { get; set; }
        public virtual ICollection<CAMPAGNESGC> CAMPAGNESGC { get; set; }
        public virtual ICollection<CLIENT> CLIENT { get; set; }
        public virtual ICollection<DCLIENT> DCLIENT { get; set; }
        public virtual ICollection<DTRANSFERT> DTRANSFERT { get; set; }
        public virtual ICollection<REGEXO> REGEXO { get; set; }
    }
}
