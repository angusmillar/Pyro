﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Practitioner_Index_address_postalcode : StringIndex
  {
    public int Res_Practitioner_Index_address_postalcodeID {get; set;}
    public virtual Res_Practitioner Res_Practitioner { get; set; }
   
    public Res_Practitioner_Index_address_postalcode()
    {
    }
  }
}

