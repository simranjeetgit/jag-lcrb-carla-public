// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft.Dynamics.CRM.marketingformdisplayattributes
    /// </summary>
    public partial class MicrosoftDynamicsCRMmarketingformdisplayattributes
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmarketingformdisplayattributes class.
        /// </summary>
        public MicrosoftDynamicsCRMmarketingformdisplayattributes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMmarketingformdisplayattributes class.
        /// </summary>
        public MicrosoftDynamicsCRMmarketingformdisplayattributes(string _organizationidValue = default(string), string _modifiedbyValue = default(string), string _createdbyValue = default(string), string versionnumber = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? utcconversiontimezonecode = default(int?), string entitylogicalname = default(string), int? statecode = default(int?), int? timezoneruleversionnumber = default(int?), int? statuscode = default(int?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string name = default(string), string _modifiedonbehalfbyValue = default(string), string marketingformdisplayattributesid = default(string), string _createdonbehalfbyValue = default(string), string displayattributelist = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> marketingformdisplayattributesSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> marketingformdisplayattributesDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> marketingformdisplayattributesDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> marketingformdisplayattributesAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMmailboxtrackingfolder> marketingformdisplayattributesMailboxTrackingFolders = default(IList<MicrosoftDynamicsCRMmailboxtrackingfolder>), IList<MicrosoftDynamicsCRMprocesssession> marketingformdisplayattributesProcessSession = default(IList<MicrosoftDynamicsCRMprocesssession>), IList<MicrosoftDynamicsCRMbulkdeletefailure> marketingformdisplayattributesBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> marketingformdisplayattributesPrincipalObjectAttributeAccesses = default(IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess>))
        {
            this._organizationidValue = _organizationidValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._createdbyValue = _createdbyValue;
            Versionnumber = versionnumber;
            Createdon = createdon;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Entitylogicalname = entitylogicalname;
            Statecode = statecode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Statuscode = statuscode;
            Modifiedon = modifiedon;
            Name = name;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Marketingformdisplayattributesid = marketingformdisplayattributesid;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Displayattributelist = displayattributelist;
            Overriddencreatedon = overriddencreatedon;
            Importsequencenumber = importsequencenumber;
            Createdby = createdby;
            Createdonbehalfby = createdonbehalfby;
            Modifiedby = modifiedby;
            Modifiedonbehalfby = modifiedonbehalfby;
            Organizationid = organizationid;
            MarketingformdisplayattributesSyncErrors = marketingformdisplayattributesSyncErrors;
            MarketingformdisplayattributesDuplicateMatchingRecord = marketingformdisplayattributesDuplicateMatchingRecord;
            MarketingformdisplayattributesDuplicateBaseRecord = marketingformdisplayattributesDuplicateBaseRecord;
            MarketingformdisplayattributesAsyncOperations = marketingformdisplayattributesAsyncOperations;
            MarketingformdisplayattributesMailboxTrackingFolders = marketingformdisplayattributesMailboxTrackingFolders;
            MarketingformdisplayattributesProcessSession = marketingformdisplayattributesProcessSession;
            MarketingformdisplayattributesBulkDeleteFailures = marketingformdisplayattributesBulkDeleteFailures;
            MarketingformdisplayattributesPrincipalObjectAttributeAccesses = marketingformdisplayattributesPrincipalObjectAttributeAccesses;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public string Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "entitylogicalname")]
        public string Entitylogicalname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributesid")]
        public string Marketingformdisplayattributesid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayattributelist")]
        public string Displayattributelist { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> MarketingformdisplayattributesSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MarketingformdisplayattributesDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> MarketingformdisplayattributesDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> MarketingformdisplayattributesAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_MailboxTrackingFolders")]
        public IList<MicrosoftDynamicsCRMmailboxtrackingfolder> MarketingformdisplayattributesMailboxTrackingFolders { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_ProcessSession")]
        public IList<MicrosoftDynamicsCRMprocesssession> MarketingformdisplayattributesProcessSession { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> MarketingformdisplayattributesBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "marketingformdisplayattributes_PrincipalObjectAttributeAccesses")]
        public IList<MicrosoftDynamicsCRMprincipalobjectattributeaccess> MarketingformdisplayattributesPrincipalObjectAttributeAccesses { get; set; }

    }
}