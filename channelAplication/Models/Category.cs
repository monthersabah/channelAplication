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
    
    public partial class Category
    {
        public int Id_grp { get; set; }
        public Nullable<double> grpOwnerID { get; set; }
        public string grpName_Ar { get; set; }
        public string grpName_En { get; set; }
        public Nullable<double> grpSR { get; set; }
        public string grpFEC { get; set; }
        public Nullable<double> grpSatID { get; set; }
        public string grpTP { get; set; }
        public Nullable<double> grpFreq { get; set; }
        public string grpPolarity_Ar { get; set; }
        public string grpPolarity_En { get; set; }
        public string AddedByUsID { get; set; }
        public Nullable<System.DateTime> grpAddedDt { get; set; }
        public string grpEdtdByUsID { get; set; }
        public Nullable<System.DateTime> grpEdtDt { get; set; }
        public string grpDeletedByUsID { get; set; }
        public Nullable<System.DateTime> grpDeletedDt { get; set; }
        public string grpIsDeleted { get; set; }
        public string grpIsPublished { get; set; }
    }
}