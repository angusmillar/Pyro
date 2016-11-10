﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyro.Common.BusinessEntities.Search
{
  public class DtoSearchParameterGeneric
  {
    public IList<Tuple<string, string>> ParameterList { get; set; }
    public IList<Tuple<string, Hl7.Fhir.Rest.SortOrder>> Sort { get; }
    public int? Count { get; private set; }

    public DtoSearchParameterGeneric() { }
    public DtoSearchParameterGeneric(Hl7.Fhir.Rest.SearchParams SearchParams)
    {
      this.ParameterList = SearchParams.Parameters;
      this.Sort = SearchParams.Sort;
      this.Count = SearchParams.Count;

    }
  }
}
