﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_ProcedureRequest : ResourceIndexBase
  {
    public int Res_ProcedureRequestID {get; set;}
    public string encounter_VersionId {get; set;}
    public string encounter_FhirId {get; set;}
    public string encounter_Type {get; set;}
    public virtual ServiceRootURL_Store encounter_Url { get; set; }
    public int? encounter_ServiceRootURL_StoreID { get; set; }
    public string orderer_VersionId {get; set;}
    public string orderer_FhirId {get; set;}
    public string orderer_Type {get; set;}
    public virtual ServiceRootURL_Store orderer_Url { get; set; }
    public int? orderer_ServiceRootURL_StoreID { get; set; }
    public string patient_VersionId {get; set;}
    public string patient_FhirId {get; set;}
    public string patient_Type {get; set;}
    public virtual ServiceRootURL_Store patient_Url { get; set; }
    public int? patient_ServiceRootURL_StoreID { get; set; }
    public string performer_VersionId {get; set;}
    public string performer_FhirId {get; set;}
    public string performer_Type {get; set;}
    public virtual ServiceRootURL_Store performer_Url { get; set; }
    public int? performer_ServiceRootURL_StoreID { get; set; }
    public string subject_VersionId {get; set;}
    public string subject_FhirId {get; set;}
    public string subject_Type {get; set;}
    public virtual ServiceRootURL_Store subject_Url { get; set; }
    public int? subject_ServiceRootURL_StoreID { get; set; }
    public ICollection<Res_ProcedureRequest_History> Res_ProcedureRequest_History_List { get; set; }
    public ICollection<Res_ProcedureRequest_Index_identifier> identifier_List { get; set; }
    public ICollection<Res_ProcedureRequest_Index__profile> _profile_List { get; set; }
    public ICollection<Res_ProcedureRequest_Index__security> _security_List { get; set; }
    public ICollection<Res_ProcedureRequest_Index__tag> _tag_List { get; set; }
   
    public Res_ProcedureRequest()
    {
      this.identifier_List = new HashSet<Res_ProcedureRequest_Index_identifier>();
      this._profile_List = new HashSet<Res_ProcedureRequest_Index__profile>();
      this._security_List = new HashSet<Res_ProcedureRequest_Index__security>();
      this._tag_List = new HashSet<Res_ProcedureRequest_Index__tag>();
      this.Res_ProcedureRequest_History_List = new HashSet<Res_ProcedureRequest_History>();
    }
  }
}

