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

namespace Pyro.DataModel.DatabaseModel
{
  public class Res_CareTeam_Index_status_Configuration : EntityTypeConfiguration<Res_CareTeam_Index_status>
  {

    public Res_CareTeam_Index_status_Configuration()
    {
      HasKey(x => x.Res_CareTeam_Index_statusID).Property(x => x.Res_CareTeam_Index_statusID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_CareTeam).WithMany(x => x.status_List).WillCascadeOnDelete(true);
    }
  }
}
