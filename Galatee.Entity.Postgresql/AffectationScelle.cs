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
    
    public partial class AffectationScelle
    {
        public AffectationScelle()
        {
            this.DetailAffectationScelle = new HashSet<DetailAffectationScelle>();
        }
    
        public System.Guid Id_Affectation { get; set; }
        public Nullable<int> Code_Centre_Origine { get; set; }
        public Nullable<int> Code_Centre_Dest { get; set; }
        public System.DateTime Date_Transfert { get; set; }
        public Nullable<int> Id_Modificateur { get; set; }
        public Nullable<int> Nbre_Scelles { get; set; }
        public Nullable<int> Id_Demande { get; set; }
        public string NumScelleDepart { get; set; }
        public string NumScelleFin { get; set; }
    
        public virtual ICollection<DetailAffectationScelle> DetailAffectationScelle { get; set; }
        public virtual DEMANDE DEMANDE { get; set; }
    }
}
