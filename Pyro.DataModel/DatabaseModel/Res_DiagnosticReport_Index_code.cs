﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_DiagnosticReport_Index_code : TokenIndex
  {
    public int Res_DiagnosticReport_Index_codeID {get; set;}
    public virtual Res_DiagnosticReport Res_DiagnosticReport { get; set; }
   
    public Res_DiagnosticReport_Index_code()
    {
    }
  }
}

