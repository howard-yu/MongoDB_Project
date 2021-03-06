﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MongoAppdemo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CSPEntities : DbContext
    {
        public CSPEntities()
            : base("name=CSPEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BDDepartment> BDDepartment { get; set; }
        public virtual DbSet<CMArticle> CMArticle { get; set; }
        public virtual DbSet<CMArticleAttach> CMArticleAttach { get; set; }
        public virtual DbSet<CMArticleType> CMArticleType { get; set; }
        public virtual DbSet<CPLog> CPLog { get; set; }
        public virtual DbSet<CPProject> CPProject { get; set; }
        public virtual DbSet<CPProjectContactor> CPProjectContactor { get; set; }
        public virtual DbSet<CPProjectDataSorting> CPProjectDataSorting { get; set; }
        public virtual DbSet<CPProjectDataSortingFields> CPProjectDataSortingFields { get; set; }
        public virtual DbSet<CPProjectMember> CPProjectMember { get; set; }
        public virtual DbSet<CPProjectTest> CPProjectTest { get; set; }
        public virtual DbSet<CPProjectUser> CPProjectUser { get; set; }
        public virtual DbSet<CPRptChart> CPRptChart { get; set; }
        public virtual DbSet<CPRptChartDetail> CPRptChartDetail { get; set; }
        public virtual DbSet<CPRptChartDetail_bak> CPRptChartDetail_bak { get; set; }
        public virtual DbSet<CPRptChartMeasure> CPRptChartMeasure { get; set; }
        public virtual DbSet<CPRptChartMeasureType> CPRptChartMeasureType { get; set; }
        public virtual DbSet<CPUIControl> CPUIControl { get; set; }
        public virtual DbSet<CPUIControlDT> CPUIControlDT { get; set; }
        public virtual DbSet<EVAlertLog> EVAlertLog { get; set; }
        public virtual DbSet<EVAlertParty> EVAlertParty { get; set; }
        public virtual DbSet<EVAlertSetting> EVAlertSetting { get; set; }
        public virtual DbSet<EVMailFormat> EVMailFormat { get; set; }
        public virtual DbSet<EVMailFormatContent> EVMailFormatContent { get; set; }
        public virtual DbSet<KPIDetail> KPIDetail { get; set; }
        public virtual DbSet<KPIType> KPIType { get; set; }
        public virtual DbSet<KPITypeGroup> KPITypeGroup { get; set; }
        public virtual DbSet<MMMilestoneDetail> MMMilestoneDetail { get; set; }
        public virtual DbSet<MMMilestoneRule> MMMilestoneRule { get; set; }
        public virtual DbSet<MMMilestoneSetting> MMMilestoneSetting { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigrequest> MSpeer_conflictdetectionconfigrequest { get; set; }
        public virtual DbSet<MSpeer_lsns> MSpeer_lsns { get; set; }
        public virtual DbSet<OPContainerMilestoneFactData> OPContainerMilestoneFactData { get; set; }
        public virtual DbSet<OPInvoiceData> OPInvoiceData { get; set; }
        public virtual DbSet<OPInvoiceData_Jane> OPInvoiceData_Jane { get; set; }
        public virtual DbSet<OPInvoiceDataDetail> OPInvoiceDataDetail { get; set; }
        public virtual DbSet<OPMilestoneData> OPMilestoneData { get; set; }
        public virtual DbSet<OPMilestoneFactData> OPMilestoneFactData { get; set; }
        public virtual DbSet<OPPOData> OPPOData { get; set; }
        public virtual DbSet<OPShipmentData> OPShipmentData { get; set; }
        public virtual DbSet<OPShipmentData_Jane> OPShipmentData_Jane { get; set; }
        public virtual DbSet<OPShipmentMRDetail> OPShipmentMRDetail { get; set; }
        public virtual DbSet<OPShipmentMRSummary> OPShipmentMRSummary { get; set; }
        public virtual DbSet<OPSummaryData> OPSummaryData { get; set; }
        public virtual DbSet<RCGroupMemberV2> RCGroupMemberV2 { get; set; }
        public virtual DbSet<RCGroupV2> RCGroupV2 { get; set; }
        public virtual DbSet<RCRightV2> RCRightV2 { get; set; }
        public virtual DbSet<RCTemplateRightV2> RCTemplateRightV2 { get; set; }
        public virtual DbSet<RCTemplateV2> RCTemplateV2 { get; set; }
        public virtual DbSet<RCUser> RCUser { get; set; }
        public virtual DbSet<RCUserRightV2> RCUserRightV2 { get; set; }
        public virtual DbSet<RPFiled> RPFiled { get; set; }
        public virtual DbSet<RPReport> RPReport { get; set; }
        public virtual DbSet<SAARStatus> SAARStatus { get; set; }
        public virtual DbSet<SAShptStatus> SAShptStatus { get; set; }
        public virtual DbSet<SCTask> SCTask { get; set; }
        public virtual DbSet<SCTaskLog> SCTaskLog { get; set; }
        public virtual DbSet<sysreplservers> sysreplservers { get; set; }
        public virtual DbSet<UIControl> UIControl { get; set; }
        public virtual DbSet<UIControlDT> UIControlDT { get; set; }
        public virtual DbSet<WTIrregularLog> WTIrregularLog { get; set; }
        public virtual DbSet<WTReason> WTReason { get; set; }
        public virtual DbSet<GCRList> GCRList { get; set; }
        public virtual DbSet<MSpeer_conflictdetectionconfigresponse> MSpeer_conflictdetectionconfigresponse { get; set; }
        public virtual DbSet<MSpeer_originatorid_history> MSpeer_originatorid_history { get; set; }
        public virtual DbSet<MSpeer_request> MSpeer_request { get; set; }
        public virtual DbSet<MSpeer_response> MSpeer_response { get; set; }
        public virtual DbSet<MSpeer_topologyrequest> MSpeer_topologyrequest { get; set; }
        public virtual DbSet<MSpeer_topologyresponse> MSpeer_topologyresponse { get; set; }
        public virtual DbSet<MSpub_identity_range> MSpub_identity_range { get; set; }
        public virtual DbSet<MSreplication_objects> MSreplication_objects { get; set; }
        public virtual DbSet<MSreplication_subscriptions> MSreplication_subscriptions { get; set; }
        public virtual DbSet<MSsavedforeignkeycolumns> MSsavedforeignkeycolumns { get; set; }
        public virtual DbSet<MSsavedforeignkeyextendedproperties> MSsavedforeignkeyextendedproperties { get; set; }
        public virtual DbSet<MSsavedforeignkeys> MSsavedforeignkeys { get; set; }
        public virtual DbSet<MSsnapshotdeliveryprogress> MSsnapshotdeliveryprogress { get; set; }
        public virtual DbSet<MSsubscription_agents> MSsubscription_agents { get; set; }
        public virtual DbSet<MSsubscription_properties> MSsubscription_properties { get; set; }
        public virtual DbSet<OPContainerMilestoneFactDataTmp> OPContainerMilestoneFactDataTmp { get; set; }
        public virtual DbSet<OPInvoiceDataTmp> OPInvoiceDataTmp { get; set; }
        public virtual DbSet<OPMilestoneDataTest> OPMilestoneDataTest { get; set; }
        public virtual DbSet<OPMilestoneDataTmp1> OPMilestoneDataTmp1 { get; set; }
        public virtual DbSet<OPMilestoneFactDataTmp> OPMilestoneFactDataTmp { get; set; }
        public virtual DbSet<OPPODataOld> OPPODataOld { get; set; }
        public virtual DbSet<OPPODataTest> OPPODataTest { get; set; }
        public virtual DbSet<OPShipmentDataOld> OPShipmentDataOld { get; set; }
        public virtual DbSet<OPShipmentDataTest> OPShipmentDataTest { get; set; }
        public virtual DbSet<OPSummaryDataOld> OPSummaryDataOld { get; set; }
        public virtual DbSet<OPSummaryDataTest> OPSummaryDataTest { get; set; }
        public virtual DbSet<ProcessLog> ProcessLog { get; set; }
        public virtual DbSet<SCSubTaskLog> SCSubTaskLog { get; set; }
        public virtual DbSet<sysarticlecolumns> sysarticlecolumns { get; set; }
        public virtual DbSet<sysarticles> sysarticles { get; set; }
        public virtual DbSet<sysarticleupdates> sysarticleupdates { get; set; }
        public virtual DbSet<syspublications> syspublications { get; set; }
        public virtual DbSet<sysschemaarticles> sysschemaarticles { get; set; }
        public virtual DbSet<syssubscriptions> syssubscriptions { get; set; }
        public virtual DbSet<systranschemas> systranschemas { get; set; }
    }
}
