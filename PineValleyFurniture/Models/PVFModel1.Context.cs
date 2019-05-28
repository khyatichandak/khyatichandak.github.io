﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G6_PVFAPP.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DoesBusinessIn> DoesBusinessIns { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public virtual DbSet<HasSkill> HasSkills { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductLine> ProductLines { get; set; }
        public virtual DbSet<RawMaterial> RawMaterials { get; set; }
        public virtual DbSet<SalesPerson> SalesPersons { get; set; }
        public virtual DbSet<Supply> Supplies { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }
        public virtual DbSet<Us> Uses { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<WorkCenter> WorkCenters { get; set; }
        public virtual DbSet<WorksIn> WorksIns { get; set; }
        public virtual DbSet<tblAttribute> tblAttributes { get; set; }
        public virtual DbSet<tblAttributeGroup> tblAttributeGroups { get; set; }
        public virtual DbSet<tblAttributeGroupDetail> tblAttributeGroupDetails { get; set; }
        public virtual DbSet<tblBRBusinessRule> tblBRBusinessRules { get; set; }
        public virtual DbSet<tblBRItem> tblBRItems { get; set; }
        public virtual DbSet<tblBRItemProperty> tblBRItemProperties { get; set; }
        public virtual DbSet<tblBRItemTypeAppliesTo> tblBRItemTypeAppliesToes { get; set; }
        public virtual DbSet<tblBRLogicalOperatorGroup> tblBRLogicalOperatorGroups { get; set; }
        public virtual DbSet<tblBRStatusTransition> tblBRStatusTransitions { get; set; }
        public virtual DbSet<tblCodeGenInfo> tblCodeGenInfoes { get; set; }
        public virtual DbSet<tblDBError> tblDBErrors { get; set; }
        public virtual DbSet<tblDBUpgradeHistory> tblDBUpgradeHistories { get; set; }
        public virtual DbSet<tblDerivedHierarchy> tblDerivedHierarchies { get; set; }
        public virtual DbSet<tblDerivedHierarchyDetail> tblDerivedHierarchyDetails { get; set; }
        public virtual DbSet<tblEntity> tblEntities { get; set; }
        public virtual DbSet<tblErrorCodesMapping> tblErrorCodesMappings { get; set; }
        public virtual DbSet<tblEvent> tblEvents { get; set; }
        public virtual DbSet<tblExternalSystem> tblExternalSystems { get; set; }
        public virtual DbSet<tblFile> tblFiles { get; set; }
        public virtual DbSet<tblHierarchy> tblHierarchies { get; set; }
        public virtual DbSet<tblIndex> tblIndexes { get; set; }
        public virtual DbSet<tblList> tblLists { get; set; }
        public virtual DbSet<tblListRelationship> tblListRelationships { get; set; }
        public virtual DbSet<tblListRelationshipType> tblListRelationshipTypes { get; set; }
        public virtual DbSet<tblLocalizedString> tblLocalizedStrings { get; set; }
        public virtual DbSet<tblModel> tblModels { get; set; }
        public virtual DbSet<tblModelVersion> tblModelVersions { get; set; }
        public virtual DbSet<tblModelVersionFlag> tblModelVersionFlags { get; set; }
        public virtual DbSet<tblNotificationQueue> tblNotificationQueues { get; set; }
        public virtual DbSet<tblNotificationUser> tblNotificationUsers { get; set; }
        public virtual DbSet<tblSecurityAccessControl> tblSecurityAccessControls { get; set; }
        public virtual DbSet<tblSecurityObject> tblSecurityObjects { get; set; }
        public virtual DbSet<tblSecurityPrivilege> tblSecurityPrivileges { get; set; }
        public virtual DbSet<tblSecurityPrivilegeFunctional> tblSecurityPrivilegeFunctionals { get; set; }
        public virtual DbSet<tblSecurityRole> tblSecurityRoles { get; set; }
        public virtual DbSet<tblSecurityRoleAccess> tblSecurityRoleAccesses { get; set; }
        public virtual DbSet<tblSecurityRoleAccessFunctional> tblSecurityRoleAccessFunctionals { get; set; }
        public virtual DbSet<tblSecurityRoleAccessMember> tblSecurityRoleAccessMembers { get; set; }
        public virtual DbSet<tblStgBatch> tblStgBatches { get; set; }
        public virtual DbSet<tblStgErrorDetail> tblStgErrorDetails { get; set; }
        public virtual DbSet<tblSubscriptionView> tblSubscriptionViews { get; set; }
        public virtual DbSet<tblSyncRelationship> tblSyncRelationships { get; set; }
        public virtual DbSet<tblSystem> tblSystems { get; set; }
        public virtual DbSet<tblSystemSetting> tblSystemSettings { get; set; }
        public virtual DbSet<tblSystemSettingGroup> tblSystemSettingGroups { get; set; }
        public virtual DbSet<tblUser> tblUsers { get; set; }
        public virtual DbSet<tblUserGroup> tblUserGroups { get; set; }
        public virtual DbSet<tblUserGroupAssignment> tblUserGroupAssignments { get; set; }
        public virtual DbSet<tblUserPreference> tblUserPreferences { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ProducedIn> ProducedIns { get; set; }
        public virtual DbSet<tblDataQualityOperationsState> tblDataQualityOperationsStates { get; set; }
        public virtual DbSet<viw_EntityStagingBatchesAllProcessed> viw_EntityStagingBatchesAllProcessed { get; set; }
        public virtual DbSet<viw_EntityStagingBatchesAllProcessedExceptCleared> viw_EntityStagingBatchesAllProcessedExceptCleared { get; set; }
        public virtual DbSet<viw_SYSTEM_BUSINESSRULES_ATTRIBUTE_INHERITANCE_HIERARCHY> viw_SYSTEM_BUSINESSRULES_ATTRIBUTE_INHERITANCE_HIERARCHY { get; set; }
        public virtual DbSet<viw_SYSTEM_BUSINESSRULES_HIERARCHY_CHANGEVALUE_INHERITANCE> viw_SYSTEM_BUSINESSRULES_HIERARCHY_CHANGEVALUE_INHERITANCE { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_ATTRIBUTEGROUPS> viw_SYSTEM_SCHEMA_ATTRIBUTEGROUPS { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_ATTRIBUTES> viw_SYSTEM_SCHEMA_ATTRIBUTES { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_BUSINESSRULE_ITEMTYPES> viw_SYSTEM_SCHEMA_BUSINESSRULE_ITEMTYPES { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_BUSINESSRULE_PROPERTIES> viw_SYSTEM_SCHEMA_BUSINESSRULE_PROPERTIES { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_BUSINESSRULE_PROPERTIES_ATTRIBUTES> viw_SYSTEM_SCHEMA_BUSINESSRULE_PROPERTIES_ATTRIBUTES { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_BUSINESSRULES> viw_SYSTEM_SCHEMA_BUSINESSRULES { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_ENTITY> viw_SYSTEM_SCHEMA_ENTITY { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_ENTITY_MEMBERTYPE> viw_SYSTEM_SCHEMA_ENTITY_MEMBERTYPE { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_HIERARCHY_DERIVED> viw_SYSTEM_SCHEMA_HIERARCHY_DERIVED { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_HIERARCHY_DERIVED_LEVELS> viw_SYSTEM_SCHEMA_HIERARCHY_DERIVED_LEVELS { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_HIERARCHY_EXPLICIT> viw_SYSTEM_SCHEMA_HIERARCHY_EXPLICIT { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_INDEXES> viw_SYSTEM_SCHEMA_INDEXES { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_MODEL> viw_SYSTEM_SCHEMA_MODEL { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_MODELS> viw_SYSTEM_SCHEMA_MODELS { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_SYSTEMSETTINGS> viw_SYSTEM_SCHEMA_SYSTEMSETTINGS { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_VERSION> viw_SYSTEM_SCHEMA_VERSION { get; set; }
        public virtual DbSet<viw_SYSTEM_SCHEMA_VERSION_FLAGS> viw_SYSTEM_SCHEMA_VERSION_FLAGS { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_ROLE> viw_SYSTEM_SECURITY_ROLE { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_ROLE_ACCESSCONTROL> viw_SYSTEM_SECURITY_ROLE_ACCESSCONTROL { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_ROLE_ACCESSCONTROL_FUNCTIONAL> viw_SYSTEM_SECURITY_ROLE_ACCESSCONTROL_FUNCTIONAL { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_ROLE_ACCESSCONTROL_MEMBER> viw_SYSTEM_SECURITY_ROLE_ACCESSCONTROL_MEMBER { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_ROLE_MEMBER> viw_SYSTEM_SECURITY_ROLE_MEMBER { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER> viw_SYSTEM_SECURITY_USER { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_ATTRIBUTE> viw_SYSTEM_SECURITY_USER_ATTRIBUTE { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_ATTRIBUTEGROUP> viw_SYSTEM_SECURITY_USER_ATTRIBUTEGROUP { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_ENTITY> viw_SYSTEM_SECURITY_USER_ENTITY { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_FUNCTION> viw_SYSTEM_SECURITY_USER_FUNCTION { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_HIERARCHY> viw_SYSTEM_SECURITY_USER_HIERARCHY { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_HIERARCHY_DERIVED> viw_SYSTEM_SECURITY_USER_HIERARCHY_DERIVED { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_INDEX> viw_SYSTEM_SECURITY_USER_INDEX { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_MEMBER> viw_SYSTEM_SECURITY_USER_MEMBER { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_MEMBERTYPE> viw_SYSTEM_SECURITY_USER_MEMBERTYPE { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_MODEL> viw_SYSTEM_SECURITY_USER_MODEL { get; set; }
        public virtual DbSet<viw_SYSTEM_SECURITY_USER_ROLE> viw_SYSTEM_SECURITY_USER_ROLE { get; set; }
        public virtual DbSet<viw_SYSTEM_USERGROUP_USERS> viw_SYSTEM_USERGROUP_USERS { get; set; }
        public virtual DbSet<viw_SYSTEM_VERSION> viw_SYSTEM_VERSION { get; set; }
    }
}
