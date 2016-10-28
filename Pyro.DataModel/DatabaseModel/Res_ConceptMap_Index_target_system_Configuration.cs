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
  public class Res_ConceptMap_Index_target_system_Configuration : EntityTypeConfiguration<Res_ConceptMap_Index_target_system>
  {

    public Res_ConceptMap_Index_target_system_Configuration()
    {
      HasKey(x => x.Res_ConceptMap_Index_target_systemID).Property(x => x.Res_ConceptMap_Index_target_systemID).IsRequired();
      Property(x => x.Uri).IsRequired();
      HasRequired(x => x.Res_ConceptMap).WithMany(x => x.target_system_List).WillCascadeOnDelete(true);
    }
  }
}
