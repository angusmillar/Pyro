﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyro.Common.BusinessEntities.Search
{
  public class DtoSearchParameterReferanceValue : DtoSearchParameterValueBase
  {  
    public Pyro.Common.Interfaces.UriSupport.IFhirUri FhirUri { get; set; }
  }
}
