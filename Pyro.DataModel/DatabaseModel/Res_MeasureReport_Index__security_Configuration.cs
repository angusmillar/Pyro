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
  public class Res_MeasureReport_Index__security_Configuration : EntityTypeConfiguration<Res_MeasureReport_Index__security>
  {

    public Res_MeasureReport_Index__security_Configuration()
    {
      HasKey(x => x.Res_MeasureReport_Index__securityID).Property(x => x.Res_MeasureReport_Index__securityID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_MeasureReport).WithMany(x => x._security_List).WillCascadeOnDelete(true);
    }
  }
}