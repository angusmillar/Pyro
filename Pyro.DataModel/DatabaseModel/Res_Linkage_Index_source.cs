﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Linkage_Index_source : ReferenceIndex
  {
    public int Res_Linkage_Index_sourceID {get; set;}
    public virtual Res_Linkage Res_Linkage { get; set; }
   
    public Res_Linkage_Index_source()
    {
    }
  }
}

