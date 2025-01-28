using dotnet6KfmmcApi.Data;
using dotnet6KfmmcApi.Entities;
using dotnet6KfmmcApi.Entity;
using KfmmcAppointmentApi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dotnet6KfmmcApi.Repositories
{
    public class AppointmentService : IAppointmentService
    {
        private readonly DbContextClass _dbContext;
        public AppointmentService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        //public async Task<ActionResult<IEnumerable<Controllers.Company>>> Getdata()
        //{
        //    //return await _dbContext.MAIN_DIABETIC_REGObj.FromSqlRaw<DiabeticClass>("sp_selectDiabeticRegistry").ToListAsync();
        //    IEnumerable<Controllers.Company> DrData = await _dbContext.DrList.FromSqlRaw<Controllers.Company>("sp_getdata").ToListAsync();
        //    var json = JsonConvert.SerializeObject(DrData);
        //    return new OkObjectResult(json);

        //}
        public async Task<ActionResult<IEnumerable<DiabeticClass>>>DiabeticRegistryData()
        {
            //return await _dbContext.MAIN_DIABETIC_REGObj.FromSqlRaw<DiabeticClass>("sp_selectDiabeticRegistry").ToListAsync();
            IEnumerable<DiabeticClass> diabeticClassesObj=await _dbContext.MAIN_DIABETIC_REGObj.FromSqlRaw<DiabeticClass>("sp_selectDiabeticRegistry").ToListAsync();
            var json=JsonConvert.SerializeObject(diabeticClassesObj);
            return new OkObjectResult(json);
            
        }
        public async Task<ActionResult<IEnumerable<Portal_Login_CheckNationalID>>> Portal_Login_CheckNationalID(string nat_id)
        {
            IEnumerable<Portal_Login_CheckNationalID> ClassesObj = await _dbContext.Portal_Login_CheckNationalIDs.FromSqlRaw("EXEC Portal_Login_CheckNationalID @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }

        public async Task<ActionResult<IEnumerable<Portal_Login_InsertLogin>>> Portal_Login_InsertLogin(string nat_id)
        {
            IEnumerable<Portal_Login_InsertLogin> ClassesObj = await _dbContext.Portal_Login_InsertLogins.FromSqlRaw("EXEC Portal_Login_InsertLogin @nationalID = {0}", nat_id).ToListAsync();
            string json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }

        public async Task<ActionResult<IEnumerable<Portal_Login_CheckLogin>>> Portal_Login_CheckLogin(string nat_id,string auth_code)
        {
            IEnumerable<Portal_Login_CheckLogin> ClassesObj = await _dbContext.Portal_Login_CheckLogins.FromSqlRaw("EXEC Portal_Login_CheckLogin @nationalID = {0},@auth_code = {1}", nat_id, auth_code).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Main_GetPatientDetails>>> Portal_Main_GetPatientDetails(string nat_id)
        {
            IEnumerable<Portal_Main_GetPatientDetails> ClassesObj = await _dbContext.Portal_Main_GetPatientDetailss.FromSqlRaw("EXEC Portal_Main_GetPatientDetails @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Main_GetPatientFamilyDetails>>> Portal_Main_GetPatientFamilyDetails(string nat_id)
        {
            IEnumerable<Portal_Main_GetPatientFamilyDetails> ClassesObj = await _dbContext.Portal_Main_GetPatientFamilyDetailss.FromSqlRaw("EXEC Portal_Main_GetPatientFamilyDetails @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetWeight>>> Portal_Vitals_GetWeight(string nat_id)
        {
            IEnumerable<Portal_Vitals_GetWeight> ClassesObj = await _dbContext.Portal_Vitals_GetWeights.FromSqlRaw("EXEC Portal_Vitals_GetWeight @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetHeight>>> Portal_Vitals_GetHeight(string nat_id)
        {
            IEnumerable<Portal_Vitals_GetHeight> ClassesObj = await _dbContext.Portal_Vitals_GetHeights.FromSqlRaw("EXEC Portal_Vitals_GetHeight @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetHeartRate>>> Portal_Vitals_GetHeartRate(string nat_id)
        {
            IEnumerable<Portal_Vitals_GetHeartRate> ClassesObj = await _dbContext.Portal_Vitals_GetHeartRates.FromSqlRaw("EXEC Portal_Vitals_GetHeight @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetBloodSugarClass>>> Portal_Vitals_GetBloodSugarClass(string nat_id)
        {
            IEnumerable<Portal_Vitals_GetBloodSugarClass> ClassesObj = await _dbContext.Portal_Vitals_GetBloodSugarClasss.FromSqlRaw("EXEC Portal_Vitals_GetBloodSugar @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetBodyTemprature>>> Portal_Vitals_GetBodyTemprature(string nat_id)
        {
            IEnumerable<Portal_Vitals_GetBodyTemprature> ClassesObj = await _dbContext.Portal_Vitals_GetBodyTempratures.FromSqlRaw("EXEC Portal_Vitals_GetBodyTemprature @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetBloodPressure>>> Portal_Vitals_GetBloodPressure(string nat_id)
        {
            IEnumerable<Portal_Vitals_GetBloodPressure> ClassesObj = await _dbContext.Portal_Vitals_GetBloodPressures.FromSqlRaw("EXEC Portal_Vitals_GetBloodPressure @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Lab_GetLabOrders>>> Portal_Lab_GetLabOrders(string nat_id)
        {
            IEnumerable<Portal_Lab_GetLabOrders> ClassesObj = await _dbContext.Portal_Lab_GetLabOrderss.FromSqlRaw("EXEC Portal_Lab_GetLabOrders @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Lab_GetLabResults>>> Portal_Lab_GetLabResults(string OrderNo)
        {
            IEnumerable<Portal_Lab_GetLabResults> ClassesObj = await _dbContext.Portal_Lab_GetLabResultss.FromSqlRaw("EXEC Portal_Lab_GetLabResults @OrderNo = {0}", OrderNo).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Booking_GetPatientClinics>>> Portal_Booking_GetPatientClinics(string nat_id)
        {
            IEnumerable<Portal_Booking_GetPatientClinics> ClassesObj = await _dbContext.Portal_Booking_GetPatientClinicss.FromSqlRaw("EXEC Portal_Booking_GetPatientClinics @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Booking_GetClinicSlots>>> Portal_Booking_GetClinicSlots(int clinicID)
        {
            IEnumerable<Portal_Booking_GetClinicSlots> ClassesObj = await _dbContext.Portal_Booking_GetClinicSlotss.FromSqlRaw("EXEC Portal_Booking_GetClinicSlots @clinicID = {0}", clinicID).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Booking_CheckSlot>>> Portal_Booking_CheckSlot(string nat_id,int SlotID)
        {
            IEnumerable<Portal_Booking_CheckSlot> ClassesObj = await _dbContext.Portal_Booking_CheckSlotss.FromSqlRaw("EXEC Portal_Booking_CheckSlot @nationalID = {0},@SlotID = {1}", nat_id, SlotID).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Booking_BookSlot>>> Portal_Booking_BookSlot(string nat_id, int SlotID)
        {
            IEnumerable<Portal_Booking_BookSlot> ClassesObj = await _dbContext.Portal_Booking_BookSlots.FromSqlRaw("EXEC Portal_Booking_BookSlot @nationalID = {0},@SlotID = {1}", nat_id, SlotID).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Appointments_GetPastAppointments>>> Portal_Appointments_GetPastAppointments(string nat_id)
        {
            IEnumerable<Portal_Appointments_GetPastAppointments> ClassesObj = await _dbContext.Portal_Appointments_GetPastAppointmentss.FromSqlRaw("EXEC Portal_Appointments_GetPastAppointments @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Appointments_GetFutureAppointments>>> Portal_Appointments_GetFutureAppointments(string nat_id)
        {
            IEnumerable<Portal_Appointments_GetFutureAppointments> ClassesObj = await _dbContext.Portal_Appointments_GetFutureAppointmentss.FromSqlRaw("EXEC Portal_Appointments_GetFutureAppointments @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Appointments_GetFutureSpecialityAppointments>>> Portal_Appointments_GetFutureSpecialityAppointments(string nat_id)
        {
            IEnumerable<Portal_Appointments_GetFutureSpecialityAppointments> ClassesObj = await _dbContext.Portal_Appointments_GetFutureSpecialityAppointmentss.FromSqlRaw("EXEC Portal_Appointments_GetFutureSpecialityAppointments @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Appointments_CancelFutureAppointments>>> Portal_Appointments_CancelFutureAppointments(string nat_id, int app_id)
        {
            IEnumerable<Portal_Appointments_CancelFutureAppointments> ClassesObj = await _dbContext.Portal_Appointments_CancelFutureAppointmentss.FromSqlRaw("EXEC Portal_Appointments_CancelFutureAppointments @nationalID = {0},@app_id = {0}", nat_id, app_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Appointments_CancelFutureSpecialityAppointments>>> Portal_Appointments_CancelFutureSpecialityAppointments(string nat_id, int ID,string Source)
        {
            IEnumerable<Portal_Appointments_CancelFutureSpecialityAppointments> ClassesObj = await _dbContext.Portal_Appointments_CancelFutureSpecialityAppointmentss.FromSqlRaw("EXEC Portal_Appointments_CancelFutureSpecialityAppointments @nationalID = {0},@ID = {1},@Source = {1}", nat_id, ID, Source).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Medication_GetActiveClass>>> Portal_Medication_GetActiveClass(string nat_id)
        {
            IEnumerable<Portal_Medication_GetActiveClass> ClassesObj = await _dbContext.Portal_Medication_GetActiveClasss.FromSqlRaw("EXEC Portal_Medication_GetActive @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Medication_GetRefill>>> Portal_Medication_GetRefill(string nat_id)
        {
            IEnumerable<Portal_Medication_GetRefill> ClassesObj = await _dbContext.Portal_Medication_GetRefills.FromSqlRaw("EXEC Portal_Medication_GetRefill @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Medication_RequestRefill>>> Portal_Medication_RequestRefill(string nat_id,int id)
        {
            IEnumerable<Portal_Medication_RequestRefill> ClassesObj = await _dbContext.Portal_Medication_RequestRefills.FromSqlRaw("EXEC Portal_Medication_RequestRefill @nationalID = {0},@id = {1}", nat_id,id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Main_UpdatePatientAddress>>> Portal_Main_UpdatePatientAddress(string nat_id, string address)
        {
            IEnumerable<Portal_Main_UpdatePatientAddress> ClassesObj = await _dbContext.Portal_Main_UpdatePatientAddresss.FromSqlRaw("EXEC Portal_Main_UpdatePatientAddress @nationalID = {0},@address = {1}", nat_id, address).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Prescription_Request>>> Portal_Prescription_Request(string nat_id)
        {
            IEnumerable<Portal_Prescription_Request> ClassesObj = await _dbContext.Portal_Prescription_Requests.FromSqlRaw("EXEC Portal_Prescription_Request @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Prescription_ViewRequests>>> Portal_Prescription_ViewRequests(string nat_id)
        {
            IEnumerable<Portal_Prescription_ViewRequests> ClassesObj = await _dbContext.Portal_Prescription_ViewRequestss.FromSqlRaw("EXEC Portal_Prescription_ViewRequests @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_ViewRequests>>> Portal_Reports_ViewRequests(string nat_id)
        {
            IEnumerable<Portal_Reports_ViewRequests> ClassesObj = await _dbContext.Portal_Reports_ViewRequestss.FromSqlRaw("EXEC Portal_Reports_ViewRequests @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_ViewVisits>>> Portal_Reports_ViewVisits(string nat_id)
        {
            IEnumerable<Portal_Reports_ViewVisits> ClassesObj = await _dbContext.Portal_Reports_ViewVisitss.FromSqlRaw("EXEC Portal_Reports_ViewVisits @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_Request>>> Portal_Reports_Request(int id,string req_reason)
        {
            IEnumerable<Portal_Reports_Request> ClassesObj = await _dbContext.Portal_Reports_Requests.FromSqlRaw("EXEC Portal_Reports_Request @id = {0},@req_reason = {1}", id, req_reason).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Mobile_InsertCode>>> Portal_Mobile_InsertCode(string nat_id, string newMobile)
        {
            IEnumerable<Portal_Mobile_InsertCode> ClassesObj = await _dbContext.Portal_Mobile_InsertCodes.FromSqlRaw("EXEC Portal_Mobile_InsertCode @nationalID = {0},@newMobile = {1}", nat_id, newMobile).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Mobile_CheckCode>>> Portal_Mobile_CheckCode(string nat_id, string newmobile, string auth_code)
        {
            IEnumerable<Portal_Mobile_CheckCode> ClassesObj = await _dbContext.Portal_Mobile_CheckCodes.FromSqlRaw("EXEC Portal_Mobile_CheckCode @nationalID = {0},@newmobile = {1},@auth_code = {2}", nat_id, newmobile, auth_code).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetMedicalReports>>> Portal_Reports_GetMedicalReports(string nat_id)
        {
            IEnumerable<Portal_Reports_GetMedicalReports> ClassesObj = await _dbContext.Portal_Reports_GetMedicalReportss.FromSqlRaw("EXEC Portal_Reports_GetMedicalReports @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetMedicalReportDetails>>> Portal_Reports_GetMedicalReportDetails(int report_id)
        {
            IEnumerable<Portal_Reports_GetMedicalReportDetails> ClassesObj = await _dbContext.Portal_Reports_GetMedicalReportDetailss.FromSqlRaw("EXEC Portal_Reports_GetMedicalReportDetails @report_id = {0}", report_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetSickleaves>>> Portal_Reports_GetSickleaves(string nat_id)
        {
            IEnumerable<Portal_Reports_GetSickleaves> ClassesObj = await _dbContext.Portal_Reports_GetSickleavess.FromSqlRaw("EXEC Portal_Reports_GetSickleaves @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetSickleaveDetails>>> Portal_Reports_GetSickleaveDetails(int ID)
        {
            IEnumerable<Portal_Reports_GetSickleaveDetails> ClassesObj = await _dbContext.Portal_Reports_GetSickleaveDetailss.FromSqlRaw("EXEC Portal_Reports_GetSickleaveDetails @ID = {0}", ID).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetOperativeReports>>> Portal_Reports_GetOperativeReports(string nat_id)
        {
            IEnumerable<Portal_Reports_GetOperativeReports> ClassesObj = await _dbContext.Portal_Reports_GetOperativeReportss.FromSqlRaw("EXEC Portal_Reports_GetOperativeReports @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetOperativeReportDetails>>> Portal_Reports_GetOperativeReportDetails(int ID)
        {
            IEnumerable<Portal_Reports_GetOperativeReportDetails> ClassesObj = await _dbContext.Portal_Reports_GetOperativeReportDetailss.FromSqlRaw("EXEC Portal_Reports_GetOperativeReportDetails @ID = {0}", ID).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetDischargeSummaries>>> Portal_Reports_GetDischargeSummaries(string nat_id)
        {
            IEnumerable<Portal_Reports_GetDischargeSummaries> ClassesObj = await _dbContext.Portal_Reports_GetDischargeSummariess.FromSqlRaw("EXEC Portal_Reports_GetDischargeSummaries @nationalID = {0}", nat_id).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetDischargeSummaryDetails>>> Portal_Reports_GetDischargeSummaryDetails(int ID)
        {
            IEnumerable<Portal_Reports_GetDischargeSummaryDetails> ClassesObj = await _dbContext.Portal_Reports_GetDischargeSummaryDetailss.FromSqlRaw("EXEC Portal_Reports_GetDischargeSummaryDetails @ID = {0}", ID).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_TemporaryMobile_InsertRequest>>> Portal_TemporaryMobile_InsertRequest(string nat_id, string oldMobile, string newMobile)
        {
            IEnumerable<Portal_TemporaryMobile_InsertRequest> ClassesObj = await _dbContext.Portal_TemporaryMobile_InsertRequests.FromSqlRaw("EXEC Portal_TemporaryMobile_InsertRequest @nationalID = {0},@oldMobile = {1},@newMobile = {2}", nat_id, oldMobile, newMobile).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }
        public async Task<ActionResult<IEnumerable<Portal_TemporaryMobile_CheckCode>>> Portal_TemporaryMobile_CheckCode(string nat_id, string auth_code)
        {
            IEnumerable<Portal_TemporaryMobile_CheckCode> ClassesObj = await _dbContext.Portal_TemporaryMobile_CheckCodes.FromSqlRaw("EXEC Portal_TemporaryMobile_CheckCode @nationalID = {0},@auth_code = {1}", nat_id, auth_code).ToListAsync();
            var json = JsonConvert.SerializeObject(ClassesObj);
            return new OkObjectResult(json);
        }




















    }
}


