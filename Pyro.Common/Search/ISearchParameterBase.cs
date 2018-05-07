﻿using Hl7.Fhir.Model;
using Pyro.Common.BusinessEntities.Dto;
using Pyro.Common.Interfaces.Dto;
using Pyro.Common.Interfaces.Service;
using Pyro.Common.Interfaces.Clone;
using System.Collections.Generic;

namespace Pyro.Common.Search
{
  public interface ISearchParameterBase : IServiceSearchParameterLight, ICloneDeep
  {
    List<ISearchParameterBase> ChainedSearchParameterList { get; set; }
    bool HasLogicalOrProperties { get; set; }
    string InvalidMessage { get; set; }
    bool IsValid { get; set; }
    SearchParameter.SearchModifierCode? Modifier { get; set; }
    IDtoRootUrlStore PrimaryRootUrlStore { get; set; }
    string RawValue { get; set; }
    string TypeModifierResource { get; set; }

    bool TryParseValue(string Value);
    bool ValidatePrefixes(DtoServiceSearchParameterLight DtoSupportedSearchParameters);
  }
}