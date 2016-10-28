﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pyro.DataModel.DatabaseModel.Base;

//This source file has been auto generated.

namespace Pyro.DataModel.DatabaseModel
{

  public class Res_Organization : ResourceIndexBase
  {
    public int Res_OrganizationID {get; set;}
    public string active_Code {get; set;}
    public string active_System {get; set;}
    public string name_String {get; set;}
    public string partof_VersionId {get; set;}
    public string partof_FhirId {get; set;}
    public string partof_Type {get; set;}
    public virtual ServiceRootURL_Store partof_Url { get; set; }
    public int? partof_ServiceRootURL_StoreID { get; set; }
    public string phonetic_String {get; set;}
    public ICollection<Res_Organization_History> Res_Organization_History_List { get; set; }
    public ICollection<Res_Organization_Index_address> address_List { get; set; }
    public ICollection<Res_Organization_Index_address_city> address_city_List { get; set; }
    public ICollection<Res_Organization_Index_address_country> address_country_List { get; set; }
    public ICollection<Res_Organization_Index_address_postalcode> address_postalcode_List { get; set; }
    public ICollection<Res_Organization_Index_address_state> address_state_List { get; set; }
    public ICollection<Res_Organization_Index_address_use> address_use_List { get; set; }
    public ICollection<Res_Organization_Index_identifier> identifier_List { get; set; }
    public ICollection<Res_Organization_Index_name> name_List { get; set; }
    public ICollection<Res_Organization_Index_type> type_List { get; set; }
    public ICollection<Res_Organization_Index__profile> _profile_List { get; set; }
    public ICollection<Res_Organization_Index__security> _security_List { get; set; }
    public ICollection<Res_Organization_Index__tag> _tag_List { get; set; }
   
    public Res_Organization()
    {
      this.address_List = new HashSet<Res_Organization_Index_address>();
      this.address_city_List = new HashSet<Res_Organization_Index_address_city>();
      this.address_country_List = new HashSet<Res_Organization_Index_address_country>();
      this.address_postalcode_List = new HashSet<Res_Organization_Index_address_postalcode>();
      this.address_state_List = new HashSet<Res_Organization_Index_address_state>();
      this.address_use_List = new HashSet<Res_Organization_Index_address_use>();
      this.identifier_List = new HashSet<Res_Organization_Index_identifier>();
      this.name_List = new HashSet<Res_Organization_Index_name>();
      this.type_List = new HashSet<Res_Organization_Index_type>();
      this._profile_List = new HashSet<Res_Organization_Index__profile>();
      this._security_List = new HashSet<Res_Organization_Index__security>();
      this._tag_List = new HashSet<Res_Organization_Index__tag>();
      this.Res_Organization_History_List = new HashSet<Res_Organization_History>();
    }
  }
}

