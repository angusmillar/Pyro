﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_AuditEvent_Index_altid : TokenIndex
  {
    public int Res_AuditEvent_Index_altidID {get; set;}
    public virtual Res_AuditEvent Res_AuditEvent { get; set; }
   
    public Res_AuditEvent_Index_altid()
    {
    }
  }
}

