﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This source file has been auto generated.

namespace Blaze.DataModel.BlazeDbModel
{

  public class Res_ImmunizationRecommendation_Index_dose_number
  {
    public int Id {get; set;}
    public decimal Number {get; set;}                  
    
    //Keyed
    public virtual Res_ImmunizationRecommendation Res_ImmunizationRecommendation { get; set; }                     
  }
}