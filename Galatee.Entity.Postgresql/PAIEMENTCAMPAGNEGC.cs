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
    
    public partial class PAIEMENTCAMPAGNEGC
    {
        public PAIEMENTCAMPAGNEGC()
        {
            this.DETAILPAIEMENTCAMPAGNEGC = new HashSet<DETAILPAIEMENTCAMPAGNEGC>();
        }
    
        public Nullable<decimal> MONTANT { get; set; }
        public int PK_ID { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public string NUMEROMANDATEMENT { get; set; }
        public Nullable<int> FK_IDMANDATEMANT { get; set; }
        public string TYPE_PAIEMENT { get; set; }
        public Nullable<bool> EST_MIS_A_JOUR { get; set; }
        public string NumAvisCredit { get; set; }
    
        public virtual ICollection<DETAILPAIEMENTCAMPAGNEGC> DETAILPAIEMENTCAMPAGNEGC { get; set; }
        public virtual MANDATEMENTGC MANDATEMENTGC { get; set; }
    }
}
