﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_PractitionerRole_Index_location : ReferenceIndex
  {
    public int Res_PractitionerRole_Index_locationID {get; set;}
    public virtual Res_PractitionerRole Res_PractitionerRole { get; set; }
   
    public Res_PractitionerRole_Index_location()
    {
    }
  }
}

