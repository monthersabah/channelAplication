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
    
    public partial class Satellites_
    {
        public int Id_sat { get; set; }
        public string satName_Ar { get; set; }
        public string satName_En { get; set; }
        public Nullable<double> satCovAreaID { get; set; }
        public string satLongitude { get; set; }
        public string satLongitudeOri { get; set; }
        public string satSystem { get; set; }
        public string satLogoName { get; set; }
        public string satAddedByUsID { get; set; }
        public Nullable<System.DateTime> satAddedDt { get; set; }
        public string satEdtdByUsID { get; set; }
        public Nullable<System.DateTime> satEdtDt { get; set; }
        public string satDeletedByUsID { get; set; }
        public Nullable<System.DateTime> satDeletedDt { get; set; }
        public string satIsDeleted { get; set; }
        public string satIsPublished { get; set; }
    }
}
