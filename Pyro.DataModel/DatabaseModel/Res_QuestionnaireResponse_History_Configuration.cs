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
  public class Res_QuestionnaireResponse_History_Configuration : EntityTypeConfiguration<Res_QuestionnaireResponse_History>
  {

    public Res_QuestionnaireResponse_History_Configuration()
    {
      HasKey(x => x.Res_QuestionnaireResponse_HistoryID).Property(x => x.Res_QuestionnaireResponse_HistoryID).IsRequired();
      Property(x => x.IsDeleted).IsRequired();
      Property(x => x.FhirId).IsRequired().HasMaxLength(500).HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("IX_FhirId") { IsUnique = false })); ;
      Property(x => x.lastUpdated).IsRequired();
      Property(x => x.versionId).IsRequired();
      Property(x => x.XmlBlob).IsRequired();
      HasRequired(x => x.Res_QuestionnaireResponse).WithMany(x => x.Res_QuestionnaireResponse_History_List).WillCascadeOnDelete(false);
    }
  }
}
