// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This OData service is located at http://localhost
    /// </summary>
    public partial interface IDynamicsClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Show only the first n items
        /// </summary>
        int? Top158 { get; set; }

        /// <summary>
        /// Skip the first n items
        /// </summary>
        int? Skip79 { get; set; }

        /// <summary>
        /// Include count of items
        /// </summary>
        bool? Count158 { get; set; }

        /// <summary>
        /// Filter items by property values
        /// </summary>
        string Filter158 { get; set; }

        /// <summary>
        /// Search items by search phrases
        /// </summary>
        string Search79 { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IAccounts.
        /// </summary>
        IAccounts Accounts { get; }

        /// <summary>
        /// Gets the IAdoxiolicencetypeadoxioinvestigationset.
        /// </summary>
        IAdoxiolicencetypeadoxioinvestigationset Adoxiolicencetypeadoxioinvestigationset { get; }

        /// <summary>
        /// Gets the IAliases.
        /// </summary>
        IAliases Aliases { get; }

        /// <summary>
        /// Gets the IApplicationbpfmvpv2s.
        /// </summary>
        IApplicationbpfmvpv2s Applicationbpfmvpv2s { get; }

        /// <summary>
        /// Gets the IApplicationbpfv3s.
        /// </summary>
        IApplicationbpfv3s Applicationbpfv3s { get; }

        /// <summary>
        /// Gets the IApplicationinvoicehistories.
        /// </summary>
        IApplicationinvoicehistories Applicationinvoicehistories { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10s.
        /// </summary>
        IApplicationlicenseechangesv10s Applicationlicenseechangesv10s { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10asyncoperations.
        /// </summary>
        IApplicationlicenseechangesv10asyncoperations Applicationlicenseechangesv10asyncoperations { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10bulkdeletefailures.
        /// </summary>
        IApplicationlicenseechangesv10bulkdeletefailures Applicationlicenseechangesv10bulkdeletefailures { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10syncerrors.
        /// </summary>
        IApplicationlicenseechangesv10syncerrors Applicationlicenseechangesv10syncerrors { get; }

        /// <summary>
        /// Gets the IApplicationlicenseechangesv10workflowlogs.
        /// </summary>
        IApplicationlicenseechangesv10workflowlogs Applicationlicenseechangesv10workflowlogs { get; }

        /// <summary>
        /// Gets the IBpfadoxioapplicationid.
        /// </summary>
        IBpfadoxioapplicationid Bpfadoxioapplicationid { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1s.
        /// </summary>
        IApplicationrelocationv1s Applicationrelocationv1s { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1asyncoperations.
        /// </summary>
        IApplicationrelocationv1asyncoperations Applicationrelocationv1asyncoperations { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1bulkdeletefailures.
        /// </summary>
        IApplicationrelocationv1bulkdeletefailures Applicationrelocationv1bulkdeletefailures { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1syncerrors.
        /// </summary>
        IApplicationrelocationv1syncerrors Applicationrelocationv1syncerrors { get; }

        /// <summary>
        /// Gets the IApplicationrelocationv1workflowlogs.
        /// </summary>
        IApplicationrelocationv1workflowlogs Applicationrelocationv1workflowlogs { get; }

        /// <summary>
        /// Gets the IApplications.
        /// </summary>
        IApplications Applications { get; }

        /// <summary>
        /// Gets the IBpfadoxioapplicationadoxioapplicationlicenseechangesv10.
        /// </summary>
        IBpfadoxioapplicationadoxioapplicationlicenseechangesv10 Bpfadoxioapplicationadoxioapplicationlicenseechangesv10 { get; }

        /// <summary>
        /// Gets the IBpfadoxioapplicationadoxioapplicationrelocationv1.
        /// </summary>
        IBpfadoxioapplicationadoxioapplicationrelocationv1 Bpfadoxioapplicationadoxioapplicationrelocationv1 { get; }

        /// <summary>
        /// Gets the IBpfadoxioapplicationadoxioapplicationstructurechangev1.
        /// </summary>
        IBpfadoxioapplicationadoxioapplicationstructurechangev1 Bpfadoxioapplicationadoxioapplicationstructurechangev1 { get; }

        /// <summary>
        /// Gets the IBpfadoxioapplicationadoxioapplicationtransferownershipv1.
        /// </summary>
        IBpfadoxioapplicationadoxioapplicationtransferownershipv1 Bpfadoxioapplicationadoxioapplicationtransferownershipv1 { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1s.
        /// </summary>
        IApplicationstructurechangev1s Applicationstructurechangev1s { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1asyncoperations.
        /// </summary>
        IApplicationstructurechangev1asyncoperations Applicationstructurechangev1asyncoperations { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1bulkdeletefailures.
        /// </summary>
        IApplicationstructurechangev1bulkdeletefailures Applicationstructurechangev1bulkdeletefailures { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1syncerrors.
        /// </summary>
        IApplicationstructurechangev1syncerrors Applicationstructurechangev1syncerrors { get; }

        /// <summary>
        /// Gets the IApplicationstructurechangev1workflowlogs.
        /// </summary>
        IApplicationstructurechangev1workflowlogs Applicationstructurechangev1workflowlogs { get; }

        /// <summary>
        /// Gets the IApplicationtermsconditionslimitations.
        /// </summary>
        IApplicationtermsconditionslimitations Applicationtermsconditionslimitations { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1s.
        /// </summary>
        IApplicationtransferownershipv1s Applicationtransferownershipv1s { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1asyncoperations.
        /// </summary>
        IApplicationtransferownershipv1asyncoperations Applicationtransferownershipv1asyncoperations { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1bulkdeletefailures.
        /// </summary>
        IApplicationtransferownershipv1bulkdeletefailures Applicationtransferownershipv1bulkdeletefailures { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1syncerrors.
        /// </summary>
        IApplicationtransferownershipv1syncerrors Applicationtransferownershipv1syncerrors { get; }

        /// <summary>
        /// Gets the IApplicationtransferownershipv1workflowlogs.
        /// </summary>
        IApplicationtransferownershipv1workflowlogs Applicationtransferownershipv1workflowlogs { get; }

        /// <summary>
        /// Gets the IApplicationtypecontents.
        /// </summary>
        IApplicationtypecontents Applicationtypecontents { get; }

        /// <summary>
        /// Gets the IApplicationtypes.
        /// </summary>
        IApplicationtypes Applicationtypes { get; }

        /// <summary>
        /// Gets the IApplicationtypeformelementuploadfields.
        /// </summary>
        IApplicationtypeformelementuploadfields Applicationtypeformelementuploadfields { get; }

        /// <summary>
        /// Gets the IAreas.
        /// </summary>
        IAreas Areas { get; }

        /// <summary>
        /// Gets the IAuditlogrequests.
        /// </summary>
        IAuditlogrequests Auditlogrequests { get; }

        /// <summary>
        /// Gets the IBusinessaccounts.
        /// </summary>
        IBusinessaccounts Businessaccounts { get; }

        /// <summary>
        /// Gets the ICannabisinventoryreports.
        /// </summary>
        ICannabisinventoryreports Cannabisinventoryreports { get; }

        /// <summary>
        /// Gets the ICannabismonthlyreports.
        /// </summary>
        ICannabismonthlyreports Cannabismonthlyreports { get; }

        /// <summary>
        /// Gets the ICannabisproductadmins.
        /// </summary>
        ICannabisproductadmins Cannabisproductadmins { get; }

        /// <summary>
        /// Gets the ICitydistricts.
        /// </summary>
        ICitydistricts Citydistricts { get; }

        /// <summary>
        /// Gets the IComplaints.
        /// </summary>
        IComplaints Complaints { get; }

        /// <summary>
        /// Gets the IComplianceinvestigations.
        /// </summary>
        IComplianceinvestigations Complianceinvestigations { get; }

        /// <summary>
        /// Gets the IInvestigationexhibits.
        /// </summary>
        IInvestigationexhibits Investigationexhibits { get; }

        /// <summary>
        /// Gets the ICompliancemeetings.
        /// </summary>
        ICompliancemeetings Compliancemeetings { get; }

        /// <summary>
        /// Gets the ICompliancemeetingrelatedparties.
        /// </summary>
        ICompliancemeetingrelatedparties Compliancemeetingrelatedparties { get; }

        /// <summary>
        /// Gets the IContraventionadmins.
        /// </summary>
        IContraventionadmins Contraventionadmins { get; }

        /// <summary>
        /// Gets the IContraventions.
        /// </summary>
        IContraventions Contraventions { get; }

        /// <summary>
        /// Gets the ICorporatehistorysummaries.
        /// </summary>
        ICorporatehistorysummaries Corporatehistorysummaries { get; }

        /// <summary>
        /// Gets the ICorporateroles.
        /// </summary>
        ICorporateroles Corporateroles { get; }

        /// <summary>
        /// Gets the ICustomautonumberdefinitions.
        /// </summary>
        ICustomautonumberdefinitions Customautonumberdefinitions { get; }

        /// <summary>
        /// Gets the ICustomautonumberrequests.
        /// </summary>
        ICustomautonumberrequests Customautonumberrequests { get; }

        /// <summary>
        /// Gets the IDocumentadmins.
        /// </summary>
        IDocumentadmins Documentadmins { get; }

        /// <summary>
        /// Gets the IDocuments.
        /// </summary>
        IDocuments Documents { get; }

        /// <summary>
        /// Gets the IEstablishments.
        /// </summary>
        IEstablishments Establishments { get; }

        /// <summary>
        /// Gets the IEstablishmentwatchwords.
        /// </summary>
        IEstablishmentwatchwords Establishmentwatchwords { get; }

        /// <summary>
        /// Gets the IExhibits.
        /// </summary>
        IExhibits Exhibits { get; }

        /// <summary>
        /// Gets the IExhibitasyncoperations.
        /// </summary>
        IExhibitasyncoperations Exhibitasyncoperations { get; }

        /// <summary>
        /// Gets the IExhibitbulkdeletefailures.
        /// </summary>
        IExhibitbulkdeletefailures Exhibitbulkdeletefailures { get; }

        /// <summary>
        /// Gets the IExhibitduplicatebaserecord.
        /// </summary>
        IExhibitduplicatebaserecord Exhibitduplicatebaserecord { get; }

        /// <summary>
        /// Gets the IExhibitduplicatematchingrecord.
        /// </summary>
        IExhibitduplicatematchingrecord Exhibitduplicatematchingrecord { get; }

        /// <summary>
        /// Gets the IExhibitsyncerrors.
        /// </summary>
        IExhibitsyncerrors Exhibitsyncerrors { get; }

        /// <summary>
        /// Gets the IInvestigationid.
        /// </summary>
        IInvestigationid Investigationid { get; }

        /// <summary>
        /// Gets the IFiainvestigationlogs.
        /// </summary>
        IFiainvestigationlogs Fiainvestigationlogs { get; }

        /// <summary>
        /// Gets the IFormelementuploadfields.
        /// </summary>
        IFormelementuploadfields Formelementuploadfields { get; }

        /// <summary>
        /// Gets the IApplicationtypeid.
        /// </summary>
        IApplicationtypeid Applicationtypeid { get; }

        /// <summary>
        /// Gets the IFormelementuploadfieldasyncoperations.
        /// </summary>
        IFormelementuploadfieldasyncoperations Formelementuploadfieldasyncoperations { get; }

        /// <summary>
        /// Gets the IFormelementuploadfieldbulkdeletefailures.
        /// </summary>
        IFormelementuploadfieldbulkdeletefailures Formelementuploadfieldbulkdeletefailures { get; }

        /// <summary>
        /// Gets the IFormelementuploadfieldduplicatebaserecord.
        /// </summary>
        IFormelementuploadfieldduplicatebaserecord Formelementuploadfieldduplicatebaserecord { get; }

        /// <summary>
        /// Gets the IFormelementuploadfieldduplicatematchingrecord.
        /// </summary>
        IFormelementuploadfieldduplicatematchingrecord Formelementuploadfieldduplicatematchingrecord { get; }

        /// <summary>
        /// Gets the IFormelementuploadfieldsyncerrors.
        /// </summary>
        IFormelementuploadfieldsyncerrors Formelementuploadfieldsyncerrors { get; }

        /// <summary>
        /// Gets the IFundingsources.
        /// </summary>
        IFundingsources Fundingsources { get; }

        /// <summary>
        /// Gets the IIncidentadoxiolicencetypeset.
        /// </summary>
        IIncidentadoxiolicencetypeset Incidentadoxiolicencetypeset { get; }

        /// <summary>
        /// Gets the IInspectioninspectorsset.
        /// </summary>
        IInspectioninspectorsset Inspectioninspectorsset { get; }

        /// <summary>
        /// Gets the IInspectionreactivationhistories.
        /// </summary>
        IInspectionreactivationhistories Inspectionreactivationhistories { get; }

        /// <summary>
        /// Gets the IInspectorcommentsrollups.
        /// </summary>
        IInspectorcommentsrollups Inspectorcommentsrollups { get; }

        /// <summary>
        /// Gets the IInterests.
        /// </summary>
        IInterests Interests { get; }

        /// <summary>
        /// Gets the IInvestigationactivities.
        /// </summary>
        IInvestigationactivities Investigationactivities { get; }

        /// <summary>
        /// Gets the IInvestigationreactivationhistories.
        /// </summary>
        IInvestigationreactivationhistories Investigationreactivationhistories { get; }

        /// <summary>
        /// Gets the IInvestigations.
        /// </summary>
        IInvestigations Investigations { get; }

        /// <summary>
        /// Gets the ILegalentities.
        /// </summary>
        ILegalentities Legalentities { get; }

        /// <summary>
        /// Gets the ILegalentitytasklegalentity.
        /// </summary>
        ILegalentitytasklegalentity Legalentitytasklegalentity { get; }

        /// <summary>
        /// Gets the ILicenceses.
        /// </summary>
        ILicenceses Licenceses { get; }

        /// <summary>
        /// Gets the ILicencetypes.
        /// </summary>
        ILicencetypes Licencetypes { get; }

        /// <summary>
        /// Gets the ILicencetypesapplicationtypesset.
        /// </summary>
        ILicencetypesapplicationtypesset Licencetypesapplicationtypesset { get; }

        /// <summary>
        /// Gets the ILicenseechangelogs.
        /// </summary>
        ILicenseechangelogs Licenseechangelogs { get; }

        /// <summary>
        /// Gets the ILoans.
        /// </summary>
        ILoans Loans { get; }

        /// <summary>
        /// Gets the ILocalgovindigenousnations.
        /// </summary>
        ILocalgovindigenousnations Localgovindigenousnations { get; }

        /// <summary>
        /// Gets the IPersonalhistorysummaries.
        /// </summary>
        IPersonalhistorysummaries Personalhistorysummaries { get; }

        /// <summary>
        /// Gets the IPolicejurisdictions.
        /// </summary>
        IPolicejurisdictions Policejurisdictions { get; }

        /// <summary>
        /// Gets the IPolicydocuments.
        /// </summary>
        IPolicydocuments Policydocuments { get; }

        /// <summary>
        /// Gets the IPostalcodes.
        /// </summary>
        IPostalcodes Postalcodes { get; }

        /// <summary>
        /// Gets the IPreviousaddresses.
        /// </summary>
        IPreviousaddresses Previousaddresses { get; }

        /// <summary>
        /// Gets the IRegions.
        /// </summary>
        IRegions Regions { get; }

        /// <summary>
        /// Gets the IRelatedparties.
        /// </summary>
        IRelatedparties Relatedparties { get; }

        /// <summary>
        /// Gets the ICompliancemeetingid.
        /// </summary>
        ICompliancemeetingid Compliancemeetingid { get; }

        /// <summary>
        /// Gets the ISettings.
        /// </summary>
        ISettings Settings { get; }

        /// <summary>
        /// Gets the ISpddatarows.
        /// </summary>
        ISpddatarows Spddatarows { get; }

        /// <summary>
        /// Gets the ISpdexportses.
        /// </summary>
        ISpdexportses Spdexportses { get; }

        /// <summary>
        /// Gets the ITaxandaccountings.
        /// </summary>
        ITaxandaccountings Taxandaccountings { get; }

        /// <summary>
        /// Gets the ITermsconditionslimitationspresets.
        /// </summary>
        ITermsconditionslimitationspresets Termsconditionslimitationspresets { get; }

        /// <summary>
        /// Gets the ITerritories.
        /// </summary>
        ITerritories Territories { get; }

        /// <summary>
        /// Gets the ITiedhouseassociations.
        /// </summary>
        ITiedhouseassociations Tiedhouseassociations { get; }

        /// <summary>
        /// Gets the ITiedhouseconnections.
        /// </summary>
        ITiedhouseconnections Tiedhouseconnections { get; }

        /// <summary>
        /// Gets the IWitnesses.
        /// </summary>
        IWitnesses Witnesses { get; }

        /// <summary>
        /// Gets the IWorkerinvoicehistories.
        /// </summary>
        IWorkerinvoicehistories Workerinvoicehistories { get; }

        /// <summary>
        /// Gets the IWorkers.
        /// </summary>
        IWorkers Workers { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioapplicationlicenseechangesv10.
        /// </summary>
        IRegardingobjectidadoxioapplicationlicenseechangesv10 Regardingobjectidadoxioapplicationlicenseechangesv10 { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioapplicationrelocationv1.
        /// </summary>
        IRegardingobjectidadoxioapplicationrelocationv1 Regardingobjectidadoxioapplicationrelocationv1 { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioapplicationstructurechangev1.
        /// </summary>
        IRegardingobjectidadoxioapplicationstructurechangev1 Regardingobjectidadoxioapplicationstructurechangev1 { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioapplicationtransferownershipv1.
        /// </summary>
        IRegardingobjectidadoxioapplicationtransferownershipv1 Regardingobjectidadoxioapplicationtransferownershipv1 { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioexhibit.
        /// </summary>
        IRegardingobjectidadoxioexhibit Regardingobjectidadoxioexhibit { get; }

        /// <summary>
        /// Gets the IRegardingobjectidadoxioformelementuploadfield.
        /// </summary>
        IRegardingobjectidadoxioformelementuploadfield Regardingobjectidadoxioformelementuploadfield { get; }

        /// <summary>
        /// Gets the IBusinessunitadoxioexhibit.
        /// </summary>
        IBusinessunitadoxioexhibit Businessunitadoxioexhibit { get; }

        /// <summary>
        /// Gets the IBusinessunitadoxioformelementuploadfield.
        /// </summary>
        IBusinessunitadoxioformelementuploadfield Businessunitadoxioformelementuploadfield { get; }

        /// <summary>
        /// Gets the IContacts.
        /// </summary>
        IContacts Contacts { get; }

        /// <summary>
        /// Gets the IContacttaskcontact.
        /// </summary>
        IContacttaskcontact Contacttaskcontact { get; }

        /// <summary>
        /// Gets the IBaserecordidadoxioexhibit.
        /// </summary>
        IBaserecordidadoxioexhibit Baserecordidadoxioexhibit { get; }

        /// <summary>
        /// Gets the IBaserecordidadoxioformelementuploadfield.
        /// </summary>
        IBaserecordidadoxioformelementuploadfield Baserecordidadoxioformelementuploadfield { get; }

        /// <summary>
        /// Gets the IDuplicaterecordidadoxioexhibit.
        /// </summary>
        IDuplicaterecordidadoxioexhibit Duplicaterecordidadoxioexhibit { get; }

        /// <summary>
        /// Gets the IDuplicaterecordidadoxioformelementuploadfield.
        /// </summary>
        IDuplicaterecordidadoxioformelementuploadfield Duplicaterecordidadoxioformelementuploadfield { get; }

        /// <summary>
        /// Gets the IEntitydefinitions.
        /// </summary>
        IEntitydefinitions Entitydefinitions { get; }

        /// <summary>
        /// Gets the IGlobaloptionsetdefinitions.
        /// </summary>
        IGlobaloptionsetdefinitions Globaloptionsetdefinitions { get; }

        /// <summary>
        /// Gets the IInvoices.
        /// </summary>
        IInvoices Invoices { get; }

        /// <summary>
        /// Gets the ILeads.
        /// </summary>
        ILeads Leads { get; }

        /// <summary>
        /// Gets the ILists.
        /// </summary>
        ILists Lists { get; }

        /// <summary>
        /// Gets the IOrganizationadoxioapplicationlicenseechangesv10.
        /// </summary>
        IOrganizationadoxioapplicationlicenseechangesv10 Organizationadoxioapplicationlicenseechangesv10 { get; }

        /// <summary>
        /// Gets the IOrganizationadoxioapplicationrelocationv1.
        /// </summary>
        IOrganizationadoxioapplicationrelocationv1 Organizationadoxioapplicationrelocationv1 { get; }

        /// <summary>
        /// Gets the IOrganizationadoxioapplicationstructurechangev1.
        /// </summary>
        IOrganizationadoxioapplicationstructurechangev1 Organizationadoxioapplicationstructurechangev1 { get; }

        /// <summary>
        /// Gets the IOrganizationadoxioapplicationtransferownershipv1.
        /// </summary>
        IOrganizationadoxioapplicationtransferownershipv1 Organizationadoxioapplicationtransferownershipv1 { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationlicenseechangesv10activestageid.
        /// </summary>
        ILkadoxioapplicationlicenseechangesv10activestageid Lkadoxioapplicationlicenseechangesv10activestageid { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationrelocationv1activestageid.
        /// </summary>
        ILkadoxioapplicationrelocationv1activestageid Lkadoxioapplicationrelocationv1activestageid { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationstructurechangev1activestageid.
        /// </summary>
        ILkadoxioapplicationstructurechangev1activestageid Lkadoxioapplicationstructurechangev1activestageid { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationtransferownershipv1activestageid.
        /// </summary>
        ILkadoxioapplicationtransferownershipv1activestageid Lkadoxioapplicationtransferownershipv1activestageid { get; }

        /// <summary>
        /// Gets the ISavedqueries.
        /// </summary>
        ISavedqueries Savedqueries { get; }

        /// <summary>
        /// Gets the ISharepointdocumentlocations.
        /// </summary>
        ISharepointdocumentlocations Sharepointdocumentlocations { get; }

        /// <summary>
        /// Gets the ISharepointsites.
        /// </summary>
        ISharepointsites Sharepointsites { get; }

        /// <summary>
        /// Gets the ISystemforms.
        /// </summary>
        ISystemforms Systemforms { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationlicenseechangesv10createdby.
        /// </summary>
        ILkadoxioapplicationlicenseechangesv10createdby Lkadoxioapplicationlicenseechangesv10createdby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationlicenseechangesv10createdonbehalfby.
        /// </summary>
        ILkadoxioapplicationlicenseechangesv10createdonbehalfby Lkadoxioapplicationlicenseechangesv10createdonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationlicenseechangesv10modifiedby.
        /// </summary>
        ILkadoxioapplicationlicenseechangesv10modifiedby Lkadoxioapplicationlicenseechangesv10modifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationlicenseechangesv10modifiedonbehalfby.
        /// </summary>
        ILkadoxioapplicationlicenseechangesv10modifiedonbehalfby Lkadoxioapplicationlicenseechangesv10modifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationrelocationv1createdby.
        /// </summary>
        ILkadoxioapplicationrelocationv1createdby Lkadoxioapplicationrelocationv1createdby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationrelocationv1createdonbehalfby.
        /// </summary>
        ILkadoxioapplicationrelocationv1createdonbehalfby Lkadoxioapplicationrelocationv1createdonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationrelocationv1modifiedby.
        /// </summary>
        ILkadoxioapplicationrelocationv1modifiedby Lkadoxioapplicationrelocationv1modifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationrelocationv1modifiedonbehalfby.
        /// </summary>
        ILkadoxioapplicationrelocationv1modifiedonbehalfby Lkadoxioapplicationrelocationv1modifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationstructurechangev1createdby.
        /// </summary>
        ILkadoxioapplicationstructurechangev1createdby Lkadoxioapplicationstructurechangev1createdby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationstructurechangev1createdonbehalfby.
        /// </summary>
        ILkadoxioapplicationstructurechangev1createdonbehalfby Lkadoxioapplicationstructurechangev1createdonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationstructurechangev1modifiedby.
        /// </summary>
        ILkadoxioapplicationstructurechangev1modifiedby Lkadoxioapplicationstructurechangev1modifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationstructurechangev1modifiedonbehalfby.
        /// </summary>
        ILkadoxioapplicationstructurechangev1modifiedonbehalfby Lkadoxioapplicationstructurechangev1modifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationtransferownershipv1createdby.
        /// </summary>
        ILkadoxioapplicationtransferownershipv1createdby Lkadoxioapplicationtransferownershipv1createdby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationtransferownershipv1createdonbehalfby.
        /// </summary>
        ILkadoxioapplicationtransferownershipv1createdonbehalfby Lkadoxioapplicationtransferownershipv1createdonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationtransferownershipv1modifiedby.
        /// </summary>
        ILkadoxioapplicationtransferownershipv1modifiedby Lkadoxioapplicationtransferownershipv1modifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationtransferownershipv1modifiedonbehalfby.
        /// </summary>
        ILkadoxioapplicationtransferownershipv1modifiedonbehalfby Lkadoxioapplicationtransferownershipv1modifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioexhibitcreatedby.
        /// </summary>
        ILkadoxioexhibitcreatedby Lkadoxioexhibitcreatedby { get; }

        /// <summary>
        /// Gets the ILkadoxioexhibitcreatedonbehalfby.
        /// </summary>
        ILkadoxioexhibitcreatedonbehalfby Lkadoxioexhibitcreatedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioexhibitmodifiedby.
        /// </summary>
        ILkadoxioexhibitmodifiedby Lkadoxioexhibitmodifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioexhibitmodifiedonbehalfby.
        /// </summary>
        ILkadoxioexhibitmodifiedonbehalfby Lkadoxioexhibitmodifiedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioformelementuploadfieldcreatedby.
        /// </summary>
        ILkadoxioformelementuploadfieldcreatedby Lkadoxioformelementuploadfieldcreatedby { get; }

        /// <summary>
        /// Gets the ILkadoxioformelementuploadfieldcreatedonbehalfby.
        /// </summary>
        ILkadoxioformelementuploadfieldcreatedonbehalfby Lkadoxioformelementuploadfieldcreatedonbehalfby { get; }

        /// <summary>
        /// Gets the ILkadoxioformelementuploadfieldmodifiedby.
        /// </summary>
        ILkadoxioformelementuploadfieldmodifiedby Lkadoxioformelementuploadfieldmodifiedby { get; }

        /// <summary>
        /// Gets the ILkadoxioformelementuploadfieldmodifiedonbehalfby.
        /// </summary>
        ILkadoxioformelementuploadfieldmodifiedonbehalfby Lkadoxioformelementuploadfieldmodifiedonbehalfby { get; }

        /// <summary>
        /// Gets the IUseradoxioexhibit.
        /// </summary>
        IUseradoxioexhibit Useradoxioexhibit { get; }

        /// <summary>
        /// Gets the IUseradoxioformelementuploadfield.
        /// </summary>
        IUseradoxioformelementuploadfield Useradoxioformelementuploadfield { get; }

        /// <summary>
        /// Gets the IContacttask.
        /// </summary>
        IContacttask Contacttask { get; }

        /// <summary>
        /// Gets the ILegalentitytask.
        /// </summary>
        ILegalentitytask Legalentitytask { get; }

        /// <summary>
        /// Gets the ITeamadoxioexhibit.
        /// </summary>
        ITeamadoxioexhibit Teamadoxioexhibit { get; }

        /// <summary>
        /// Gets the ITeamadoxioformelementuploadfield.
        /// </summary>
        ITeamadoxioformelementuploadfield Teamadoxioformelementuploadfield { get; }

        /// <summary>
        /// Gets the IAsyncoperationidadoxioapplicationlicenseechangesv10.
        /// </summary>
        IAsyncoperationidadoxioapplicationlicenseechangesv10 Asyncoperationidadoxioapplicationlicenseechangesv10 { get; }

        /// <summary>
        /// Gets the IAsyncoperationidadoxioapplicationrelocationv1.
        /// </summary>
        IAsyncoperationidadoxioapplicationrelocationv1 Asyncoperationidadoxioapplicationrelocationv1 { get; }

        /// <summary>
        /// Gets the IAsyncoperationidadoxioapplicationstructurechangev1.
        /// </summary>
        IAsyncoperationidadoxioapplicationstructurechangev1 Asyncoperationidadoxioapplicationstructurechangev1 { get; }

        /// <summary>
        /// Gets the IAsyncoperationidadoxioapplicationtransferownershipv1.
        /// </summary>
        IAsyncoperationidadoxioapplicationtransferownershipv1 Asyncoperationidadoxioapplicationtransferownershipv1 { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationlicenseechangesv10processid.
        /// </summary>
        ILkadoxioapplicationlicenseechangesv10processid Lkadoxioapplicationlicenseechangesv10processid { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationrelocationv1processid.
        /// </summary>
        ILkadoxioapplicationrelocationv1processid Lkadoxioapplicationrelocationv1processid { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationstructurechangev1processid.
        /// </summary>
        ILkadoxioapplicationstructurechangev1processid Lkadoxioapplicationstructurechangev1processid { get; }

        /// <summary>
        /// Gets the ILkadoxioapplicationtransferownershipv1processid.
        /// </summary>
        ILkadoxioapplicationtransferownershipv1processid Lkadoxioapplicationtransferownershipv1processid { get; }

    }
}
