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
  public class Res_CommunicationRequest_Index_medium_Configuration : EntityTypeConfiguration<Res_CommunicationRequest_Index_medium>
  {

    public Res_CommunicationRequest_Index_medium_Configuration()
    {
      HasKey(x => x.Res_CommunicationRequest_Index_mediumID).Property(x => x.Res_CommunicationRequest_Index_mediumID).IsRequired();
      Property(x => x.Code).IsRequired();
      Property(x => x.System).IsOptional();
      HasRequired(x => x.Res_CommunicationRequest).WithMany(x => x.medium_List).WillCascadeOnDelete(true);
    }
  }
}
