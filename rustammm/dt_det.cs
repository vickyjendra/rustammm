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
    
    public partial class dt_det
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dt_det()
        {
            this.dt_photo = new HashSet<dt_photo>();
        }
    
        public int det_id { get; set; }
        public Nullable<int> subdet_id { get; set; }
        public Nullable<int> sub_id { get; set; }
        public Nullable<int> cat_id { get; set; }
        public string det_name { get; set; }
        public string toy_num { get; set; }
        public string part_name1 { get; set; }
        public string material1 { get; set; }
        public string part_name2 { get; set; }
        public string material2 { get; set; }
        public string qa_ler { get; set; }
        public string functions { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string file_link { get; set; }
    
        public virtual dt_cat dt_cat { get; set; }
        public virtual dt_sub dt_sub { get; set; }
        public virtual dt_subdet dt_subdet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dt_photo> dt_photo { get; set; }
    }
}
