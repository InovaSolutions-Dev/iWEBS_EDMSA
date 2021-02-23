﻿using System;
using System.Collections.Generic;
using System.Text;
using Inova.Tools.Utilities;
using System.Runtime.Serialization;

namespace Galatee.Structure
{
    [DataContract]

    public class CsMarqueCompteur : CsPrint
    {
        [DataMember]
        public int PK_ID { get; set; }
        [DataMember]
        public string CODE { get; set; }
        [DataMember]
        public int COEFFICIENTDEMULTIPLICATION { get; set; }        
        //[DataMember]
        //public string OriginalPK_MARQUECOMPTEUR { get; set; }
        [DataMember]
        public string LIBELLE { get; set; }
        [DataMember]
        public DateTime? DATECREATION { get; set; }
        [DataMember]
        public DateTime? DATEMODIFICATION { get; set; }
        [DataMember]
        public string USERCREATION { get; set; }
        [DataMember]
        public string USERMODIFICATION { get; set; }
    }
 }









