﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Task_History : ResourceIndexBase
  {
    public int Res_Task_HistoryID {get; set;}
    public virtual Res_Task Res_Task { get; set; }
   
    public Res_Task_History()
    {
    }
  }
}

