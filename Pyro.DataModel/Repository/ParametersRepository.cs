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
  public partial class ParametersRepository<ResourceType, ResourceHistoryType> : CommonResourceRepository<ResourceType, ResourceHistoryType>, IResourceRepository 
    where ResourceType : Res_Parameters, new() 
    where ResourceHistoryType :Res_Parameters_History, new()
  {
    public ParametersRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { this.RepositoryResourceType = FHIRAllTypes.Parameters; }

    protected override void GetResourceHistoryEntityList(LinqKit.ExpressionStarter<ResourceType> Predicate, int StartRecord, List<DtoResource> DtoResourceList)
    {
      var HistoryEntityList = DbGetAll<ResourceType>(Predicate).SelectMany(y => y.Res_Parameters_History_List)
        .OrderByDescending(x => x.lastUpdated)
        .Skip(StartRecord)
        .Take(_NumberOfRecordsPerPage)
        .ToList();

      if (HistoryEntityList != null)
        HistoryEntityList.ForEach(x => DtoResourceList.Add(IndexSettingSupport.SetDtoResource(x, this.RepositoryResourceType, false)));
    }

    protected override int GetResourceHistoryEntityCount(LinqKit.ExpressionStarter<ResourceType> Predicate)
    {
      return DbGetAll<ResourceType>(Predicate).SelectMany(y => y.Res_Parameters_History_List).Count();      
    }

    protected override void AddResourceHistoryEntityToResourceEntity(ResourceType ResourceEntity, ResourceHistoryType ResourceHistoryEntity)
    {
      ResourceEntity.Res_Parameters_History_List.Add(ResourceHistoryEntity);
    }
    
    protected override ResourceType LoadCurrentResourceEntity(string FhirId)
    {
      var IncludeList = new List<Expression<Func<ResourceType, object>>>();
         IncludeList.Add(x => x._profile_List);
      IncludeList.Add(x => x._security_List);
      IncludeList.Add(x => x._tag_List);
    
      var ResourceEntity = DbQueryEntityWithInclude<ResourceType>(x => x.FhirId == FhirId, IncludeList);
      return ResourceEntity;
    }
    
    protected override void ResetResourceEntity(ResourceType ResourceEntity)
    {
 
      
      _Context.Res_Parameters_Index__profile.RemoveRange(ResourceEntity._profile_List);            
      _Context.Res_Parameters_Index__security.RemoveRange(ResourceEntity._security_List);            
      _Context.Res_Parameters_Index__tag.RemoveRange(ResourceEntity._tag_List);            
 
    }

    protected override void PopulateResourceEntity(ResourceType ResourceEntity, string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceTyped = Resource as Parameters;
      var ResourseEntity = ResourceEntity as ResourceType;

          if (ResourceTyped.Meta != null)
      {
        if (ResourceTyped.Meta.Profile != null)
        {
          foreach (var item4 in ResourceTyped.Meta.ProfileElement)
          {
            if (item4 is Hl7.Fhir.Model.FhirUri)
            {
              var Index = new Res_Parameters_Index__profile();
              Index = IndexSetterFactory.Create(typeof(UriIndex)).Set(item4, Index) as Res_Parameters_Index__profile;
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
              var Index = new Res_Parameters_Index__security();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_Parameters_Index__security;
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
              var Index = new Res_Parameters_Index__tag();
              Index = IndexSetterFactory.Create(typeof(TokenIndex)).Set(item4, Index) as Res_Parameters_Index__tag;
              ResourseEntity._tag_List.Add(Index);
            }
          }
        }
      }


      
    }

  }
} 

