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
  public class Res_Conformance_Index_supported_profile_Configuration : EntityTypeConfiguration<Res_Conformance_Index_supported_profile>
  {

    public Res_Conformance_Index_supported_profile_Configuration()
    {
      HasKey(x => x.Res_Conformance_Index_supported_profileID).Property(x => x.Res_Conformance_Index_supported_profileID).IsRequired();
      Property(x => x.VersionId).IsOptional();
      Property(x => x.FhirId).IsRequired();
      Property(x => x.Type).IsRequired();
      HasRequired(x => x.Url);
      HasRequired<ServiceRootURL_Store>(x => x.Url).WithMany().HasForeignKey(x => x.ServiceRootURL_StoreID);
      HasRequired(x => x.Res_Conformance).WithMany(x => x.supported_profile_List).WillCascadeOnDelete(true);
    }
  }
}
