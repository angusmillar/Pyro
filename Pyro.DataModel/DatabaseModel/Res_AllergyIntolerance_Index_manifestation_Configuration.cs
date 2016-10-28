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
  public class Res_AllergyIntolerance_Index_manifestation_Configuration : EntityTypeConfiguration<Res_AllergyIntolerance_Index_manifestation>
  {

    public Res_AllergyIntolerance_Index_manifestation_Configuration()
    {
      HasKey(x => x.Res_AllergyIntolerance_Index_manifestationID).Property(x => x.Res_AllergyIntolerance_Index_manifestationID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_AllergyIntolerance).WithMany(x => x.manifestation_List).WillCascadeOnDelete(true);
    }
  }
}
