﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_ConceptMap_Index_source_code : TokenIndex
  {
    public int Res_ConceptMap_Index_source_codeID {get; set;}
    public virtual Res_ConceptMap Res_ConceptMap { get; set; }
   
    public Res_ConceptMap_Index_source_code()
    {
    }
  }
}
