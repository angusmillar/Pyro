﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.Common.Interfaces;
using Hl7.Fhir.Model;
using System.Net;

namespace Pyro.Common.BusinessEntities.Search.Validation
{
  public class SearchPlanValidationOperationOutcome : ISearchPlanValidationOperationOutcome
  {
    public OperationOutcome FhirOperationOutcome { get; set; }
    public HttpStatusCode HttpStatusCode { get; set; }
  }
}
