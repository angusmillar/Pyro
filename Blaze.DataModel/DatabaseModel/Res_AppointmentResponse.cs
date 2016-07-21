﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blaze.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Blaze.DataModel.DatabaseModel
{

  public class Res_AppointmentResponse : ResourceIndexBase
  {
    public int Res_AppointmentResponseID {get; set;}
    public string actor_VersionId {get; set;}
    public string actor_FhirId {get; set;}
    public string actor_Type {get; set;}
    public virtual Blaze_RootUrlStore actor_Url { get; set; }
    public int? actor_Url_Blaze_RootUrlStoreID { get; set; }
    public string appointment_VersionId {get; set;}
    public string appointment_FhirId {get; set;}
    public string appointment_Type {get; set;}
    public virtual Blaze_RootUrlStore appointment_Url { get; set; }
    public int? appointment_Url_Blaze_RootUrlStoreID { get; set; }
    public string location_VersionId {get; set;}
    public string location_FhirId {get; set;}
    public string location_Type {get; set;}
    public virtual Blaze_RootUrlStore location_Url { get; set; }
    public int? location_Url_Blaze_RootUrlStoreID { get; set; }
    public string part_status_Code {get; set;}
    public string part_status_System {get; set;}
    public string patient_VersionId {get; set;}
    public string patient_FhirId {get; set;}
    public string patient_Type {get; set;}
    public virtual Blaze_RootUrlStore patient_Url { get; set; }
    public int? patient_Url_Blaze_RootUrlStoreID { get; set; }
    public string practitioner_VersionId {get; set;}
    public string practitioner_FhirId {get; set;}
    public string practitioner_Type {get; set;}
    public virtual Blaze_RootUrlStore practitioner_Url { get; set; }
    public int? practitioner_Url_Blaze_RootUrlStoreID { get; set; }
    public ICollection<Res_AppointmentResponse_History> Res_AppointmentResponse_History_List { get; set; }
    public ICollection<Res_AppointmentResponse_Index_identifier> identifier_List { get; set; }
    public ICollection<Res_AppointmentResponse_Index_profile> profile_List { get; set; }
    public ICollection<Res_AppointmentResponse_Index_security> security_List { get; set; }
    public ICollection<Res_AppointmentResponse_Index_tag> tag_List { get; set; }
   
    public Res_AppointmentResponse()
    {
      this.identifier_List = new HashSet<Res_AppointmentResponse_Index_identifier>();
      this.profile_List = new HashSet<Res_AppointmentResponse_Index_profile>();
      this.security_List = new HashSet<Res_AppointmentResponse_Index_security>();
      this.tag_List = new HashSet<Res_AppointmentResponse_Index_tag>();
      this.Res_AppointmentResponse_History_List = new HashSet<Res_AppointmentResponse_History>();
    }
  }
}
