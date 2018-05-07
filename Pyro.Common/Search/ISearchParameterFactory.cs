﻿using System;
using Pyro.Common.BusinessEntities.Dto;

namespace Pyro.Common.Search
{
  public interface ISearchParameterFactory
  {
    ISearchParameterBase CreateSearchParameter(DtoServiceSearchParameterLight DtoSupportedSearchParametersResource, Tuple<string, string> Parameterbool, bool IsChainedReferance = false);
  }
}