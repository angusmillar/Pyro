﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_StructureDefinition_Index__security : TokenIndex
  {
    public int Res_StructureDefinition_Index__securityID {get; set;}
    public virtual Res_StructureDefinition Res_StructureDefinition { get; set; }
   
    public Res_StructureDefinition_Index__security()
    {
    }
  }
}
