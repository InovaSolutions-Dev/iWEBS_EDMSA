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
    
    public partial class ENTREPRISE
    {
        public int PK_ID { get; set; }
        public string NOM { get; set; }
        public string SIGLE { get; set; }
        public string SLOGAN { get; set; }
        public string ADRESSEPRINCIPALE { get; set; }
        public string ADRESSESECONDAIRE { get; set; }
        public string TELEPHONEPRINCIPAL { get; set; }
        public string TELEPHONESECONDAIRE { get; set; }
        public string FAXPRINCIPALE { get; set; }
        public string FAXSECONDAIRE { get; set; }
        public string EMAILPRINCIPALE { get; set; }
        public string EMAILSECONDAIRE { get; set; }
        public string ACTIVITE { get; set; }
        public string PAYS { get; set; }
        public string SITEINTERNET { get; set; }
        public byte[] LOGO { get; set; }
        public System.DateTime DATECREATION { get; set; }
        public Nullable<System.DateTime> DATEMODIFICATION { get; set; }
        public string USERCREATION { get; set; }
        public string USERMODIFICATION { get; set; }
    }
}