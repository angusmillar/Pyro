﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_PaymentNotice_History : ResourceIndexBase
  {
    public int Res_PaymentNotice_HistoryID {get; set;}
    public virtual Res_PaymentNotice Res_PaymentNotice { get; set; }
   
    public Res_PaymentNotice_History()
    {
    }
  }
}

