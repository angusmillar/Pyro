﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Conformance_Index_securityservice : TokenIndex
  {
    public int Res_Conformance_Index_securityserviceID {get; set;}
    public virtual Res_Conformance Res_Conformance { get; set; }
   
    public Res_Conformance_Index_securityservice()
    {
    }
  }
}

