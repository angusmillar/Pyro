﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyro.Common.BackgroundTask.Task
{
  public class TaskPayloadPyroServerIndexing : BackgroundTaskPayloadBase, ITaskPayloadPyroServerIndexing
  {
    public TaskPayloadPyroServerIndexing() 
      : base(BackgroundTaskType.PyroServerIndexing){ }    
  }
}
