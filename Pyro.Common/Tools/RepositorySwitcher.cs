﻿
using Hl7.Fhir.Model;
using Hl7.Fhir.Utility;
using Pyro.Common.Interfaces.Repositories;
using Pyro.Common.BusinessEntities.Dto;
using System.Net;

//This file was code generated by Pyro.CodeGeneration.Template.MainTemplate.tt
//Generation TimeStamp: 30/04/2017 10:12:55 PM

namespace Pyro.Common.Tools
{
  public static class RepositorySwitcher
  {
    public static IResourceRepository GetRepository(FHIRAllTypes ResourceType, IUnitOfWork UnitOfWork)
    {
      switch (ResourceType)
      {
        case FHIRAllTypes.Account:
          return UnitOfWork.AccountRepository;
        case FHIRAllTypes.ActivityDefinition:
          return UnitOfWork.ActivityDefinitionRepository;
        case FHIRAllTypes.AdverseEvent:
          return UnitOfWork.AdverseEventRepository;
        case FHIRAllTypes.AllergyIntolerance:
          return UnitOfWork.AllergyIntoleranceRepository;
        case FHIRAllTypes.Appointment:
          return UnitOfWork.AppointmentRepository;
        case FHIRAllTypes.AppointmentResponse:
          return UnitOfWork.AppointmentResponseRepository;
        case FHIRAllTypes.AuditEvent:
          return UnitOfWork.AuditEventRepository;
        case FHIRAllTypes.Basic:
          return UnitOfWork.BasicRepository;
        case FHIRAllTypes.Binary:
          return UnitOfWork.BinaryRepository;
        case FHIRAllTypes.BodySite:
          return UnitOfWork.BodySiteRepository;
        case FHIRAllTypes.Bundle:
          return UnitOfWork.BundleRepository;
        case FHIRAllTypes.CapabilityStatement:
          return UnitOfWork.CapabilityStatementRepository;
        case FHIRAllTypes.CarePlan:
          return UnitOfWork.CarePlanRepository;
        case FHIRAllTypes.CareTeam:
          return UnitOfWork.CareTeamRepository;
        case FHIRAllTypes.ChargeItem:
          return UnitOfWork.ChargeItemRepository;
        case FHIRAllTypes.Claim:
          return UnitOfWork.ClaimRepository;
        case FHIRAllTypes.ClaimResponse:
          return UnitOfWork.ClaimResponseRepository;
        case FHIRAllTypes.ClinicalImpression:
          return UnitOfWork.ClinicalImpressionRepository;
        case FHIRAllTypes.CodeSystem:
          return UnitOfWork.CodeSystemRepository;
        case FHIRAllTypes.Communication:
          return UnitOfWork.CommunicationRepository;
        case FHIRAllTypes.CommunicationRequest:
          return UnitOfWork.CommunicationRequestRepository;
        case FHIRAllTypes.CompartmentDefinition:
          return UnitOfWork.CompartmentDefinitionRepository;
        case FHIRAllTypes.Composition:
          return UnitOfWork.CompositionRepository;
        case FHIRAllTypes.ConceptMap:
          return UnitOfWork.ConceptMapRepository;
        case FHIRAllTypes.Condition:
          return UnitOfWork.ConditionRepository;
        case FHIRAllTypes.Consent:
          return UnitOfWork.ConsentRepository;
        case FHIRAllTypes.Contract:
          return UnitOfWork.ContractRepository;
        case FHIRAllTypes.Coverage:
          return UnitOfWork.CoverageRepository;
        case FHIRAllTypes.DataElement:
          return UnitOfWork.DataElementRepository;
        case FHIRAllTypes.DetectedIssue:
          return UnitOfWork.DetectedIssueRepository;
        case FHIRAllTypes.Device:
          return UnitOfWork.DeviceRepository;
        case FHIRAllTypes.DeviceComponent:
          return UnitOfWork.DeviceComponentRepository;
        case FHIRAllTypes.DeviceMetric:
          return UnitOfWork.DeviceMetricRepository;
        case FHIRAllTypes.DeviceRequest:
          return UnitOfWork.DeviceRequestRepository;
        case FHIRAllTypes.DeviceUseStatement:
          return UnitOfWork.DeviceUseStatementRepository;
        case FHIRAllTypes.DiagnosticReport:
          return UnitOfWork.DiagnosticReportRepository;
        case FHIRAllTypes.DocumentManifest:
          return UnitOfWork.DocumentManifestRepository;
        case FHIRAllTypes.DocumentReference:
          return UnitOfWork.DocumentReferenceRepository;
        case FHIRAllTypes.EligibilityRequest:
          return UnitOfWork.EligibilityRequestRepository;
        case FHIRAllTypes.EligibilityResponse:
          return UnitOfWork.EligibilityResponseRepository;
        case FHIRAllTypes.Encounter:
          return UnitOfWork.EncounterRepository;
        case FHIRAllTypes.Endpoint:
          return UnitOfWork.EndpointRepository;
        case FHIRAllTypes.EnrollmentRequest:
          return UnitOfWork.EnrollmentRequestRepository;
        case FHIRAllTypes.EnrollmentResponse:
          return UnitOfWork.EnrollmentResponseRepository;
        case FHIRAllTypes.EpisodeOfCare:
          return UnitOfWork.EpisodeOfCareRepository;
        case FHIRAllTypes.ExpansionProfile:
          return UnitOfWork.ExpansionProfileRepository;
        case FHIRAllTypes.ExplanationOfBenefit:
          return UnitOfWork.ExplanationOfBenefitRepository;
        case FHIRAllTypes.FamilyMemberHistory:
          return UnitOfWork.FamilyMemberHistoryRepository;
        case FHIRAllTypes.Flag:
          return UnitOfWork.FlagRepository;
        case FHIRAllTypes.Goal:
          return UnitOfWork.GoalRepository;
        case FHIRAllTypes.GraphDefinition:
          return UnitOfWork.GraphDefinitionRepository;
        case FHIRAllTypes.Group:
          return UnitOfWork.GroupRepository;
        case FHIRAllTypes.GuidanceResponse:
          return UnitOfWork.GuidanceResponseRepository;
        case FHIRAllTypes.HealthcareService:
          return UnitOfWork.HealthcareServiceRepository;
        case FHIRAllTypes.ImagingManifest:
          return UnitOfWork.ImagingManifestRepository;
        case FHIRAllTypes.ImagingStudy:
          return UnitOfWork.ImagingStudyRepository;
        case FHIRAllTypes.Immunization:
          return UnitOfWork.ImmunizationRepository;
        case FHIRAllTypes.ImmunizationRecommendation:
          return UnitOfWork.ImmunizationRecommendationRepository;
        case FHIRAllTypes.ImplementationGuide:
          return UnitOfWork.ImplementationGuideRepository;
        case FHIRAllTypes.Library:
          return UnitOfWork.LibraryRepository;
        case FHIRAllTypes.Linkage:
          return UnitOfWork.LinkageRepository;
        case FHIRAllTypes.List:
          return UnitOfWork.ListRepository;
        case FHIRAllTypes.Location:
          return UnitOfWork.LocationRepository;
        case FHIRAllTypes.Measure:
          return UnitOfWork.MeasureRepository;
        case FHIRAllTypes.MeasureReport:
          return UnitOfWork.MeasureReportRepository;
        case FHIRAllTypes.Media:
          return UnitOfWork.MediaRepository;
        case FHIRAllTypes.Medication:
          return UnitOfWork.MedicationRepository;
        case FHIRAllTypes.MedicationAdministration:
          return UnitOfWork.MedicationAdministrationRepository;
        case FHIRAllTypes.MedicationDispense:
          return UnitOfWork.MedicationDispenseRepository;
        case FHIRAllTypes.MedicationRequest:
          return UnitOfWork.MedicationRequestRepository;
        case FHIRAllTypes.MedicationStatement:
          return UnitOfWork.MedicationStatementRepository;
        case FHIRAllTypes.MessageDefinition:
          return UnitOfWork.MessageDefinitionRepository;
        case FHIRAllTypes.MessageHeader:
          return UnitOfWork.MessageHeaderRepository;
        case FHIRAllTypes.NamingSystem:
          return UnitOfWork.NamingSystemRepository;
        case FHIRAllTypes.NutritionOrder:
          return UnitOfWork.NutritionOrderRepository;
        case FHIRAllTypes.Observation:
          return UnitOfWork.ObservationRepository;
        case FHIRAllTypes.OperationDefinition:
          return UnitOfWork.OperationDefinitionRepository;
        case FHIRAllTypes.OperationOutcome:
          return UnitOfWork.OperationOutcomeRepository;
        case FHIRAllTypes.Organization:
          return UnitOfWork.OrganizationRepository;
        case FHIRAllTypes.Parameters:
          return UnitOfWork.ParametersRepository;
        case FHIRAllTypes.Patient:
          return UnitOfWork.PatientRepository;
        case FHIRAllTypes.PaymentNotice:
          return UnitOfWork.PaymentNoticeRepository;
        case FHIRAllTypes.PaymentReconciliation:
          return UnitOfWork.PaymentReconciliationRepository;
        case FHIRAllTypes.Person:
          return UnitOfWork.PersonRepository;
        case FHIRAllTypes.PlanDefinition:
          return UnitOfWork.PlanDefinitionRepository;
        case FHIRAllTypes.Practitioner:
          return UnitOfWork.PractitionerRepository;
        case FHIRAllTypes.PractitionerRole:
          return UnitOfWork.PractitionerRoleRepository;
        case FHIRAllTypes.Procedure:
          return UnitOfWork.ProcedureRepository;
        case FHIRAllTypes.ProcedureRequest:
          return UnitOfWork.ProcedureRequestRepository;
        case FHIRAllTypes.ProcessRequest:
          return UnitOfWork.ProcessRequestRepository;
        case FHIRAllTypes.ProcessResponse:
          return UnitOfWork.ProcessResponseRepository;
        case FHIRAllTypes.Provenance:
          return UnitOfWork.ProvenanceRepository;
        case FHIRAllTypes.Questionnaire:
          return UnitOfWork.QuestionnaireRepository;
        case FHIRAllTypes.QuestionnaireResponse:
          return UnitOfWork.QuestionnaireResponseRepository;
        case FHIRAllTypes.ReferralRequest:
          return UnitOfWork.ReferralRequestRepository;
        case FHIRAllTypes.RelatedPerson:
          return UnitOfWork.RelatedPersonRepository;
        case FHIRAllTypes.RequestGroup:
          return UnitOfWork.RequestGroupRepository;
        case FHIRAllTypes.ResearchStudy:
          return UnitOfWork.ResearchStudyRepository;
        case FHIRAllTypes.ResearchSubject:
          return UnitOfWork.ResearchSubjectRepository;
        case FHIRAllTypes.RiskAssessment:
          return UnitOfWork.RiskAssessmentRepository;
        case FHIRAllTypes.Schedule:
          return UnitOfWork.ScheduleRepository;
        case FHIRAllTypes.SearchParameter:
          return UnitOfWork.SearchParameterRepository;
        case FHIRAllTypes.Sequence:
          return UnitOfWork.SequenceRepository;
        case FHIRAllTypes.ServiceDefinition:
          return UnitOfWork.ServiceDefinitionRepository;
        case FHIRAllTypes.Slot:
          return UnitOfWork.SlotRepository;
        case FHIRAllTypes.Specimen:
          return UnitOfWork.SpecimenRepository;
        case FHIRAllTypes.StructureDefinition:
          return UnitOfWork.StructureDefinitionRepository;
        case FHIRAllTypes.StructureMap:
          return UnitOfWork.StructureMapRepository;
        case FHIRAllTypes.Subscription:
          return UnitOfWork.SubscriptionRepository;
        case FHIRAllTypes.Substance:
          return UnitOfWork.SubstanceRepository;
        case FHIRAllTypes.SupplyDelivery:
          return UnitOfWork.SupplyDeliveryRepository;
        case FHIRAllTypes.SupplyRequest:
          return UnitOfWork.SupplyRequestRepository;
        case FHIRAllTypes.Task:
          return UnitOfWork.TaskRepository;
        case FHIRAllTypes.TestReport:
          return UnitOfWork.TestReportRepository;
        case FHIRAllTypes.TestScript:
          return UnitOfWork.TestScriptRepository;
        case FHIRAllTypes.ValueSet:
          return UnitOfWork.ValueSetRepository;
        case FHIRAllTypes.VisionPrescription:
          return UnitOfWork.VisionPrescriptionRepository;
  
        default:
          {
            string Message = $"The Resource name given: '{ResourceType.GetLiteral()}' has no matching server repository. ";
            var OpOutCome = FhirOperationOutcomeSupport.Create(OperationOutcome.IssueSeverity.Fatal, OperationOutcome.IssueType.Invalid, Message);
            throw new DtoPyroException(HttpStatusCode.BadRequest, OpOutCome, Message);
          }
      }
    }
  }
}


