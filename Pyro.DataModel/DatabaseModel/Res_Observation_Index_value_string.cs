﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Observation_Index_value_string : StringIndex
  {
    public int Res_Observation_Index_value_stringID {get; set;}
    public virtual Res_Observation Res_Observation { get; set; }
   
    public Res_Observation_Index_value_string()
    {
    }
  }
}

