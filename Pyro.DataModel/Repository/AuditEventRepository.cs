﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Pyro.DataModel.DatabaseModel;
using Pyro.DataModel.DatabaseModel.Base;
using Pyro.DataModel.Support;
using Pyro.DataModel.IndexSetter;
using Pyro.Common.Interfaces.Repositories;
using Pyro.Common.Interfaces.UriSupport;
using Pyro.Common.BusinessEntities.Dto;
using Hl7.Fhir.Model;

//This file was auto generated by _GenericCodeDataTypeEnumsGenerator.tt and should not be modified manually. 
//Generation time-stamp: : 22/11/2016 5:12:01 PM.

namespace Pyro.DataModel.Repository
{
  public partial class AuditEventRepository<ResourceType, ResourceHistoryType> : CommonResourceRepository<ResourceType, ResourceHistoryType>, IResourceRepository 
    where ResourceType : Res_AuditEvent, new() 
    where ResourceHistoryType :Res_AuditEvent_History, new()
  {
    public AuditEventRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { this.RepositoryResourceType = FHIRAllTypes.AuditEvent; }

    protected override void GetResourceHistoryEntityList(LinqKit.ExpressionStarter<ResourceType> Predicate, int StartRecord, List<DtoResource> DtoResourceList)
    {
      var HistoryEntityList = DbGetAll<ResourceType>(Predicate).SelectMany(y => y.Res_AuditEvent_History_List)
        .OrderByDescending(x => x.lastUpdated)
        .Skip(StartRecord)
        .Take(_NumberOfRecordsPerPage)
        .ToList();

      if (HistoryEntityList != null)
        HistoryEntityList.ForEach(x => DtoResourceList.Add(IndexSettingSupport.SetDtoResource(x, this.RepositoryResourceType, false)));
    }

    protected override int GetResourceHistoryEntityCount(LinqKit.ExpressionStarter<ResourceType> Predicate)
    {
      return DbGetAll<ResourceType>(Predicate).SelectMany(y => y.Res_AuditEvent_History_List).Count();      
    }

    protected override void AddResourceHistoryEntityToResourceEntity(ResourceType ResourceEntity, ResourceHistoryType ResourceHistoryEntity)
    {
      ResourceEntity.Res_AuditEvent_History_List.Add(ResourceHistoryEntity);
    }
    
    protected override ResourceType LoadCurrentResourceEntity(string FhirId)
    {
      var IncludeList = new List<Expression<Func<ResourceType, object>>>();
         IncludeList.Add(x => x.address_List);
      IncludeList.Add(x => x.agent_List);
      IncludeList.Add(x => x.agent_name_List);
      IncludeList.Add(x => x.altid_List);
      IncludeList.Add(x => x.entity_List);
      IncludeList.Add(x => x.entity_id_List);
      IncludeList.Add(x => x.entity_name_List);
      IncludeList.Add(x => x.entity_type_List);
      IncludeList.Add(x => x.patient_List);
      IncludeList.Add(x => x.patient_List);
      IncludeList.Add(x => x.policy_List);
      IncludeList.Add(x => x.role_List);
      IncludeList.Add(x => x.subtype_List);
      IncludeList.Add(x => x.user_List);
      IncludeList.Add(x => x._profile_List);
      IncludeList.Add(x => x._security_List);
      IncludeList.Add(x => x._tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<ResourceType>(x => x.FhirId == FhirId, IncludeList);
      return ResourceEntity;
    }
    
    protected override void ResetResourceEntity(ResourceType ResourceEntity)
    {
      ResourceEntity.action_Code = null;      
      ResourceEntity.action_System = null;      
      ResourceEntity.date_DateTimeOffset = null;      
      ResourceEntity.outcome_Code = null;      
      ResourceEntity.outcome_System = null;      
      ResourceEntity.site_Code = null;      
      ResourceEntity.site_System = null;      
      ResourceEntity.source_Code = null;      
      ResourceEntity.source_System = null;      
      ResourceEntity.type_Code = null;      
      ResourceEntity.type_System = null;      
 
      
      _Context.Res_AuditEvent_Index_address.RemoveRange(ResourceEntity.address_List);            
      _Context.Res_AuditEvent_Index_agent.RemoveRange(ResourceEntity.agent_List);            
      _Context.Res_AuditEvent_Index_agent_name.RemoveRange(ResourceEntity.agent_name_List);            
      _Context.Res_AuditEvent_Index_altid.RemoveRange(ResourceEntity.altid_List);            
      _Context.Res_AuditEvent_Index_entity.RemoveRange(ResourceEntity.entity_List);            
      _Context.Res_AuditEvent_Index_entity_id.RemoveRange(ResourceEntity.entity_id_List);            
      _Context.Res_AuditEvent_Index_entity_name.RemoveRange(ResourceEntity.entity_name_List);            
      _Context.Res_AuditEvent_Index_entity_type.RemoveRange(ResourceEntity.entity_type_List);            
      _Context.Res_AuditEvent_Index_patient.RemoveRange(ResourceEntity.patient_List);            
      _Context.Res_AuditEvent_Index_patient.RemoveRange(ResourceEntity.patient_List);            
      _Context.Res_AuditEvent_Index_policy.RemoveRange(ResourceEntity.policy_List);            
      _Context.Res_AuditEvent_Index_role.RemoveRange(ResourceEntity.role_List);            
      _Context.Res_AuditEvent_Index_subtype.RemoveRange(ResourceEntity.subtype_List);            
      _Context.Res_AuditEvent_Index_user.RemoveRange(ResourceEntity.user_List);            
      _Context.Res_AuditEvent_Index__profile.RemoveRange(ResourceEntity._profile_List);            
      _Context.Res_AuditEvent_Index__security.RemoveRange(ResourceEntity._security_List);            
      _Context.Res_AuditEvent_Index__tag.RemoveRange(ResourceEntity._tag_List);            
 
    }

    protected override void PopulateResourceEntity(ResourceType ResourceEntity, string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as AuditEvent;
      var ResourseEntity = ResourceEntity as ResourceType;

          if (ResourceTyped.Action != null)
      {
        if (ResourceTyped.ActionElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventAction>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.ActionElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.action_Code = Index.Code;
            ResourseEntity.action_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Recorded != null)
      {
        if (ResourceTyped.RecordedElement is Hl7.Fhir.Model.Instant)
        {
          var Index = new DateTimeIndex();
          Index = IndexSetterFactory.Create(typeof(DateTimeIndex)).Set(ResourceTyped.RecordedElement, Index) as DateTimeIndex;
          if (Index != null)
          {
            ResourseEntity.date_DateTimeOffset = Index.DateTimeOffset;
          }
        }
      }

      if (ResourceTyped.Outcome != null)
      {
        if (ResourceTyped.OutcomeElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.AuditEvent.AuditEventOutcome>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.OutcomeElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.outcome_Code = Index.Code;
            ResourseEntity.outcome_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Source != null)
      {
        if (ResourceTyped.Source.Site != null)
        {
          if (ResourceTyped.Source.SiteElement is Hl7.Fhir.Model.FhirString)
          {
            var Index = new TokenIndex();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Source.SiteElement, Index) as TokenIndex;
            if (Index != null)
            {
              ResourseEntity.site_Code = Index.Code;
              ResourseEntity.site_System = Index.System;
            }
          }
        }
      }

      if (ResourceTyped.Source != null)
      {
        if (ResourceTyped.Source.Identifier != null)
        {
          if (ResourceTyped.Source.Identifier is Hl7.Fhir.Model.Identifier)
          {
            var Index = new TokenIndex();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Source.Identifier, Index) as TokenIndex;
            if (Index != null)
            {
              ResourseEntity.source_Code = Index.Code;
              ResourseEntity.source_System = Index.System;
            }
          }
        }
      }

      if (ResourceTyped.Type != null)
      {
        if (ResourceTyped.Type is Hl7.Fhir.Model.Coding)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.Type, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.type_Code = Index.Code;
            ResourseEntity.type_System = Index.System;
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Network != null)
        {
          if (item1.Network.Address != null)
          {
            if (item1.Network.AddressElement is Hl7.Fhir.Model.FhirString)
            {
              var Index = new Res_AuditEvent_Index_address();
              Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(item1.Network.AddressElement, Index) as Res_AuditEvent_Index_address;
              ResourseEntity.address_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Reference != null)
        {
          if (item1.Reference is ResourceReference)
          {
            var Index = new Res_AuditEvent_Index_agent();
            Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item1.Reference, Index, FhirRequestUri, this) as Res_AuditEvent_Index_agent;
            if (Index != null)
            {
              ResourseEntity.agent_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Name != null)
        {
          if (item1.NameElement is Hl7.Fhir.Model.FhirString)
          {
            var Index = new Res_AuditEvent_Index_agent_name();
            Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(item1.NameElement, Index) as Res_AuditEvent_Index_agent_name;
            ResourseEntity.agent_name_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.AltId != null)
        {
          if (item1.AltIdElement is Hl7.Fhir.Model.FhirString)
          {
            var Index = new Res_AuditEvent_Index_altid();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item1.AltIdElement, Index) as Res_AuditEvent_Index_altid;
            ResourseEntity.altid_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Reference != null)
        {
          if (item1.Reference is ResourceReference)
          {
            var Index = new Res_AuditEvent_Index_entity();
            Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item1.Reference, Index, FhirRequestUri, this) as Res_AuditEvent_Index_entity;
            if (Index != null)
            {
              ResourseEntity.entity_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Identifier != null)
        {
          if (item1.Identifier is Hl7.Fhir.Model.Identifier)
          {
            var Index = new Res_AuditEvent_Index_entity_id();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item1.Identifier, Index) as Res_AuditEvent_Index_entity_id;
            ResourseEntity.entity_id_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Name != null)
        {
          if (item1.NameElement is Hl7.Fhir.Model.FhirString)
          {
            var Index = new Res_AuditEvent_Index_entity_name();
            Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(item1.NameElement, Index) as Res_AuditEvent_Index_entity_name;
            ResourseEntity.entity_name_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Type != null)
        {
          if (item1.Type is Hl7.Fhir.Model.Coding)
          {
            var Index = new Res_AuditEvent_Index_entity_type();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item1.Type, Index) as Res_AuditEvent_Index_entity_type;
            ResourseEntity.entity_type_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Reference != null)
        {
          if (item1.Reference is ResourceReference)
          {
            var Index = new Res_AuditEvent_Index_patient();
            Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item1.Reference, Index, FhirRequestUri, this) as Res_AuditEvent_Index_patient;
            if (Index != null)
            {
              ResourseEntity.patient_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Reference != null)
        {
          if (item1.Reference is ResourceReference)
          {
            var Index = new Res_AuditEvent_Index_patient();
            Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item1.Reference, Index, FhirRequestUri, this) as Res_AuditEvent_Index_patient;
            if (Index != null)
            {
              ResourseEntity.patient_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.Policy != null)
        {
          foreach (var item4 in item1.PolicyElement)
          {
            if (item4 is Hl7.Fhir.Model.FhirUri)
            {
              var Index = new Res_AuditEvent_Index_policy();
              Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(item4, Index) as Res_AuditEvent_Index_policy;
              ResourseEntity.policy_List.Add(Index);
            }
          }
        }
      }

      foreach (var item1 in ResourceTyped.Entity)
      {
        if (item1.Role != null)
        {
          if (item1.Role is Hl7.Fhir.Model.Coding)
          {
            var Index = new Res_AuditEvent_Index_role();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item1.Role, Index) as Res_AuditEvent_Index_role;
            ResourseEntity.role_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Subtype != null)
      {
        foreach (var item3 in ResourceTyped.Subtype)
        {
          if (item3 is Hl7.Fhir.Model.Coding)
          {
            var Index = new Res_AuditEvent_Index_subtype();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item3, Index) as Res_AuditEvent_Index_subtype;
            ResourseEntity.subtype_List.Add(Index);
          }
        }
      }

      foreach (var item1 in ResourceTyped.Agent)
      {
        if (item1.UserId != null)
        {
          if (item1.UserId is Hl7.Fhir.Model.Identifier)
          {
            var Index = new Res_AuditEvent_Index_user();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item1.UserId, Index) as Res_AuditEvent_Index_user;
            ResourseEntity.user_List.Add(Index);
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
              var Index = new Res_AuditEvent_Index__profile();
              Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(item4, Index) as Res_AuditEvent_Index__profile;
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
              var Index = new Res_AuditEvent_Index__security();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_AuditEvent_Index__security;
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
              var Index = new Res_AuditEvent_Index__tag();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_AuditEvent_Index__tag;
              ResourseEntity._tag_List.Add(Index);
            }
          }
        }
      }


      
    }

  }
} 

