﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Infrastructure.Annotations;

//This is an Auto generated file do not change it's contents!!.

namespace Blaze.DataModel.DatabaseModel
{
  public class Res_AuditEvent_Index_agent_name_Configuration : EntityTypeConfiguration<Res_AuditEvent_Index_agent_name>
  {

    public Res_AuditEvent_Index_agent_name_Configuration()
    {
      HasKey(x => x.Res_AuditEvent_Index_agent_nameID).Property(x => x.Res_AuditEvent_Index_agent_nameID).IsRequired();
      Property(x => x.String).IsRequired();
      HasRequired(x => x.Res_AuditEvent).WithMany(x => x.agent_name_List).WillCascadeOnDelete(true);
    }
  }
}