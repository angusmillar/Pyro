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
//Generation time-stamp: : 11/11/2016 3:03:55 PM.

namespace Pyro.DataModel.Repository
{
  public partial class StructureDefinitionRepository<ResourceType, ResourceHistoryType> : CommonResourceRepository<ResourceType, ResourceHistoryType>, IResourceRepository 
    where ResourceType : Res_StructureDefinition, new() 
    where ResourceHistoryType :Res_StructureDefinition_History, new()
  {
    public StructureDefinitionRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { }

    protected override void GetResourceHistoryEntityList(LinqKit.ExpressionStarter<ResourceType> Predicate, int StartRecord, List<DtoResource> DtoResourceList)
    {
      var HistoryEntityList = DbGetAll<ResourceType>(Predicate).SelectMany(y => y.Res_StructureDefinition_History_List)
        .OrderByDescending(x => x.lastUpdated)
        .Skip(StartRecord)
        .Take(_NumberOfRecordsPerPage)
        .ToList();

      if (HistoryEntityList != null)
        HistoryEntityList.ForEach(x => DtoResourceList.Add(IndexSettingSupport.SetDtoResource(x, false)));      
    }

    protected override int GetResourceHistoryEntityCount(LinqKit.ExpressionStarter<ResourceType> Predicate)
    {
      return DbGetAll<ResourceType>(Predicate).SelectMany(y => y.Res_StructureDefinition_History_List).Count();      
    }

    protected override void AddResourceHistoryEntityToResourceEntity(ResourceType ResourceEntity, ResourceHistoryType ResourceHistoryEntity)
    {
      ResourceEntity.Res_StructureDefinition_History_List.Add(ResourceHistoryEntity);
    }
    
    protected override ResourceType LoadCurrentResourceEntity(string FhirId)
    {
      var IncludeList = new List<Expression<Func<ResourceType, object>>>();
         IncludeList.Add(x => x.base_path_List);
      IncludeList.Add(x => x.base_path_List);
      IncludeList.Add(x => x.code_List);
      IncludeList.Add(x => x.context_List);
      IncludeList.Add(x => x.ext_context_List);
      IncludeList.Add(x => x.identifier_List);
      IncludeList.Add(x => x.path_List);
      IncludeList.Add(x => x.path_List);
      IncludeList.Add(x => x.valueset_List);
      IncludeList.Add(x => x.valueset_List);
      IncludeList.Add(x => x._profile_List);
      IncludeList.Add(x => x._security_List);
      IncludeList.Add(x => x._tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<ResourceType>(x => x.FhirId == FhirId, IncludeList);
      return ResourceEntity;
    }
    
    protected override void ResetResourceEntity(ResourceType ResourceEntity)
    {
      ResourceEntity.abstract_Code = null;      
      ResourceEntity.abstract_System = null;      
      ResourceEntity.base_Uri = null;      
      ResourceEntity.context_type_Code = null;      
      ResourceEntity.context_type_System = null;      
      ResourceEntity.date_DateTimeOffset = null;      
      ResourceEntity.derivation_Code = null;      
      ResourceEntity.derivation_System = null;      
      ResourceEntity.description_String = null;      
      ResourceEntity.display_String = null;      
      ResourceEntity.experimental_Code = null;      
      ResourceEntity.experimental_System = null;      
      ResourceEntity.kind_Code = null;      
      ResourceEntity.kind_System = null;      
      ResourceEntity.name_String = null;      
      ResourceEntity.publisher_String = null;      
      ResourceEntity.status_Code = null;      
      ResourceEntity.status_System = null;      
      ResourceEntity.type_Code = null;      
      ResourceEntity.type_System = null;      
      ResourceEntity.url_Uri = null;      
      ResourceEntity.version_Code = null;      
      ResourceEntity.version_System = null;      
      ResourceEntity.XmlBlob = null;      
 
      
      _Context.Res_StructureDefinition_Index_base_path.RemoveRange(ResourceEntity.base_path_List);            
      _Context.Res_StructureDefinition_Index_base_path.RemoveRange(ResourceEntity.base_path_List);            
      _Context.Res_StructureDefinition_Index_code.RemoveRange(ResourceEntity.code_List);            
      _Context.Res_StructureDefinition_Index_context.RemoveRange(ResourceEntity.context_List);            
      _Context.Res_StructureDefinition_Index_ext_context.RemoveRange(ResourceEntity.ext_context_List);            
      _Context.Res_StructureDefinition_Index_identifier.RemoveRange(ResourceEntity.identifier_List);            
      _Context.Res_StructureDefinition_Index_path.RemoveRange(ResourceEntity.path_List);            
      _Context.Res_StructureDefinition_Index_path.RemoveRange(ResourceEntity.path_List);            
      _Context.Res_StructureDefinition_Index_valueset.RemoveRange(ResourceEntity.valueset_List);            
      _Context.Res_StructureDefinition_Index_valueset.RemoveRange(ResourceEntity.valueset_List);            
      _Context.Res_StructureDefinition_Index__profile.RemoveRange(ResourceEntity._profile_List);            
      _Context.Res_StructureDefinition_Index__security.RemoveRange(ResourceEntity._security_List);            
      _Context.Res_StructureDefinition_Index__tag.RemoveRange(ResourceEntity._tag_List);            
 
    }

    protected override void PopulateResourceEntity(ResourceType ResourceEntity, string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as StructureDefinition;
      var ResourseEntity = ResourceEntity as ResourceType;
      IndexSettingSupport.SetResourceBaseAddOrUpdate(ResourceTyped, ResourseEntity, ResourceVersion, false);

          if (ResourceTyped.Abstract != null)
      {
        if (ResourceTyped.AbstractElement is Hl7.Fhir.Model.FhirBoolean)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.AbstractElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.abstract_Code = Index.Code;
            ResourseEntity.abstract_System = Index.System;
          }
        }
      }

      if (ResourceTyped.BaseDefinition != null)
      {
        if (ResourceTyped.BaseDefinitionElement is Hl7.Fhir.Model.FhirUri)
        {
          var Index = new UriIndex();
          Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(ResourceTyped.BaseDefinitionElement, Index) as UriIndex;
          if (Index != null)
          {
            ResourseEntity.base_Uri = Index.Uri;
          }
        }
      }

      if (ResourceTyped.ContextType != null)
      {
        if (ResourceTyped.ContextTypeElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.ExtensionContext>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.ContextTypeElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.context_type_Code = Index.Code;
            ResourseEntity.context_type_System = Index.System;
          }
        }
      }

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

      if (ResourceTyped.Derivation != null)
      {
        if (ResourceTyped.DerivationElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.TypeDerivationRule>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.DerivationElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.derivation_Code = Index.Code;
            ResourseEntity.derivation_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Description != null)
      {
        if (ResourceTyped.Description is Hl7.Fhir.Model.Markdown)
        {
          var Index = new StringIndex();
          Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(ResourceTyped.Description, Index) as StringIndex;
          if (Index != null)
          {
            ResourseEntity.description_String = Index.String;
          }
        }
      }

      if (ResourceTyped.Display != null)
      {
        if (ResourceTyped.DisplayElement is Hl7.Fhir.Model.FhirString)
        {
          var Index = new StringIndex();
          Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(ResourceTyped.DisplayElement, Index) as StringIndex;
          if (Index != null)
          {
            ResourseEntity.display_String = Index.String;
          }
        }
      }

      if (ResourceTyped.Experimental != null)
      {
        if (ResourceTyped.ExperimentalElement is Hl7.Fhir.Model.FhirBoolean)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.ExperimentalElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.experimental_Code = Index.Code;
            ResourseEntity.experimental_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Kind != null)
      {
        if (ResourceTyped.KindElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.StructureDefinition.StructureDefinitionKind>)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.KindElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.kind_Code = Index.Code;
            ResourseEntity.kind_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Name != null)
      {
        if (ResourceTyped.NameElement is Hl7.Fhir.Model.FhirString)
        {
          var Index = new StringIndex();
          Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(ResourceTyped.NameElement, Index) as StringIndex;
          if (Index != null)
          {
            ResourseEntity.name_String = Index.String;
          }
        }
      }

      if (ResourceTyped.Publisher != null)
      {
        if (ResourceTyped.PublisherElement is Hl7.Fhir.Model.FhirString)
        {
          var Index = new StringIndex();
          Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(ResourceTyped.PublisherElement, Index) as StringIndex;
          if (Index != null)
          {
            ResourseEntity.publisher_String = Index.String;
          }
        }
      }

      if (ResourceTyped.Status != null)
      {
        if (ResourceTyped.StatusElement is Hl7.Fhir.Model.Code<Hl7.Fhir.Model.ConformanceResourceStatus>)
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

      if (ResourceTyped.Type != null)
      {
        if (ResourceTyped.TypeElement is Hl7.Fhir.Model.Code)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.TypeElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.type_Code = Index.Code;
            ResourseEntity.type_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Url != null)
      {
        if (ResourceTyped.UrlElement is Hl7.Fhir.Model.FhirUri)
        {
          var Index = new UriIndex();
          Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(ResourceTyped.UrlElement, Index) as UriIndex;
          if (Index != null)
          {
            ResourseEntity.url_Uri = Index.Uri;
          }
        }
      }

      if (ResourceTyped.Version != null)
      {
        if (ResourceTyped.VersionElement is Hl7.Fhir.Model.FhirString)
        {
          var Index = new TokenIndex();
          Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(ResourceTyped.VersionElement, Index) as TokenIndex;
          if (Index != null)
          {
            ResourseEntity.version_Code = Index.Code;
            ResourseEntity.version_System = Index.System;
          }
        }
      }

      if (ResourceTyped.Snapshot != null)
      {
        foreach (var item2 in ResourceTyped.Snapshot.Element)
        {
          if (item2.Base != null)
          {
            if (item2.Base.Path != null)
            {
              if (item2.Base.PathElement is Hl7.Fhir.Model.FhirString)
              {
                var Index = new Res_StructureDefinition_Index_base_path();
                Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item2.Base.PathElement, Index) as Res_StructureDefinition_Index_base_path;
                ResourseEntity.base_path_List.Add(Index);
              }
            }
          }
        }
      }

      if (ResourceTyped.Differential != null)
      {
        foreach (var item2 in ResourceTyped.Differential.Element)
        {
          if (item2.Base != null)
          {
            if (item2.Base.Path != null)
            {
              if (item2.Base.PathElement is Hl7.Fhir.Model.FhirString)
              {
                var Index = new Res_StructureDefinition_Index_base_path();
                Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item2.Base.PathElement, Index) as Res_StructureDefinition_Index_base_path;
                ResourseEntity.base_path_List.Add(Index);
              }
            }
          }
        }
      }

      if (ResourceTyped.Code != null)
      {
        foreach (var item3 in ResourceTyped.Code)
        {
          if (item3 is Hl7.Fhir.Model.Coding)
          {
            var Index = new Res_StructureDefinition_Index_code();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item3, Index) as Res_StructureDefinition_Index_code;
            ResourseEntity.code_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.UseContext != null)
      {
        foreach (var item3 in ResourceTyped.UseContext)
        {
          if (item3 != null)
          {
            foreach (var item4 in item3.Coding)
            {
              var Index = new Res_StructureDefinition_Index_context();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_StructureDefinition_Index_context;
              ResourseEntity.context_List.Add(Index);
            }
          }
        }
      }

      if (ResourceTyped.Context != null)
      {
        foreach (var item3 in ResourceTyped.ContextElement)
        {
          if (item3 is Hl7.Fhir.Model.FhirString)
          {
            var Index = new Res_StructureDefinition_Index_ext_context();
            Index = IndexSetterFactory.Create(typeof(StringIndex)).Set(item3, Index) as Res_StructureDefinition_Index_ext_context;
            ResourseEntity.ext_context_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Identifier != null)
      {
        foreach (var item3 in ResourceTyped.Identifier)
        {
          if (item3 is Hl7.Fhir.Model.Identifier)
          {
            var Index = new Res_StructureDefinition_Index_identifier();
            Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item3, Index) as Res_StructureDefinition_Index_identifier;
            ResourseEntity.identifier_List.Add(Index);
          }
        }
      }

      if (ResourceTyped.Snapshot != null)
      {
        foreach (var item2 in ResourceTyped.Snapshot.Element)
        {
          if (item2.Path != null)
          {
            if (item2.PathElement is Hl7.Fhir.Model.FhirString)
            {
              var Index = new Res_StructureDefinition_Index_path();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item2.PathElement, Index) as Res_StructureDefinition_Index_path;
              ResourseEntity.path_List.Add(Index);
            }
          }
        }
      }

      if (ResourceTyped.Differential != null)
      {
        foreach (var item2 in ResourceTyped.Differential.Element)
        {
          if (item2.Path != null)
          {
            if (item2.PathElement is Hl7.Fhir.Model.FhirString)
            {
              var Index = new Res_StructureDefinition_Index_path();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item2.PathElement, Index) as Res_StructureDefinition_Index_path;
              ResourseEntity.path_List.Add(Index);
            }
          }
        }
      }

      if (ResourceTyped.Snapshot != null)
      {
        foreach (var item2 in ResourceTyped.Snapshot.Element)
        {
          if (item2.Binding != null)
          {
            if (item2.Binding.ValueSet != null)
            {
              if (item2.Binding.ValueSet is Hl7.Fhir.Model.FhirUri)
              {
                var Index = new Res_StructureDefinition_Index_valueset();
                Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item2.Binding.ValueSet, Index) as Res_StructureDefinition_Index_valueset;
                ResourseEntity.valueset_List.Add(Index);
              }
            }
          }
        }
      }

      if (ResourceTyped.Snapshot != null)
      {
        foreach (var item2 in ResourceTyped.Snapshot.Element)
        {
          if (item2.Binding != null)
          {
            if (item2.Binding.ValueSet != null)
            {
              if (item2.Binding.ValueSet is ResourceReference)
              {
                var Index = new Res_StructureDefinition_Index_valueset();
                Index = IndexSetterFactory.Create(typeof(ReferenceIndex)).Set(item2.Binding.ValueSet, Index, FhirRequestUri, this) as Res_StructureDefinition_Index_valueset;
                if (Index != null)
                {
                  ResourseEntity.valueset_List.Add(Index);
                }
              }
            }
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
              var Index = new Res_StructureDefinition_Index__profile();
              Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(item4, Index) as Res_StructureDefinition_Index__profile;
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
              var Index = new Res_StructureDefinition_Index__security();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_StructureDefinition_Index__security;
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
              var Index = new Res_StructureDefinition_Index__tag();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_StructureDefinition_Index__tag;
              ResourseEntity._tag_List.Add(Index);
            }
          }
        }
      }


      
    }

  }
} 

