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
    
    public partial class BRT
    {
        public BRT()
        {
            this.POSE_SCELLE_DEMANDE = new HashSet<POSE_SCELLE_DEMANDE>();
        }
    
        public string CENTRE { get; set; }
        public string CLIENT { get; set; }
        public string PRODUIT { get; set; }
        public Nullable<System.DateTime> DRAC { get; set; }
        public Nullable<System.DateTime> DRES { get; set; }
        public string SERVICE { get; set; }
        public string CATBRT { get; set; }
        public string DIAMBRT { get; set; }
        public Nullable<decimal> LONGBRT { get; set; }
        public string NATBRT { get; set; }
        public Nullable<int> NBPOINT { get; set; }
        public string RESEAU { get; set; }
        public string TRONCON { get; set; }
        public Nullable<System.DateTime> DMAJ { get; set; }
        public Nullable<int> NBRETRANSFO { get; set; }
        public Nullable<decimal> PUISSANCEINSTALLEE { get; set; }
        public Nullable<decimal> PERTES { get; set; }
        public Nullable<decimal> COEFPERTES { get; set; }
        public string APPTRANSFO { get; set; }
        public string CODEBRT { get; set; }
        public string CODEPOSTE { get; set; }
        public string ANFAB { get; set; }
        public string LONGITUDE { get; set; }
        public string LATITUDE { get; set; }
        public string ADRESSERESEAU { get; set; }
        public string USERCREATION { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDCENTRE { get; set; }
        public int FK_IDPRODUIT { get; set; }
        public Nullable<int> FK_IDTYPEBRANCHEMENT { get; set; }
        public int FK_IDAG { get; set; }
        public Nullable<int> NOMBRETRANSFORMATEUR { get; set; }
        public Nullable<int> FK_IDPOSTESOURCE { get; set; }
        public Nullable<int> FK_IDDEPARTHTA { get; set; }
        public Nullable<int> FK_IDQUARTIER { get; set; }
        public Nullable<int> FK_IDPOSTETRANSFORMATION { get; set; }
        public string DEPARTBT { get; set; }
        public string NEOUDFINAL { get; set; }
    
        public virtual AG AG { get; set; }
        public virtual TYPEBRANCHEMENT TYPEBRANCHEMENT { get; set; }
        public virtual CENTRE CENTRE1 { get; set; }
        public virtual DBRT DBRT { get; set; }
        public virtual DEPARTHTA DEPARTHTA { get; set; }
        public virtual POSTESOURCE POSTESOURCE { get; set; }
        public virtual PRODUIT PRODUIT1 { get; set; }
        public virtual QUARTIER QUARTIER { get; set; }
        public virtual POSTETRANSFORMATION POSTETRANSFORMATION { get; set; }
        public virtual ICollection<POSE_SCELLE_DEMANDE> POSE_SCELLE_DEMANDE { get; set; }
    }
}
