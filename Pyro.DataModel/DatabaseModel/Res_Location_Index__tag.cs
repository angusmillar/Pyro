﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Location_Index__tag : TokenIndex
  {
    public int Res_Location_Index__tagID {get; set;}
    public virtual Res_Location Res_Location { get; set; }
   
    public Res_Location_Index__tag()
    {
    }
  }
}

