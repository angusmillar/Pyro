﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_RelatedPerson_Index_address_use : TokenIndex
  {
    public int Res_RelatedPerson_Index_address_useID {get; set;}
    public virtual Res_RelatedPerson Res_RelatedPerson { get; set; }
   
    public Res_RelatedPerson_Index_address_use()
    {
    }
  }
}

