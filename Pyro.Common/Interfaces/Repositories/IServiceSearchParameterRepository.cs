﻿using System.Collections.Generic;
using Pyro.Common.Search;

namespace Pyro.Common.Interfaces.Repositories
{
  public interface IServiceSearchParameterRepository
  {
    DtoServiceSearchParameterHeavy AddServiceSearchParametersHeavy(DtoServiceSearchParameterHeavy ServiceSearchParameterHeavy);
    void DeleteServiceSearchParameters(int Id);
    List<DtoServiceSearchParameterHeavy> GetServiceSearchParametersHeavy();
    List<DtoServiceSearchParameterHeavy> GetServiceSearchParametersHeavyByIsIndexed(bool IsIndexed);
    List<DtoServiceSearchParameterHeavy> GetServiceSearchParametersHeavyForResource(string ResourceType);
    List<DtoServiceSearchParameterLight> GetServiceSearchParametersLightForResource(string ResourceType);
    DtoServiceSearchParameterHeavy UpdateServiceSearchParametersHeavy(DtoServiceSearchParameterHeavy ServiceSearchParameterHeavy);
  }
}