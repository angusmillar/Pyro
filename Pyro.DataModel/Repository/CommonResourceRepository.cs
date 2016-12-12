﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;
using Pyro.DataModel.DatabaseModel;
using Pyro.DataModel.DatabaseModel.Base;
using Pyro.DataModel.Support;
using Pyro.DataModel.IndexSetter;
using Pyro.Common.BusinessEntities.Search;
using Pyro.Common.Interfaces.Service;
using Pyro.Common.Interfaces.Repositories;
using Pyro.Common.Interfaces.UriSupport;
using Pyro.Common.BusinessEntities.Dto;
using Pyro.DataModel.Search;
using Hl7.Fhir.Model;
using Hl7.Fhir.Introspection;

namespace Pyro.DataModel.Repository
{
  public abstract class CommonResourceRepository<ResourceType, ResourceHistoryType> : CommonRepository, IResourceRepository
    where ResourceType : ResourceIndexBase, new()
    where ResourceHistoryType : ResourceIndexBase, new()
  {
    public FHIRAllTypes RepositoryResourceType { get; set; }

    public CommonResourceRepository(DataModel.DatabaseModel.DatabaseContext Context) : base(Context) { }

    public IDatabaseOperationOutcome GetResourceBySearch(DtoSearchParameters DtoSearchParameters, bool WithXml = false)
    {
      var Predicate = PredicateGenerator<ResourceType>(DtoSearchParameters);
      int TotalRecordCount = DbGetALLCount<ResourceType>(Predicate);
      var Query = DbGetAll<ResourceType>(Predicate);

      //Todo: Sort not implemented just defaulting to last update order
      Query = Query.OrderBy(x => x.lastUpdated);
      int ClaculatedPageRequired = Common.Tools.PagingSupport.CalculatePageRequired(DtoSearchParameters.RequiredPageNumber, _NumberOfRecordsPerPage, TotalRecordCount);

      Query = Query.Paging(ClaculatedPageRequired, _NumberOfRecordsPerPage);
      var DtoResourceList = new List<DtoResource>();
      if (WithXml)
      {
        DtoResourceList = Query.Select(x => new DtoResource
        {
          FhirId = x.FhirId,
          IsDeleted = x.IsDeleted,
          IsCurrent = true,
          Version = x.versionId,
          Received = x.lastUpdated,
          Method = x.Method,
          ResourceType = this.RepositoryResourceType,
          Xml = x.XmlBlob
        }).ToList();
      }
      else
      {
        DtoResourceList = Query.Select(x => new DtoResource
        {
          FhirId = x.FhirId,
          IsDeleted = x.IsDeleted,
          IsCurrent = true,
          Version = x.versionId,
          Received = x.lastUpdated,
          Method = x.Method,
          ResourceType = this.RepositoryResourceType
        }).ToList();
      }      

      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = false;
      DatabaseOperationOutcome.SearchTotal = TotalRecordCount;
      DatabaseOperationOutcome.PagesTotal = Common.Tools.PagingSupport.CalculateTotalPages(_NumberOfRecordsPerPage, TotalRecordCount); ;
      DatabaseOperationOutcome.PageRequested = ClaculatedPageRequired;
      DatabaseOperationOutcome.ReturnedResourceList = DtoResourceList;
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome GetResourceByFhirID(string FhirResourceId, bool WithXml = false)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      Pyro.Common.BusinessEntities.Dto.DtoResource DtoResource = null;
      if (WithXml)
      {
        DtoResource = DbGetAll<ResourceType>(x => x.FhirId == FhirResourceId)
          .Select(x => new Pyro.Common.BusinessEntities.Dto.DtoResource
          {
            FhirId = x.FhirId,
            IsDeleted = x.IsDeleted,
            IsCurrent = true,
            Version = x.versionId,
            Received = x.lastUpdated,
            Method = x.Method,
            ResourceType = this.RepositoryResourceType,
            Xml = x.XmlBlob
          }).SingleOrDefault();
      }
      else
      {
        DtoResource = DbGetAll<ResourceType>(x => x.FhirId == FhirResourceId)
          .Select(x => new Pyro.Common.BusinessEntities.Dto.DtoResource
          {
            FhirId = x.FhirId,
            IsDeleted = x.IsDeleted,
            IsCurrent = true,
            Version = x.versionId,
            Received = x.lastUpdated,
            Method = x.Method,
            ResourceType = this.RepositoryResourceType
          }).SingleOrDefault();
      }
      if (DtoResource != null)
        DatabaseOperationOutcome.ReturnedResourceList.Add(DtoResource);
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome GetResourceByFhirIDAndVersionNumber(string FhirResourceId, string ResourceVersionNumber)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();

      if (!string.IsNullOrWhiteSpace(ResourceVersionNumber))
      {
        DatabaseOperationOutcome.SingleResourceRead = true;
        var ResourceHistoryEntity = DbGet<ResourceHistoryType>(x => x.FhirId == FhirResourceId && x.versionId == ResourceVersionNumber);
        if (ResourceHistoryEntity != null)
        {
          DatabaseOperationOutcome.ReturnedResourceList.Add(IndexSettingSupport.SetDtoResource(ResourceHistoryEntity, this.RepositoryResourceType, false));
        }
        else
        {
          var ResourceEntity = DbGet<ResourceType>(x => x.FhirId == FhirResourceId && x.versionId == ResourceVersionNumber);
          if (ResourceEntity != null)
            DatabaseOperationOutcome.ReturnedResourceList.Add(IndexSettingSupport.SetDtoResource(ResourceEntity, this.RepositoryResourceType, true));
        }
      }
      else
      {

        DatabaseOperationOutcome.SingleResourceRead = false;
        var Predicate = LinqKit.PredicateBuilder.New<ResourceHistoryType>(true);
        Predicate = Predicate.And(x => x.FhirId == FhirResourceId);
        int TotalRecordCount = DbGetALLCount<ResourceHistoryType>(Predicate);
        var Query = DbGetAll<ResourceHistoryType>(Predicate);

        //Todo: Sort not implemented just defaulting to last update order
        //Query = Query.OrderBy(x => x.lastUpdated);
        //int ClaculatedPageRequired = PaginationSupport.CalculatePageRequired(DtoSearchParameters.RequiredPageNumber, _NumberOfRecordsPerPage, TotalRecordCount);

        //Query = Query.Paging(ClaculatedPageRequired, _NumberOfRecordsPerPage);
        var DtoResourceList = new List<Common.BusinessEntities.Dto.DtoResource>();
        Query.ToList().ForEach(x => DtoResourceList.Add(IndexSettingSupport.SetDtoResource(x, this.RepositoryResourceType, true)));

      }
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome GetResourceHistoryByFhirID(string FhirResourceId, DtoSearchParameters DtoSearchParameters)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = false;
      int TotalRecordCount = 0;

      if (DtoSearchParameters.CountOfRecordsRequested.HasValue)
      {
        if (DtoSearchParameters.CountOfRecordsRequested.Value < _MaxNumberOfRecordsPerPage)
        {
          _NumberOfRecordsPerPage = DtoSearchParameters.CountOfRecordsRequested.Value;
        }
        else
        {
          _NumberOfRecordsPerPage = _MaxNumberOfRecordsPerPage;
        }
      }



      var DtoResourceList = new List<DtoResource>();

      var Predicate = LinqKit.PredicateBuilder.New<ResourceType>(true);
      Predicate = Predicate.And(x => x.FhirId == FhirResourceId);
      ResourceType CurrentResourceEntity = DbGet<ResourceType>(Predicate);

      if (CurrentResourceEntity != null)
      {
        TotalRecordCount++;
        //If page one required then add the current record to the return list as first.
        if (DtoSearchParameters.RequiredPageNumber <= 1)
        {
          _NumberOfRecordsPerPage--;
          DtoResourceList.Add(IndexSettingSupport.SetDtoResource(CurrentResourceEntity, RepositoryResourceType, true));
        }
      }

      TotalRecordCount = TotalRecordCount + GetResourceHistoryEntityCount(Predicate);



      int StartRecord = 0;
      int PagesTotal = Common.Tools.PagingSupport.CalculateTotalPages(_NumberOfRecordsPerPage, TotalRecordCount);
      if (DtoSearchParameters.RequiredPageNumber > PagesTotal)
        StartRecord = (_NumberOfRecordsPerPage * (PagesTotal - 1)) - 1;
      else if (DtoSearchParameters.RequiredPageNumber > 1)
        StartRecord = (_NumberOfRecordsPerPage * (DtoSearchParameters.RequiredPageNumber - 1)) - 1;

      GetResourceHistoryEntityList(Predicate, StartRecord, DtoResourceList);

      DatabaseOperationOutcome.SingleResourceRead = false;
      DatabaseOperationOutcome.SearchTotal = TotalRecordCount;
      DatabaseOperationOutcome.PagesTotal = Common.Tools.PagingSupport.CalculateTotalPages(_NumberOfRecordsPerPage, TotalRecordCount);
      DatabaseOperationOutcome.PageRequested = Common.Tools.PagingSupport.CalculatePageRequired(DtoSearchParameters.RequiredPageNumber, _NumberOfRecordsPerPage, TotalRecordCount);
      DatabaseOperationOutcome.ReturnedResourceList = DtoResourceList;
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome AddResource(Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceEntity = new ResourceType();
      IndexSettingSupport.SetResourceBaseAddOrUpdate(Resource, ResourceEntity, Common.Tools.ResourceVersionNumber.FirstVersion(), false, Bundle.HTTPVerb.POST);
      var test = this.RepositoryResourceType;
      this.PopulateResourceEntity(ResourceEntity, Common.Tools.ResourceVersionNumber.FirstVersion(), Resource, FhirRequestUri);
      this.DbAddEntity<ResourceType>(ResourceEntity);
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      DatabaseOperationOutcome.ReturnedResourceList.Add(IndexSettingSupport.SetDtoResource(ResourceEntity, this.RepositoryResourceType, true));
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome UpdateResource(string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri)
    {
      var ResourceHistoryEntity = new ResourceHistoryType();
      var ResourceEntity = LoadCurrentResourceEntity(Resource.Id);
      IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
      this.AddResourceHistoryEntityToResourceEntity(ResourceEntity, ResourceHistoryEntity);
      IndexSettingSupport.ResetResourceEntityBase(ResourceEntity);
      this.ResetResourceEntity(ResourceEntity);
      IndexSettingSupport.SetResourceBaseAddOrUpdate(Resource, ResourceEntity, ResourceVersion, false, Bundle.HTTPVerb.PUT);
      this.PopulateResourceEntity(ResourceEntity, ResourceVersion, Resource, FhirRequestUri);
      this.Save();
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      DatabaseOperationOutcome.SingleResourceRead = true;
      DatabaseOperationOutcome.ReturnedResourceList.Add(IndexSettingSupport.SetDtoResource(ResourceEntity, this.RepositoryResourceType, true));
      return DatabaseOperationOutcome;
    }
    
    public IDatabaseOperationOutcome UpdateResouceIdAsDeleted(string FhirResourceId)
    {
      var ResourceHistoryEntity = new ResourceHistoryType();
      var ResourceEntity = this.LoadCurrentResourceEntity(FhirResourceId);
      string NewDeletedResourceVersion = Common.Tools.ResourceVersionNumber.Increment(ResourceEntity.versionId);
      IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
      this.AddResourceHistoryEntityToResourceEntity(ResourceEntity, ResourceHistoryEntity);
      IndexSettingSupport.ResetResourceEntityBase(ResourceEntity);
      this.ResetResourceEntity(ResourceEntity);
      ResourceEntity.FhirId = FhirResourceId;
      ResourceEntity.IsDeleted = true;
      ResourceEntity.versionId = NewDeletedResourceVersion;
      ResourceEntity.XmlBlob = string.Empty;
      ResourceEntity.lastUpdated = DateTimeOffset.Now;
      ResourceEntity.Method = Bundle.HTTPVerb.DELETE;
      this.Save();
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      DatabaseOperationOutcome.ReturnedResourceList.Add(IndexSettingSupport.SetDtoResource(ResourceEntity, this.RepositoryResourceType, true));
      return DatabaseOperationOutcome;
    }

    public IDatabaseOperationOutcome UpdateResouceIdColectionAsDeleted(ICollection<string> ResourceIdCollection)
    {
      IDatabaseOperationOutcome DatabaseOperationOutcome = Common.CommonFactory.GetDatabaseOperationOutcome();
      foreach (string ResourceId in ResourceIdCollection)
      {
        var ResourceHistoryEntity = new ResourceHistoryType();
        var ResourceEntity = this.LoadCurrentResourceEntity(ResourceId);
        string NewDeletedResourceVersion = Common.Tools.ResourceVersionNumber.Increment(ResourceEntity.versionId);
        IndexSettingSupport.SetHistoryResourceEntity(ResourceEntity, ResourceHistoryEntity);
        this.AddResourceHistoryEntityToResourceEntity(ResourceEntity, ResourceHistoryEntity);
        IndexSettingSupport.ResetResourceEntityBase(ResourceEntity);
        this.ResetResourceEntity(ResourceEntity);
        ResourceEntity.FhirId = ResourceId;
        ResourceEntity.IsDeleted = true;
        ResourceEntity.versionId = NewDeletedResourceVersion;
        ResourceEntity.XmlBlob = string.Empty;
        ResourceEntity.lastUpdated = DateTimeOffset.Now;
        ResourceEntity.Method = Bundle.HTTPVerb.DELETE;
        DatabaseOperationOutcome.ReturnedResourceList.Add(IndexSettingSupport.SetDtoResource(ResourceEntity, this.RepositoryResourceType, true));
      }
      this.Save();
      return DatabaseOperationOutcome;
    }
    
    // --- Abstract Methods -------------------------------------------------------------
    protected abstract void GetResourceHistoryEntityList(LinqKit.ExpressionStarter<ResourceType> Predicate, int StartRecord, List<DtoResource> DtoResourceList);

    protected abstract int GetResourceHistoryEntityCount(LinqKit.ExpressionStarter<ResourceType> Predicate);

    protected abstract void AddResourceHistoryEntityToResourceEntity(ResourceType ResourceEntity, ResourceHistoryType ResourceHistoryEntity);

    protected abstract void ResetResourceEntity(ResourceType resourceEntity);

    protected abstract ResourceType LoadCurrentResourceEntity(string fhirResourceId);

    protected abstract void PopulateResourceEntity(ResourceType ResourceEntity, string ResourceVersion, Resource Resource, IDtoFhirRequestUri FhirRequestUri);
  }
}
