using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rustammm.Models
{
    public class AllProduct
    {
        public string pd_projnum { get; set; }
        public string pd_toynum { get; set; }
        public string pd_asstnum { get; set; }
        public string pd_toydesc { get; set; }
        public string MTL_toynum { get; set; }
        public string MTL_toolnum { get; set; }
        public string TotalTool { get; set; }

        public string sch_attr { get; set; }

        public DateTime? sch_date { get; set; }
    }
}