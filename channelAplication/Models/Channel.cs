//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace channelAplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Channel
    {
        public int Id_chan { get; set; }
        public string chanSID { get; set; }
        public string chanVPID { get; set; }
        public string chanAPID { get; set; }
        public string chanLang { get; set; }
        public string chanName_En { get; set; }
        public string chanName_Ar { get; set; }
        public string chanFreq { get; set; }
        public string chanPolarity { get; set; }
        public Nullable<double> chanSR { get; set; }
        public string chanFCB { get; set; }
        public Nullable<double> chanSatID { get; set; }
        public Nullable<double> chanOwnerID { get; set; }
        public string chanLogoLink { get; set; }
        public string chanEncryption { get; set; }
        public string chanIsTeletext { get; set; }
        public string chanAddres_En { get; set; }
        public string chanAddres_Ar { get; set; }
        public string chanLiveSreamLink { get; set; }
        public string chanIsHD { get; set; }
        public Nullable<double> chanType { get; set; }
        public Nullable<double> chanGroupID { get; set; }
        public string chanAddedByUsID { get; set; }
        public Nullable<System.DateTime> chanAddedDt { get; set; }
        public string chanEdtdByUsID { get; set; }
        public Nullable<System.DateTime> chanEdtDt { get; set; }
        public string chanDeletedByUsID { get; set; }
        public Nullable<System.DateTime> chanDeletedDt { get; set; }
        public string chanIsDeleted { get; set; }
        public string chanIsPublished { get; set; }
    }
}