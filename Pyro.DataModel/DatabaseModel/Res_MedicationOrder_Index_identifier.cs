﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_MedicationOrder_Index_identifier : TokenIndex
  {
    public int Res_MedicationOrder_Index_identifierID {get; set;}
    public virtual Res_MedicationOrder Res_MedicationOrder { get; set; }
   
    public Res_MedicationOrder_Index_identifier()
    {
    }
  }
}

