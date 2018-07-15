﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LUSSISADTeam10API.Models.APIModels
{
    public class AdjustmentModel
    {
        public AdjustmentModel(int adjid, int? raisedby,string raisedbyname, int? raisedto,string raisedtoname, DateTime? issueddate, int status)
        {
            this.adjid = adjid;
            this.raisedby = raisedby;
            this.raisedbyname = raisedbyname;
            this.raisedto = raisedto;
            this.raisedtoname = raisedtoname;
            this.issueddate = issueddate;
            this.status = status;
        }
        public AdjustmentModel() : this(0, 0,"", 0,"", new DateTime(), 0)
        {
        }
        public int adjid { get; set; }
        public int? raisedby { get; set; }
        public string raisedbyname { get; set; }
        public int? raisedto { get; set; }
        public string raisedtoname { get; set; }
        public DateTime? issueddate { get; set; }
        public int status { get; set; } = 0;
    }
}