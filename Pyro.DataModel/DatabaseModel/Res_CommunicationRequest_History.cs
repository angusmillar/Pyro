﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_CommunicationRequest_History : ResourceIndexBase
  {
    public int Res_CommunicationRequest_HistoryID {get; set;}
    public virtual Res_CommunicationRequest Res_CommunicationRequest { get; set; }
   
    public Res_CommunicationRequest_History()
    {
    }
  }
}
