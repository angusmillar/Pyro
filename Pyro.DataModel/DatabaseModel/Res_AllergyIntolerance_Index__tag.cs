﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_AllergyIntolerance_Index__tag : TokenIndex
  {
    public int Res_AllergyIntolerance_Index__tagID {get; set;}
    public virtual Res_AllergyIntolerance Res_AllergyIntolerance { get; set; }
   
    public Res_AllergyIntolerance_Index__tag()
    {
    }
  }
}

