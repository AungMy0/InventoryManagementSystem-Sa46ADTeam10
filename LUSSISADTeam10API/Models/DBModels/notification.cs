//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LUSSISADTeam10API.Models.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class notification
    {
        public int notiid { get; set; }
        public System.DateTime datetime { get; set; }
        public int deptid { get; set; }
        public int role { get; set; }
        public string title { get; set; }
        public string remark { get; set; }
        public bool isread { get; set; }
        public int notitype { get; set; }
        public int resid { get; set; }
    
        public virtual department department { get; set; }
    }
}
