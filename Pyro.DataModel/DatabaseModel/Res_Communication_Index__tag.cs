﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Communication_Index__tag : TokenIndex
  {
    public int Res_Communication_Index__tagID {get; set;}
    public virtual Res_Communication Res_Communication { get; set; }
   
    public Res_Communication_Index__tag()
    {
    }
  }
}

