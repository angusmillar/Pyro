﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Condition_Index_code : TokenIndex
  {
    public int Res_Condition_Index_codeID {get; set;}
    public virtual Res_Condition Res_Condition { get; set; }
   
    public Res_Condition_Index_code()
    {
    }
  }
}

