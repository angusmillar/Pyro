﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This source file has been auto generated.

namespace Blaze.DataModel.BlazeDbModel
{

  public class Res_AllergyIntolerance
  {
    public int Id {get; set;}
    public string FhirId {get; set;}    
    public int Version {get; set;}
    public DateTimeOffset Received {get; set;}
    public string XmlBlob {get; set;}    
    public string category_Code {get; set;}                  
    public string category_System {get; set;}                
    public string criticality_Code {get; set;}                  
    public string criticality_System {get; set;}                
    public DateTimeOffset? date_DateTimeOffset {get; set;}              
    public DateTimeOffset? last_date_DateTimeOffset {get; set;}              
    public string patient_FhirId {get; set;}     
    public string patient_Type {get; set;}     
    public string patient_Url {get; set;}     
    public string recorder_FhirId {get; set;}     
    public string recorder_Type {get; set;}     
    public string recorder_Url {get; set;}     
    public string reporter_FhirId {get; set;}     
    public string reporter_Type {get; set;}     
    public string reporter_Url {get; set;}     
    public string status_Code {get; set;}                  
    public string status_System {get; set;}                
    public string type_Code {get; set;}                  
    public string type_System {get; set;}                

    public ICollection<Res_AllergyIntolerance_Index_identifier> identifier_List { get; set; }   
    public ICollection<Res_AllergyIntolerance_Index_manifestation> manifestation_List { get; set; }   
    public ICollection<Res_AllergyIntolerance_Index_onset> onset_List { get; set; }   
    public ICollection<Res_AllergyIntolerance_Index_route> route_List { get; set; }   
    public ICollection<Res_AllergyIntolerance_Index_severity> severity_List { get; set; }   
    public ICollection<Res_AllergyIntolerance_Index_substance> substance_List { get; set; }   

    public Res_AllergyIntolerance()
    {
      this.identifier_List = new HashSet<Res_AllergyIntolerance_Index_identifier>();
      this.manifestation_List = new HashSet<Res_AllergyIntolerance_Index_manifestation>();
      this.onset_List = new HashSet<Res_AllergyIntolerance_Index_onset>();
      this.route_List = new HashSet<Res_AllergyIntolerance_Index_route>();
      this.severity_List = new HashSet<Res_AllergyIntolerance_Index_severity>();
      this.substance_List = new HashSet<Res_AllergyIntolerance_Index_substance>();
    }
  }
}