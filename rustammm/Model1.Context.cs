﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class proddevEntities : DbContext
    {
        public proddevEntities()
            : base("name=proddevEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<acc_assy> acc_assy { get; set; }
        public virtual DbSet<acc_cate> acc_cate { get; set; }
        public virtual DbSet<acc_fit> acc_fit { get; set; }
        public virtual DbSet<acc_newtool> acc_newtool { get; set; }
        public virtual DbSet<acc_part> acc_part { get; set; }
        public virtual DbSet<acc_photo> acc_photo { get; set; }
        public virtual DbSet<acc_stdcost> acc_stdcost { get; set; }
        public virtual DbSet<acc_variant> acc_variant { get; set; }
        public virtual DbSet<activity_log> activity_log { get; set; }
        public virtual DbSet<data_log> data_log { get; set; }
        public virtual DbSet<dt_cat> dt_cat { get; set; }
        public virtual DbSet<dt_det> dt_det { get; set; }
        public virtual DbSet<dt_photo> dt_photo { get; set; }
        public virtual DbSet<dt_sub> dt_sub { get; set; }
        public virtual DbSet<dt_subdet> dt_subdet { get; set; }
        public virtual DbSet<failed_jobs> failed_jobs { get; set; }
        public virtual DbSet<fb_lib> fb_lib { get; set; }
        public virtual DbSet<fmea_concern> fmea_concern { get; set; }
        public virtual DbSet<fmea_DCCheck> fmea_DCCheck { get; set; }
        public virtual DbSet<fmea_MECheck> fmea_MECheck { get; set; }
        public virtual DbSet<fmea_PECheck> fmea_PECheck { get; set; }
        public virtual DbSet<fmea_QECheck> fmea_QECheck { get; set; }
        public virtual DbSet<fmea_response> fmea_response { get; set; }
        public virtual DbSet<fmea_TACheck> fmea_TACheck { get; set; }
        public virtual DbSet<fmea_TECheck> fmea_TECheck { get; set; }
        public virtual DbSet<IM_ApprovedBy> IM_ApprovedBy { get; set; }
        public virtual DbSet<IM_Master> IM_Master { get; set; }
        public virtual DbSet<jfr_PL_7777> jfr_PL_7777 { get; set; }
        public virtual DbSet<masterTE_sample> masterTE_sample { get; set; }
        public virtual DbSet<material> materials { get; set; }
        public virtual DbSet<migration> migrations { get; set; }
        public virtual DbSet<mmm_ApprovedBy> mmm_ApprovedBy { get; set; }
        public virtual DbSet<mmm_data> mmm_data { get; set; }
        public virtual DbSet<ntd_attach> ntd_attach { get; set; }
        public virtual DbSet<ntd_members> ntd_members { get; set; }
        public virtual DbSet<ntd_stage> ntd_stage { get; set; }
        public virtual DbSet<ntd_text> ntd_text { get; set; }
        public virtual DbSet<pd_alltoy> pd_alltoy { get; set; }
        public virtual DbSet<pd_dtm> pd_dtm { get; set; }
        public virtual DbSet<pd_grup> pd_grup { get; set; }
        public virtual DbSet<pd_input> pd_input { get; set; }
        public virtual DbSet<pd_issues> pd_issues { get; set; }
        public virtual DbSet<pd_MECTL> pd_MECTL { get; set; }
        public virtual DbSet<pd_meeting> pd_meeting { get; set; }
        public virtual DbSet<pd_member> pd_member { get; set; }
        public virtual DbSet<pd_notes> pd_notes { get; set; }
        public virtual DbSet<pd_photo> pd_photo { get; set; }
        public virtual DbSet<pd_resin> pd_resin { get; set; }
        public virtual DbSet<pd_schedule> pd_schedule { get; set; }
        public virtual DbSet<pd_skintone> pd_skintone { get; set; }
        public virtual DbSet<pd_torsotype> pd_torsotype { get; set; }
        public virtual DbSet<pd_toytype> pd_toytype { get; set; }
        public virtual DbSet<pd_user> pd_user { get; set; }
        public virtual DbSet<pkg_cat> pkg_cat { get; set; }
        public virtual DbSet<pkg_detail> pkg_detail { get; set; }
        public virtual DbSet<pkg_photo> pkg_photo { get; set; }
        public virtual DbSet<pkg_sub> pkg_sub { get; set; }
        public virtual DbSet<PrintReq> PrintReqs { get; set; }
        public virtual DbSet<rc_sculpt> rc_sculpt { get; set; }
        public virtual DbSet<rc_variant> rc_variant { get; set; }
        public virtual DbSet<sw_char> sw_char { get; set; }
        public virtual DbSet<sw_fb> sw_fb { get; set; }
        public virtual DbSet<sw_meth> sw_meth { get; set; }
        public virtual DbSet<sw_method> sw_method { get; set; }
        public virtual DbSet<sw_pat> sw_pat { get; set; }
        public virtual DbSet<sw_pict> sw_pict { get; set; }
        public virtual DbSet<sw_sp> sw_sp { get; set; }
        public virtual DbSet<sw_spt> sw_spt { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TE_ToolTf> TE_ToolTf { get; set; }
        public virtual DbSet<TE_ToolTf_Checklist> TE_ToolTf_Checklist { get; set; }
        public virtual DbSet<TE_ToolTf_Mtrl_Apprv> TE_ToolTf_Mtrl_Apprv { get; set; }
        public virtual DbSet<Toolreq> Toolreqs { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<fep_dsa> fep_dsa { get; set; }
        public virtual DbSet<fep_qa> fep_qa { get; set; }
        public virtual DbSet<password_resets> password_resets { get; set; }
        public virtual DbSet<ptmi_tools> ptmi_tools { get; set; }
    }
}