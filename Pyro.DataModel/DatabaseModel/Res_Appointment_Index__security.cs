﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Appointment_Index__security : TokenIndex
  {
    public int Res_Appointment_Index__securityID {get; set;}
    public virtual Res_Appointment Res_Appointment { get; set; }
   
    public Res_Appointment_Index__security()
    {
    }
  }
}

