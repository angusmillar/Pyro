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
  public class Res_RiskAssessment_Index_method_Configuration : EntityTypeConfiguration<Res_RiskAssessment_Index_method>
  {

    public Res_RiskAssessment_Index_method_Configuration()
    {
      HasKey(x => x.Res_RiskAssessment_Index_methodID).Property(x => x.Res_RiskAssessment_Index_methodID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_RiskAssessment).WithMany(x => x.method_List).WillCascadeOnDelete(true);
    }
  }
}
