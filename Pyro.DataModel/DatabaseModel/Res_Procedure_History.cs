﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Procedure_History : ResourceIndexBase
  {
    public int Res_Procedure_HistoryID {get; set;}
    public virtual Res_Procedure Res_Procedure { get; set; }
   
    public Res_Procedure_History()
    {
    }
  }
}
