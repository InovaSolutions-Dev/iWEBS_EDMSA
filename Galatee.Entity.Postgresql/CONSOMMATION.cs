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
    
    public partial class CONSOMMATION
    {
        public CONSOMMATION()
        {
            this.DETAILparPRESTATIONEDM = new HashSet<DETAILparPRESTATIONEDM>();
            this.DETAILparPRESTATIONREMBOURSABLE = new HashSet<DETAILparPRESTATIONREMBOURSABLE>();
            this.DETAILparREGULARISATION = new HashSet<DETAILparREGULARISATION>();
            this.DETAILparTRANCHE = new HashSet<DETAILparTRANCHE>();
            this.MOISDEJAFACTURES = new HashSet<MOISDEJAFACTURES>();
        }
    
        public int PK_ID { get; set; }
        public Nullable<bool> IsEstimationParAppareil { get; set; }
        public Nullable<int> ConsommationEstimee { get; set; }
        public Nullable<int> ConsommationRetrogradation { get; set; }
        public Nullable<int> ConsommationDejaFacturee { get; set; }
        public Nullable<int> ConsommationAFacturer { get; set; }
        public Nullable<int> ConsommationMensuelleAFacturer { get; set; }
        public Nullable<int> MontantHTConsommation { get; set; }
        public Nullable<int> MontantHTPrestationEDM { get; set; }
        public Nullable<int> MontantHTPrestationRemboursable { get; set; }
        public Nullable<int> MontantHTRegularisationDevis { get; set; }
        public Nullable<decimal> TauxTVA { get; set; }
        public Nullable<int> NombreMoisAFacturer { get; set; }
        public Nullable<int> MontantFactureTTC { get; set; }
        public Nullable<bool> IsFactureAuForfait { get; set; }
        public Nullable<bool> IsFactureAnnulee { get; set; }
        public Nullable<int> OrdreTraitement { get; set; }
        public string CodeTVA { get; set; }
        public Nullable<int> MontantTVAConsommation { get; set; }
        public Nullable<int> FK_IDFRAUDE { get; set; }
        public Nullable<int> FK_IDPRODUIT { get; set; }
    
        public virtual PRODUIT PRODUIT { get; set; }
        public virtual FRAUDE FRAUDE { get; set; }
        public virtual ICollection<DETAILparPRESTATIONEDM> DETAILparPRESTATIONEDM { get; set; }
        public virtual ICollection<DETAILparPRESTATIONREMBOURSABLE> DETAILparPRESTATIONREMBOURSABLE { get; set; }
        public virtual ICollection<DETAILparREGULARISATION> DETAILparREGULARISATION { get; set; }
        public virtual ICollection<DETAILparTRANCHE> DETAILparTRANCHE { get; set; }
        public virtual ICollection<MOISDEJAFACTURES> MOISDEJAFACTURES { get; set; }
    }
}
