﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_GuidanceResponse : ResourceIndexBase
  {
    public int Res_GuidanceResponseID {get; set;}
    public string patient_VersionId {get; set;}
    public string patient_FhirId {get; set;}
    public string patient_Type {get; set;}
    public virtual ServiceRootURL_Store patient_Url { get; set; }
    public int? patient_ServiceRootURL_StoreID { get; set; }
    public string subject_VersionId {get; set;}
    public string subject_FhirId {get; set;}
    public string subject_Type {get; set;}
    public virtual ServiceRootURL_Store subject_Url { get; set; }
    public int? subject_ServiceRootURL_StoreID { get; set; }
    public ICollection<Res_GuidanceResponse_History> Res_GuidanceResponse_History_List { get; set; }
    public ICollection<Res_GuidanceResponse_Index__profile> _profile_List { get; set; }
    public ICollection<Res_GuidanceResponse_Index__security> _security_List { get; set; }
    public ICollection<Res_GuidanceResponse_Index__tag> _tag_List { get; set; }
   
    public Res_GuidanceResponse()
    {
      this._profile_List = new HashSet<Res_GuidanceResponse_Index__profile>();
      this._security_List = new HashSet<Res_GuidanceResponse_Index__security>();
      this._tag_List = new HashSet<Res_GuidanceResponse_Index__tag>();
      this.Res_GuidanceResponse_History_List = new HashSet<Res_GuidanceResponse_History>();
    }
  }
}

