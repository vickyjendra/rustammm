//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rustammm
{
    using System;
    using System.Collections.Generic;
    
    public partial class pd_MECTL
    {
        public int MTL_ID { get; set; }
        public string MTL_toynum { get; set; }
        public string MTL_toolnum { get; set; }
        public string MTL_toolname { get; set; }
        public Nullable<System.DateTime> MTL_origTL { get; set; }
        public Nullable<System.DateTime> MTL_schTL { get; set; }
        public Nullable<System.DateTime> MTL_actTL { get; set; }
        public Nullable<System.DateTime> MTL_origFS { get; set; }
        public Nullable<System.DateTime> MTL_actFS { get; set; }
        public Nullable<System.DateTime> MTL_origTS { get; set; }
        public Nullable<System.DateTime> MTL_actTS { get; set; }
        public string MTL_eng { get; set; }
        public string MTL_build { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
    }
}
