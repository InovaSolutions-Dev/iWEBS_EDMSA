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
    
    public partial class APPAREILSDEVIS
    {
        public string NUMDEM { get; set; }
        public string CODEAPPAREIL { get; set; }
        public Nullable<int> NBRE { get; set; }
        public Nullable<int> PUISSANCE { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
        public int PK_ID { get; set; }
        public int FK_IDDEMANDE { get; set; }
        public int FK_IDCODEAPPAREIL { get; set; }
    
        public virtual APPAREILS APPAREILS { get; set; }
        public virtual DEMANDE DEMANDE { get; set; }
    }
}
