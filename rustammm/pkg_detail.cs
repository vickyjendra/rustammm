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
    
    public partial class pkg_detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pkg_detail()
        {
            this.pkg_photo = new HashSet<pkg_photo>();
        }
    
        public int detail_id { get; set; }
        public Nullable<int> sub_id { get; set; }
        public Nullable<int> packaging_id { get; set; }
        public string image_link { get; set; }
        public string file_link { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public string categories_name { get; set; }
    
        public virtual pkg_cat pkg_cat { get; set; }
        public virtual pkg_sub pkg_sub { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pkg_photo> pkg_photo { get; set; }
    }
}
