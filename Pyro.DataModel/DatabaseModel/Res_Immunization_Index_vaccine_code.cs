﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Immunization_Index_vaccine_code : TokenIndex
  {
    public int Res_Immunization_Index_vaccine_codeID {get; set;}
    public virtual Res_Immunization Res_Immunization { get; set; }
   
    public Res_Immunization_Index_vaccine_code()
    {
    }
  }
}

