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
    
    public partial class acc_part
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public acc_part()
        {
            this.acc_assy = new HashSet<acc_assy>();
            this.acc_newtool = new HashSet<acc_newtool>();
            this.acc_photo = new HashSet<acc_photo>();
            this.acc_variant = new HashSet<acc_variant>();
        }
    
        public int acc_partID { get; set; }
        public string acc_partName { get; set; }
        public short acc_v_assy { get; set; }
        public string acc_toy { get; set; }
        public string acc_loc { get; set; }
        public int acc_cateID { get; set; }
        public int toytype_id { get; set; }
        public int sw_charID { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acc_assy> acc_assy { get; set; }
        public virtual acc_cate acc_cate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acc_newtool> acc_newtool { get; set; }
        public virtual pd_toytype pd_toytype { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acc_photo> acc_photo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acc_variant> acc_variant { get; set; }
    }
}
