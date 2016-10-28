﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyro.CodeGenerationSupport.FhirApiIntrospection
{
  public class FhirSearchParameterSearchPathElement
  {
    public Type DataType { get; set; }
    public Type ChoiceDataType { get; set; }
    public string PropertyName { get; set; }
    public bool IsCollection { get; set; }
    public FhirXPathComponent XPathComponent { get; set; }
  }
}
 