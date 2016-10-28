﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_CommunicationRequest : ResourceIndexBase
  {
    public int Res_CommunicationRequestID {get; set;}
    public string encounter_VersionId {get; set;}
    public string encounter_FhirId {get; set;}
    public string encounter_Type {get; set;}
    public virtual ServiceRootURL_Store encounter_Url { get; set; }
    public int? encounter_ServiceRootURL_StoreID { get; set; }
    public string patient_VersionId {get; set;}
    public string patient_FhirId {get; set;}
    public string patient_Type {get; set;}
    public virtual ServiceRootURL_Store patient_Url { get; set; }
    public int? patient_ServiceRootURL_StoreID { get; set; }
    public DateTimeOffset? requested_DateTimeOffset {get; set;}
    public string requester_VersionId {get; set;}
    public string requester_FhirId {get; set;}
    public string requester_Type {get; set;}
    public virtual ServiceRootURL_Store requester_Url { get; set; }
    public int? requester_ServiceRootURL_StoreID { get; set; }
    public string sender_VersionId {get; set;}
    public string sender_FhirId {get; set;}
    public string sender_Type {get; set;}
    public virtual ServiceRootURL_Store sender_Url { get; set; }
    public int? sender_ServiceRootURL_StoreID { get; set; }
    public string status_Code {get; set;}
    public string status_System {get; set;}
    public string subject_VersionId {get; set;}
    public string subject_FhirId {get; set;}
    public string subject_Type {get; set;}
    public virtual ServiceRootURL_Store subject_Url { get; set; }
    public int? subject_ServiceRootURL_StoreID { get; set; }
    public DateTimeOffset? time_DateTimeOffset {get; set;}
    public ICollection<Res_CommunicationRequest_History> Res_CommunicationRequest_History_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index_category> category_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index_identifier> identifier_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index_medium> medium_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index_priority> priority_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index_recipient> recipient_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index__profile> _profile_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index__security> _security_List { get; set; }
    public ICollection<Res_CommunicationRequest_Index__tag> _tag_List { get; set; }
   
    public Res_CommunicationRequest()
    {
      this.category_List = new HashSet<Res_CommunicationRequest_Index_category>();
      this.identifier_List = new HashSet<Res_CommunicationRequest_Index_identifier>();
      this.medium_List = new HashSet<Res_CommunicationRequest_Index_medium>();
      this.priority_List = new HashSet<Res_CommunicationRequest_Index_priority>();
      this.recipient_List = new HashSet<Res_CommunicationRequest_Index_recipient>();
      this._profile_List = new HashSet<Res_CommunicationRequest_Index__profile>();
      this._security_List = new HashSet<Res_CommunicationRequest_Index__security>();
      this._tag_List = new HashSet<Res_CommunicationRequest_Index__tag>();
      this.Res_CommunicationRequest_History_List = new HashSet<Res_CommunicationRequest_History>();
    }
  }
}

