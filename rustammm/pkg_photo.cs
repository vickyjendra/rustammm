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
    
    public partial class pkg_photo
    {
        public int pht_ID { get; set; }
        public string pht_file { get; set; }
        public Nullable<int> detail_id { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        public virtual pkg_detail pkg_detail { get; set; }
    }
}
