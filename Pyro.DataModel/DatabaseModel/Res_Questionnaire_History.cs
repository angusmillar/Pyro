﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Questionnaire_History : ResourceIndexBase
  {
    public int Res_Questionnaire_HistoryID {get; set;}
    public virtual Res_Questionnaire Res_Questionnaire { get; set; }
   
    public Res_Questionnaire_History()
    {
    }
  }
}
