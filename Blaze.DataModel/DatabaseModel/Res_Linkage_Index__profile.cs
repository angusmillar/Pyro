﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_Linkage_Index__profile : UriIndex
  {
    public int Res_Linkage_Index__profileID {get; set;}
    public virtual Res_Linkage Res_Linkage { get; set; }
   
    public Res_Linkage_Index__profile()
    {
    }
  }
}
