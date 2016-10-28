﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_NutritionRequest : ResourceIndexBase
  {
    public int Res_NutritionRequestID {get; set;}
    public DateTimeOffset? datetime_DateTimeOffset {get; set;}
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
    public string provider_VersionId {get; set;}
    public string provider_FhirId {get; set;}
    public string provider_Type {get; set;}
    public virtual ServiceRootURL_Store provider_Url { get; set; }
    public int? provider_ServiceRootURL_StoreID { get; set; }
    public string status_Code {get; set;}
    public string status_System {get; set;}
    public ICollection<Res_NutritionRequest_History> Res_NutritionRequest_History_List { get; set; }
    public ICollection<Res_NutritionRequest_Index_additive> additive_List { get; set; }
    public ICollection<Res_NutritionRequest_Index_formula> formula_List { get; set; }
    public ICollection<Res_NutritionRequest_Index_identifier> identifier_List { get; set; }
    public ICollection<Res_NutritionRequest_Index_oraldiet> oraldiet_List { get; set; }
    public ICollection<Res_NutritionRequest_Index_supplement> supplement_List { get; set; }
    public ICollection<Res_NutritionRequest_Index__profile> _profile_List { get; set; }
    public ICollection<Res_NutritionRequest_Index__security> _security_List { get; set; }
    public ICollection<Res_NutritionRequest_Index__tag> _tag_List { get; set; }
   
    public Res_NutritionRequest()
    {
      this.additive_List = new HashSet<Res_NutritionRequest_Index_additive>();
      this.formula_List = new HashSet<Res_NutritionRequest_Index_formula>();
      this.identifier_List = new HashSet<Res_NutritionRequest_Index_identifier>();
      this.oraldiet_List = new HashSet<Res_NutritionRequest_Index_oraldiet>();
      this.supplement_List = new HashSet<Res_NutritionRequest_Index_supplement>();
      this._profile_List = new HashSet<Res_NutritionRequest_Index__profile>();
      this._security_List = new HashSet<Res_NutritionRequest_Index__security>();
      this._tag_List = new HashSet<Res_NutritionRequest_Index__tag>();
      this.Res_NutritionRequest_History_List = new HashSet<Res_NutritionRequest_History>();
    }
  }
}

