using Apex.System;
using SalesForceAPI.Apex;

namespace ApexSharpDemo.SObjects
{
    public class Profile : SObject
    {
        public string Id { set; get; }
        public string Name { set; get; }
        public bool PermissionsEmailSingle { set; get; }
        public bool PermissionsEmailMass { set; get; }
        public bool PermissionsEditTask { set; get; }
        public bool PermissionsEditEvent { set; get; }
        public bool PermissionsExportReport { set; get; }
        public bool PermissionsImportPersonal { set; get; }
        public bool PermissionsManageUsers { set; get; }
        public bool PermissionsEditPublicTemplates { set; get; }
        public bool PermissionsModifyAllData { set; get; }
        public bool PermissionsManageCases { set; get; }
        public bool PermissionsMassInlineEdit { set; get; }
        public bool PermissionsEditKnowledge { set; get; }
        public bool PermissionsManageKnowledge { set; get; }
        public bool PermissionsManageSolutions { set; get; }
        public bool PermissionsCustomizeApplication { set; get; }
        public bool PermissionsEditReadonlyFields { set; get; }
        public bool PermissionsRunReports { set; get; }
        public bool PermissionsViewSetup { set; get; }
        public bool PermissionsTransferAnyEntity { set; get; }
        public bool PermissionsNewReportBuilder { set; get; }
        public bool PermissionsActivateContract { set; get; }
        public bool PermissionsActivateOrder { set; get; }
        public bool PermissionsImportLeads { set; get; }
        public bool PermissionsManageLeads { set; get; }
        public bool PermissionsTransferAnyLead { set; get; }
        public bool PermissionsViewAllData { set; get; }
        public bool PermissionsEditPublicDocuments { set; get; }
        public bool PermissionsViewEncryptedData { set; get; }
        public bool PermissionsEditBrandTemplates { set; get; }
        public bool PermissionsEditHtmlTemplates { set; get; }
        public bool PermissionsChatterInternalUser { set; get; }
        public bool PermissionsManageEncryptionKeys { set; get; }
        public bool PermissionsDeleteActivatedContract { set; get; }
        public bool PermissionsChatterInviteExternalUsers { set; get; }
        public bool PermissionsSendSitRequests { set; get; }
        public bool PermissionsManageRemoteAccess { set; get; }
        public bool PermissionsCanUseNewDashboardBuilder { set; get; }
        public bool PermissionsManageCategories { set; get; }
        public bool PermissionsConvertLeads { set; get; }
        public bool PermissionsPasswordNeverExpires { set; get; }
        public bool PermissionsUseTeamReassignWizards { set; get; }
        public bool PermissionsEditActivatedOrders { set; get; }
        public bool PermissionsInstallMultiforce { set; get; }
        public bool PermissionsPublishMultiforce { set; get; }
        public bool PermissionsChatterOwnGroups { set; get; }
        public bool PermissionsEditOppLineItemUnitPrice { set; get; }
        public bool PermissionsCreateMultiforce { set; get; }
        public bool PermissionsBulkApiHardDelete { set; get; }
        public bool PermissionsSolutionImport { set; get; }
        public bool PermissionsManageCallCenters { set; get; }
        public bool PermissionsManageSynonyms { set; get; }
        public bool PermissionsViewContent { set; get; }
        public bool PermissionsManageEmailClientConfig { set; get; }
        public bool PermissionsEnableNotifications { set; get; }
        public bool PermissionsManageDataIntegrations { set; get; }
        public bool PermissionsDistributeFromPersWksp { set; get; }
        public bool PermissionsViewDataCategories { set; get; }
        public bool PermissionsManageDataCategories { set; get; }
        public bool PermissionsAuthorApex { set; get; }
        public bool PermissionsManageMobile { set; get; }
        public bool PermissionsApiEnabled { set; get; }
        public bool PermissionsManageCustomReportTypes { set; get; }
        public bool PermissionsEditCaseComments { set; get; }
        public bool PermissionsTransferAnyCase { set; get; }
        public bool PermissionsContentAdministrator { set; get; }
        public bool PermissionsCreateWorkspaces { set; get; }
        public bool PermissionsManageContentPermissions { set; get; }
        public bool PermissionsManageContentProperties { set; get; }
        public bool PermissionsManageContentTypes { set; get; }
        public bool PermissionsManageExchangeConfig { set; get; }
        public bool PermissionsManageAnalyticSnapshots { set; get; }
        public bool PermissionsScheduleReports { set; get; }
        public bool PermissionsManageBusinessHourHolidays { set; get; }
        public bool PermissionsManageDynamicDashboards { set; get; }
        public bool PermissionsCustomSidebarOnAllPages { set; get; }
        public bool PermissionsManageInteraction { set; get; }
        public bool PermissionsViewMyTeamsDashboards { set; get; }
        public bool PermissionsModerateChatter { set; get; }
        public bool PermissionsResetPasswords { set; get; }
        public bool PermissionsFlowUFLRequired { set; get; }
        public bool PermissionsCanInsertFeedSystemFields { set; get; }
        public bool PermissionsManageKnowledgeImportExport { set; get; }
        public bool PermissionsEmailTemplateManagement { set; get; }
        public bool PermissionsEmailAdministration { set; get; }
        public bool PermissionsManageChatterMessages { set; get; }
        public bool PermissionsAllowEmailIC { set; get; }
        public bool PermissionsChatterFileLink { set; get; }
        public bool PermissionsForceTwoFactor { set; get; }
        public bool PermissionsViewEventLogFiles { set; get; }
        public bool PermissionsManageNetworks { set; get; }
        public bool PermissionsManageAuthProviders { set; get; }
        public bool PermissionsRunFlow { set; get; }
        public bool PermissionsCreateCustomizeDashboards { set; get; }
        public bool PermissionsCreateDashboardFolders { set; get; }
        public bool PermissionsViewPublicDashboards { set; get; }
        public bool PermissionsManageDashbdsInPubFolders { set; get; }
        public bool PermissionsCreateCustomizeReports { set; get; }
        public bool PermissionsCreateReportFolders { set; get; }
        public bool PermissionsViewPublicReports { set; get; }
        public bool PermissionsManageReportsInPubFolders { set; get; }
        public bool PermissionsEditMyDashboards { set; get; }
        public bool PermissionsEditMyReports { set; get; }
        public bool PermissionsViewAllUsers { set; get; }
        public bool PermissionsAllowUniversalSearch { set; get; }
        public bool PermissionsConnectOrgToEnvironmentHub { set; get; }
        public bool PermissionsWorkCalibrationUser { set; get; }
        public bool PermissionsCreateCustomizeFilters { set; get; }
        public bool PermissionsWorkDotComUserPerm { set; get; }
        public bool PermissionsGovernNetworks { set; get; }
        public bool PermissionsSalesConsole { set; get; }
        public bool PermissionsTwoFactorApi { set; get; }
        public bool PermissionsDeleteTopics { set; get; }
        public bool PermissionsEditTopics { set; get; }
        public bool PermissionsCreateTopics { set; get; }
        public bool PermissionsAssignTopics { set; get; }
        public bool PermissionsIdentityEnabled { set; get; }
        public bool PermissionsIdentityConnect { set; get; }
        public bool PermissionsAllowViewKnowledge { set; get; }
        public bool PermissionsManageSearchPromotionRules { set; get; }
        public bool PermissionsCustomMobileAppsAccess { set; get; }
        public bool PermissionsViewHelpLink { set; get; }
        public bool PermissionsManageProfilesPermissionsets { set; get; }
        public bool PermissionsAssignPermissionSets { set; get; }
        public bool PermissionsManageRoles { set; get; }
        public bool PermissionsManageIpAddresses { set; get; }
        public bool PermissionsManageSharing { set; get; }
        public bool PermissionsManageInternalUsers { set; get; }
        public bool PermissionsManagePasswordPolicies { set; get; }
        public bool PermissionsManageLoginAccessPolicies { set; get; }
        public bool PermissionsManageCustomPermissions { set; get; }
        public bool PermissionsManageUnlistedGroups { set; get; }
        public bool PermissionsModifySecureAgents { set; get; }
        public bool PermissionsManageTwoFactor { set; get; }
        public bool PermissionsChatterForSharePoint { set; get; }
        public bool PermissionsLightningExperienceUser { set; get; }
        public bool PermissionsConfigCustomRecs { set; get; }
        public bool PermissionsSubmitMacrosAllowed { set; get; }
        public bool PermissionsBulkMacrosAllowed { set; get; }
        public bool PermissionsShareInternalArticles { set; get; }
        public bool PermissionsManageSessionPermissionSets { set; get; }
        public bool PermissionsSendAnnouncementEmails { set; get; }
        public bool PermissionsChatterEditOwnPost { set; get; }
        public bool PermissionsChatterEditOwnRecordPost { set; get; }
        public bool PermissionsImportCustomObjects { set; get; }
        public bool PermissionsDelegatedTwoFactor { set; get; }
        public bool PermissionsChatterComposeUiCodesnippet { set; get; }
        public bool PermissionsSelectFilesFromSalesforce { set; get; }
        public bool PermissionsModerateNetworkUsers { set; get; }
        public bool PermissionsMergeTopics { set; get; }
        public bool PermissionsSubscribeToLightningReports { set; get; }
        public bool PermissionsManagePvtRptsAndDashbds { set; get; }
        public bool PermissionsCampaignInfluence2 { set; get; }
        public bool PermissionsCanApproveFeedPost { set; get; }
        public bool PermissionsAllowViewEditConvertedLeads { set; get; }
        public bool PermissionsShowCompanyNameAsUserBadge { set; get; }
        public bool PermissionsAccessCMC { set; get; }
        public bool PermissionsViewHealthCheck { set; get; }
        public bool PermissionsManageHealthCheck { set; get; }
        public bool PermissionsViewAllActivities { set; get; }
        public string UserLicenseId { set; get; }
        public UserLicense UserLicense { set; get; }
        public string UserType { set; get; }
        public DateTime CreatedDate { set; get; }
        public string CreatedById { set; get; }
        public User CreatedBy { set; get; }
        public DateTime LastModifiedDate { set; get; }
        public string LastModifiedById { set; get; }
        public User LastModifiedBy { set; get; }
        public DateTime SystemModstamp { set; get; }
        public string Description { set; get; }
        public DateTime LastViewedDate { set; get; }
        public DateTime LastReferencedDate { set; get; }
    }
}