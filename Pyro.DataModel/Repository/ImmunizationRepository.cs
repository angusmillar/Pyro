﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Pyro.DataModel.DatabaseModel;
using Pyro.DataModel.DatabaseModel.Base;
using Pyro.DataModel.Support;
using Pyro.DataModel.IndexSetter;
using Pyro.Common.Interfaces.Repositories;
using Pyro.Common.Interfaces.UriSupport;
using Hl7.Fhir.Model;

//This file was auto generated by _GenericCodeDataTypeEnumsGenerator.tt and should not be modified manually. 
//Generation time-stamp: : 3/11/2016 12:11:43 PM.

namespace Pyro.DataModel.Repository
{
  public partial class ImmunizationRepository<ResourceType, ResourceHistoryType> : CommonResourceRepository<ResourceType, ResourceHistoryType>, IResourceRepository 
    where ResourceType : Res_Immunization, new() 
    where ResourceHistoryType :Res_Immunization_History, new()
  {
    public ImmunizationRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { }

    protected override void AddResourceHistoryEntityToResourceEntity(ResourceType ResourceEntity, ResourceHistoryType ResourceHistoryEntity)
    {
      ResourceEntity.Res_Immunization_History_List.Add(ResourceHistoryEntity);
    }
    
    protected override ResourceType LoadCurrentResourceEntity(string FhirId)
    {
      var IncludeList = new List<Expression<Func<ResourceType, object>>>();
         IncludeList.Add(x => x.dose_sequence_List);
      IncludeList.Add(x => x.identifier_List);
      IncludeList.Add(x => x.reaction_List);
      IncludeList.Add(x => x.reaction_date_List);
      IncludeList.Add(x => x.reason_List);
      IncludeList.Add(x => x.reason_not_given_List);
      IncludeList.Add(x => x.vaccine_code_List);
      IncludeList.Add(x => x._profile_List);
      IncludeList.Add(x => x._security_List);
      IncludeList.Add(x => x._tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<ResourceType>(x => x.FhirId == FhirId, IncludeList);
      return ResourceEntity;
    }
    
    protected override void ResetResourceEntity(ResourceType ResourceEntity)
    {
      ResourceEntity.date_DateTimeOffset = null;      
      ResourceEntity.location_VersionId = null;      
      ResourceEntity.location_FhirId = null;      
      ResourceEntity.location_Type = null;      
      ResourceEntity.location_Url = null;      
      ResourceEntity.location_ServiceRootURL_StoreID = null;      
      ResourceEntity.lot_number_String = null;      
      ResourceEntity.manufacturer_VersionId = null;      
      ResourceEntity.manufacturer_FhirId = null;      
      ResourceEntity.manufacturer_Type = null;      
      ResourceEntity.manufacturer_Url = null;      
      ResourceEntity.manufacturer_ServiceRootURL_StoreID = null;      
      ResourceEntity.notgiven_Code = null;      
      ResourceEntity.notgiven_System = null;      
      ResourceEntity.patient_VersionId = null;      
      ResourceEntity.patient_FhirId = null;      
      ResourceEntity.patient_Type = null;      
      ResourceEntity.patient_Url = null;      
      ResourceEntity.patient_ServiceRootURL_StoreID = null;      
      ResourceEntity.performer_VersionId = null;      
      ResourceEntity.performer_FhirId = null;      
      ResourceEntity.performer_Type = null;      
      ResourceEntity.performer_Url = null;      
      ResourceEntity.performer_ServiceRootURL_StoreID = null;      
      ResourceEntity.requester_VersionId = null;      
      ResourceEntity.requester_FhirId = null;      
      ResourceEntity.requester_Type = null;      
      ResourceEntity.requester_Url = null;      
      ResourceEntity.requester_ServiceRootURL_StoreID = null;      
      ResourceEntity.status_Code = null;      
      ResourceEntity.status_System = null;      
      ResourceEntity.XmlBlob = null;      
 
      
      _Context.Res_Immunization_Index_dose_sequence.RemoveRange(ResourceEntity.dose_sequence_List);            
      _Context.Res_Immunization_Index_identifier.RemoveRange(ResourceEntity.identifier_List);            
      _Context.Res_Immunization_Index_reaction.RemoveRange(ResourceEntity.reaction_List);            
      _Context.Res_Immunization_Index_reaction_date.RemoveRange(ResourceEntity.reaction_date_List);            
      _Context.Res_Immunization_Index_reason.RemoveRange(ResourceEntity.reason_List);            
      _Context.Res_Immunization_Index_reason_not_given.RemoveRange(ResourceEntity.reason_not_given_List);            
      _Context.Res_Immunization_Index_vaccine_code.RemoveRange(ResourceEntity.vaccine_code_List);            
      _Context.Res_Immunization_Index__profile.RemoveRange(ResourceEntity._profile_List);            
      _Context.Res_Immunization_Index__security.RemoveRange(ResourceEntity._security_List);            
      _Context.Res_Immunization_Index__tag.RemoveRange(ResourceEntity._tag_List);            
 
    }

    protected override void PopulateResourceEntity(ResourceType ResourceEntity, string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as Immunization;
      var ResourseEntity = ResourceEntity as ResourceType;
      IndexSettingSupport.SetResourceBaseAddOrUpdate(ResourceTyped, ResourseEntity, ResourceVersion, false);

          if (ResourceTyped.Date != null)
      {
        if (ResourceTyped.DateElement is Hl7.Fhir.Model.FhirDateTime)
        {
          var Index = new DateTimeIndex();
          Index = IndexSetterFactory.Create(typeof(DateTimeIndex)).Set(ResourceTyped.DateElement, Index) as DateTimeIndex;
          if (Index != null)
          {
            ResourseEntity.date_DateTimeOffset = Index.DateTimeOffset;
          }
        }
      }

      if (ResourceTyped.Location != null)
      {
        if (ResourceTyped.Location is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Location, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.location_Type = Index.Type;
            ResourseEntity.location_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.location_Url = Index.Url;
            }
            else
            {
              ResourseEntity.location_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.LotNumber != null)
      {
        if (ResourceTyped.LotNumberElement is Hl7.Fhir.Model.FhirString)
        {
          var Index = new StringIndex();
          Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(ResourceTyped.LotNumberElement, Index) as StringIndex;
          if (Index != null)
          {
            ResourseEntity.lot_number_String = Index.String;
          }
        }
      }

      if (ResourceTyped.Manufacturer != null)
      {
        if (ResourceTyped.Manufacturer is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Manufacturer, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.manufacturer_Type = Index.Type;
            ResourseEntity.manufacturer_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.manufacturer_Url = Index.Url;
            }
            else
            {
              ResourseEntity.manufacturer_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.WasNotGiven != null)
      {
        if (ResourceTyped.WasNotGivenElement is Hl7.Fhir.Model.FhirBoolean)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.WasNotGivenElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.notgiven_Code = Index.Code;
            ResourseEntity.notgiven_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Patient != null)
      {
        if (ResourceTyped.Patient is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Patient, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.patient_Type = Index.Type;
            ResourseEntity.patient_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.patient_Url = Index.Url;
            }
            else
            {
              ResourseEntity.patient_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Performer != null)
      {
        if (ResourceTyped.Performer is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Performer, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.performer_Type = Index.Type;
            ResourseEntity.performer_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.performer_Url = Index.Url;
            }
            else
            {
              ResourseEntity.performer_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Requester != null)
      {
        if (ResourceTyped.Requester is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Requester, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.requester_Type = Index.Type;
            ResourseEntity.requester_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.requester_Url = Index.Url;
            }
            else
            {
              ResourseEntity.requester_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Status != null)
      {
        if (ResourceTyped.StatusElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.MedicationAdministrationStatus>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.StatusElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.status_Code = Index.Code;
            ResourseEntity.status_System = Index.System;
          }
        }
      }

      foreach (var item1 in ResourceTyped.VaccinationProtocol)
      {
        if (item1.DoseSequence != null)
        {
          if (item1.DoseSequenceElement is Hl7.Fhir.Model.PositiveInt)
          {
            var Index = new Res_Immunization_Index_dose_sequence();
            Index = IndexSetterFactory.Create(typeof(NumberIndex)).Set(item1.DoseSequenceElement, Index) as Res_Immunization_Index_dose_sequence;
            ResourseEntity.dose_sequence_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Identifier != null)
      {
        foreach (var item3 in ResourceTyped.Identifier)
        {
          if (item3 is Hl7.Fhir.Model.Identifier)
          {
            var Index = new Res_Immunization_Index_identifier();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item3, Index) as Res_Immunization_Index_identifier;
            ResourseEntity.identifier_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Reaction)
      {
        if (item1.Detail != null)
        {
          if (item1.Detail is ResourceReference)
          {
            var Index = new Res_Immunization_Index_reaction();
            Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item1.Detail, Index, FhirRequestUri, this) as Res_Immunization_Index_reaction;
            if (Index != null)
            {
              ResourseEntity.reaction_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Reaction)
      {
        if (item1.Date != null)
        {
          if (item1.DateElement is Hl7.Fhir.Model.FhirDateTime)
          {
            var Index = new Res_Immunization_Index_reaction_date();
            Index = IndexSetterFactory.Create(typeof(DateTimeIndex)).Set(item1.DateElement, Index) as Res_Immunization_Index_reaction_date;
            ResourseEntity.reaction_date_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Explanation != null)
      {
        if (ResourceTyped.Explanation.Reason != null)
        {
          foreach (var item4 in ResourceTyped.Explanation.Reason)
          {
            if (item4 != null)
            {
              foreach (var item5 in item4.Coding)
              {
                var Index = new Res_Immunization_Index_reason();
                Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item5, Index) as Res_Immunization_Index_reason;
                ResourseEntity.reason_List.Add(Index);
              }
            }
          }
        }
      }

      if (ResourceTyped.Explanation != null)
      {
        if (ResourceTyped.Explanation.ReasonNotGiven != null)
        {
          foreach (var item4 in ResourceTyped.Explanation.ReasonNotGiven)
          {
            if (item4 != null)
            {
              foreach (var item5 in item4.Coding)
              {
                var Index = new Res_Immunization_Index_reason_not_given();
                Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item5, Index) as Res_Immunization_Index_reason_not_given;
                ResourseEntity.reason_not_given_List.Add(Index);
              }
            }
          }
        }
      }

      if (ResourceTyped.VaccineCode != null)
      {
        foreach (var item3 in ResourceTyped.VaccineCode.Coding)
        {
          var Index = new Res_Immunization_Index_vaccine_code();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item3, Index) as Res_Immunization_Index_vaccine_code;
          ResourseEntity.vaccine_code_List.Add(Index);
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Profile != null)
        {
          foreach (var item4 in ResourceTyped.Meta.ProfileElement)
          {
            if (item4 is Hl7.Fhir.Model.FhirUri)
            {
              var Index = new Res_Immunization_Index__profile();
              Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(item4, Index) as Res_Immunization_Index__profile;
              ResourseEntity._profile_List.Add(Index);
            }
          }
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Security != null)
        {
          foreach (var item4 in ResourceTyped.Meta.Security)
          {
            if (item4 is Hl7.Fhir.Model.Coding)
            {
              var Index = new Res_Immunization_Index__security();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_Immunization_Index__security;
              ResourseEntity._security_List.Add(Index);
            }
          }
        }
      }

      if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Tag != null)
        {
          foreach (var item4 in ResourceTyped.Meta.Tag)
          {
            if (item4 is Hl7.Fhir.Model.Coding)
            {
              var Index = new Res_Immunization_Index__tag();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_Immunization_Index__tag;
              ResourseEntity._tag_List.Add(Index);
            }
          }
        }
      }


      
    }

  }
} 
