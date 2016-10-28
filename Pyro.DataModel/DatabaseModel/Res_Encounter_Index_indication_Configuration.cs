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
  public class Res_Encounter_Index_indication_Configuration : EntityTypeConfiguration<Res_Encounter_Index_indication>
  {

    public Res_Encounter_Index_indication_Configuration()
    {
      HasKey(x => x.Res_Encounter_Index_indicationID).Property(x => x.Res_Encounter_Index_indicationID).IsRequired();
      Property(x => x.VersionId).IsOptional();
      Property(x => x.FhirId).IsRequired();
      Property(x => x.Type).IsRequired();
      HasRequired(x => x.Url);
      HasRequired<ServiceRootURL_Store>(x => x.Url).WithMany().HasForeignKey(x => x.ServiceRootURL_StoreID);
      HasRequired(x => x.Res_Encounter).WithMany(x => x.indication_List).WillCascadeOnDelete(true);
    }
  }
}
