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
  public class Res_Person_Index_telecom_Configuration : EntityTypeConfiguration<Res_Person_Index_telecom>
  {

    public Res_Person_Index_telecom_Configuration()
    {
      HasKey(x => x.Res_Person_Index_telecomID).Property(x => x.Res_Person_Index_telecomID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_Person).WithMany(x => x.telecom_List).WillCascadeOnDelete(true);
    }
  }
}
