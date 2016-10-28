﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace Pyro.DataModel.DatabaseModel.Base
{
  public class NumberIndex : ModelBase
  {
    public Quantity.QuantityComparator? Comparator { get; set; }
    public decimal Quantity { get; set; }
  }
}
