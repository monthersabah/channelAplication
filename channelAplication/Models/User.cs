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
    
    public partial class User
    {
        public string userName_Ar { get; set; }
        public string userName_En { get; set; }
        public string Id_userEmail { get; set; }
        public string userType { get; set; }
        public Nullable<System.DateTime> userAddedDt { get; set; }
        public string userEdtdByUsID { get; set; }
        public Nullable<System.DateTime> userEdtDt { get; set; }
        public string userDeletedByUsID { get; set; }
        public Nullable<System.DateTime> userDeletedDt { get; set; }
        public string userIsDeleted { get; set; }
        public int Id_user { get; set; }
    }
}