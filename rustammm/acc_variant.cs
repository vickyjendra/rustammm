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
    
    public partial class acc_variant
    {
        public string acc_ipn { get; set; }
        public string acc_moldcolor { get; set; }
        public string acc_remarks { get; set; }
        public string acc_tool { get; set; }
        public string acc_assy_ipn { get; set; }
        public int acc_partID { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
    
        public virtual acc_assy acc_assy { get; set; }
        public virtual acc_newtool acc_newtool { get; set; }
        public virtual acc_part acc_part { get; set; }
    }
}
