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
  public partial class ClaimRepository<ResourceType, ResourceHistoryType> : CommonResourceRepository<ResourceType, ResourceHistoryType>, IResourceRepository 
    where ResourceType : Res_Claim, new() 
    where ResourceHistoryType :Res_Claim_History, new()
  {
    public ClaimRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { }

    protected override void AddResourceHistoryEntityToResourceEntity(ResourceType ResourceEntity, ResourceHistoryType ResourceHistoryEntity)
    {
      ResourceEntity.Res_Claim_History_List.Add(ResourceHistoryEntity);
    }
    
    protected override ResourceType LoadCurrentResourceEntity(string FhirId)
    {
      var IncludeList = new List<Expression<Func<ResourceType, object>>>();
         IncludeList.Add(x => x.identifier_List);
      IncludeList.Add(x => x._profile_List);
      IncludeList.Add(x => x._security_List);
      IncludeList.Add(x => x._tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<ResourceType>(x => x.FhirId == FhirId, IncludeList);
      return ResourceEntity;
    }
    
    protected override void ResetResourceEntity(ResourceType ResourceEntity)
    {
      ResourceEntity.created_DateTimeOffset = null;      
      ResourceEntity.facility_identifier_Code = null;      
      ResourceEntity.facility_identifier_System = null;      
      ResourceEntity.facility_reference_VersionId = null;      
      ResourceEntity.facility_reference_FhirId = null;      
      ResourceEntity.facility_reference_Type = null;      
      ResourceEntity.facility_reference_Url = null;      
      ResourceEntity.facility_reference_ServiceRootURL_StoreID = null;      
      ResourceEntity.insurer_identifier_Code = null;      
      ResourceEntity.insurer_identifier_System = null;      
      ResourceEntity.insurer_reference_VersionId = null;      
      ResourceEntity.insurer_reference_FhirId = null;      
      ResourceEntity.insurer_reference_Type = null;      
      ResourceEntity.insurer_reference_Url = null;      
      ResourceEntity.insurer_reference_ServiceRootURL_StoreID = null;      
      ResourceEntity.organization_identifier_Code = null;      
      ResourceEntity.organization_identifier_System = null;      
      ResourceEntity.organization_reference_VersionId = null;      
      ResourceEntity.organization_reference_FhirId = null;      
      ResourceEntity.organization_reference_Type = null;      
      ResourceEntity.organization_reference_Url = null;      
      ResourceEntity.organization_reference_ServiceRootURL_StoreID = null;      
      ResourceEntity.patient_identifier_Code = null;      
      ResourceEntity.patient_identifier_System = null;      
      ResourceEntity.patient_reference_VersionId = null;      
      ResourceEntity.patient_reference_FhirId = null;      
      ResourceEntity.patient_reference_Type = null;      
      ResourceEntity.patient_reference_Url = null;      
      ResourceEntity.patient_reference_ServiceRootURL_StoreID = null;      
      ResourceEntity.priority_Code = null;      
      ResourceEntity.priority_System = null;      
      ResourceEntity.provider_identifier_Code = null;      
      ResourceEntity.provider_identifier_System = null;      
      ResourceEntity.provider_reference_VersionId = null;      
      ResourceEntity.provider_reference_FhirId = null;      
      ResourceEntity.provider_reference_Type = null;      
      ResourceEntity.provider_reference_Url = null;      
      ResourceEntity.provider_reference_ServiceRootURL_StoreID = null;      
      ResourceEntity.use_Code = null;      
      ResourceEntity.use_System = null;      
      ResourceEntity.XmlBlob = null;      
 
      
      _Context.Res_Claim_Index_identifier.RemoveRange(ResourceEntity.identifier_List);            
      _Context.Res_Claim_Index__profile.RemoveRange(ResourceEntity._profile_List);            
      _Context.Res_Claim_Index__security.RemoveRange(ResourceEntity._security_List);            
      _Context.Res_Claim_Index__tag.RemoveRange(ResourceEntity._tag_List);            
 
    }

    protected override void PopulateResourceEntity(ResourceType ResourceEntity, string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as Claim;
      var ResourseEntity = ResourceEntity as ResourceType;
      IndexSettingSupport.SetResourceBaseAddOrUpdate(ResourceTyped, ResourseEntity, ResourceVersion, false);

          if (ResourceTyped.Created != null)
      {
        if (ResourceTyped.CreatedElement is Hl7.Fhir.Model.FhirDateTime)
        {
          var Index = new DateTimeIndex();
          Index = IndexSetterFactory.Create(typeof(DateTimeIndex)).Set(ResourceTyped.CreatedElement, Index) as DateTimeIndex;
          if (Index != null)
          {
            ResourseEntity.created_DateTimeOffset = Index.DateTimeOffset;
          }
        }
      }

      if (ResourceTyped.Facility != null)
      {
        if (ResourceTyped.Facility is Hl7.Fhir.Model.Identifier)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Facility, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.facility_identifier_Code = Index.Code;
            ResourseEntity.facility_identifier_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Facility != null)
      {
        if (ResourceTyped.Facility is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Facility, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.facility_reference_Type = Index.Type;
            ResourseEntity.facility_reference_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.facility_reference_Url = Index.Url;
            }
            else
            {
              ResourseEntity.facility_reference_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Insurer != null)
      {
        if (ResourceTyped.Insurer is Hl7.Fhir.Model.Identifier)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Insurer, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.insurer_identifier_Code = Index.Code;
            ResourseEntity.insurer_identifier_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Insurer != null)
      {
        if (ResourceTyped.Insurer is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Insurer, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.insurer_reference_Type = Index.Type;
            ResourseEntity.insurer_reference_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.insurer_reference_Url = Index.Url;
            }
            else
            {
              ResourseEntity.insurer_reference_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Organization != null)
      {
        if (ResourceTyped.Organization is Hl7.Fhir.Model.Identifier)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Organization, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.organization_identifier_Code = Index.Code;
            ResourseEntity.organization_identifier_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Organization != null)
      {
        if (ResourceTyped.Organization is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Organization, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.organization_reference_Type = Index.Type;
            ResourseEntity.organization_reference_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.organization_reference_Url = Index.Url;
            }
            else
            {
              ResourseEntity.organization_reference_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Patient != null)
      {
        if (ResourceTyped.Patient is Hl7.Fhir.Model.Identifier)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Patient, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.patient_identifier_Code = Index.Code;
            ResourseEntity.patient_identifier_System = Index.System;
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
            ResourseEntity.patient_reference_Type = Index.Type;
            ResourseEntity.patient_reference_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.patient_reference_Url = Index.Url;
            }
            else
            {
              ResourseEntity.patient_reference_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Priority != null)
      {
        if (ResourceTyped.Priority is Hl7.Fhir.Model.Coding)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Priority, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.priority_Code = Index.Code;
            ResourseEntity.priority_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Provider != null)
      {
        if (ResourceTyped.Provider is Hl7.Fhir.Model.Identifier)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Provider, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.provider_identifier_Code = Index.Code;
            ResourseEntity.provider_identifier_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Provider != null)
      {
        if (ResourceTyped.Provider is Hl7.Fhir.Model.ResourceReference)
        {
          var Index = new ReferenceIndex();
          Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(ResourceTyped.Provider, Index, FhirRequestUri, this) as ReferenceIndex;
          if (Index != null)
          {
            ResourseEntity.provider_reference_Type = Index.Type;
            ResourseEntity.provider_reference_FhirId = Index.FhirId;
            if (Index.Url != null)
            {
              ResourseEntity.provider_reference_Url = Index.Url;
            }
            else
            {
              ResourseEntity.provider_reference_ServiceRootURL_StoreID = Index.ServiceRootURL_StoreID;
            }
          }
        }
      }

      if (ResourceTyped.Use_ != null)
      {
        if (ResourceTyped.Use_Element is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Claim.Use>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Use_Element, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.use_Code = Index.Code;
            ResourseEntity.use_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Identifier != null)
      {
        foreach (var item3 in ResourceTyped.Identifier)
        {
          if (item3 is Hl7.Fhir.Model.Identifier)
          {
            var Index = new Res_Claim_Index_identifier();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item3, Index) as Res_Claim_Index_identifier;
            ResourseEntity.identifier_List.Add(Index);
          }
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
              var Index = new Res_Claim_Index__profile();
              Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(item4, Index) as Res_Claim_Index__profile;
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
              var Index = new Res_Claim_Index__security();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_Claim_Index__security;
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
              var Index = new Res_Claim_Index__tag();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_Claim_Index__tag;
              ResourseEntity._tag_List.Add(Index);
            }
          }
        }
      }


      
    }

  }
} 
