﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_PlanDefinition_Index_topic : TokenIndex
  {
    public int Res_PlanDefinition_Index_topicID {get; set;}
    public virtual Res_PlanDefinition Res_PlanDefinition { get; set; }
   
    public Res_PlanDefinition_Index_topic()
    {
    }
  }
}
