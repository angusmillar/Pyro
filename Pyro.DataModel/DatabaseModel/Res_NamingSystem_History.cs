﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_NamingSystem_History : ResourceIndexBase
  {
    public int Res_NamingSystem_HistoryID {get; set;}
    public virtual Res_NamingSystem Res_NamingSystem { get; set; }
   
    public Res_NamingSystem_History()
    {
    }
  }
}

