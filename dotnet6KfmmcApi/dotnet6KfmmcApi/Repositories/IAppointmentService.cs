using dotnet6KfmmcApi.Entities;
using dotnet6KfmmcApi.Entity;
using KfmmcAppointmentApi.Entities;
using Microsoft.AspNetCore.Mvc;
namespace dotnet6KfmmcApi.Repositories
{
    public interface IAppointmentService
    {
        //public Task<List<MAIN_DIABETIC_REG>> GetMAIN_DIABETIC_REGListAsync();
        public Task<ActionResult<IEnumerable<DiabeticClass>>> DiabeticRegistryData();
        public Task<ActionResult<IEnumerable<Portal_Login_CheckNationalID>>> Portal_Login_CheckNationalID(string nat_id);
        Task<ActionResult<IEnumerable<Portal_Login_InsertLogin>>> Portal_Login_InsertLogin(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Login_CheckLogin>>> Portal_Login_CheckLogin(string nat_id,string auth_code);
        public Task<ActionResult<IEnumerable<Portal_Main_GetPatientDetails>>> Portal_Main_GetPatientDetails(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Main_GetPatientFamilyDetails>>> Portal_Main_GetPatientFamilyDetails(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Vitals_GetWeight>>> Portal_Vitals_GetWeight(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Vitals_GetHeight>>> Portal_Vitals_GetHeight(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Vitals_GetHeartRate>>> Portal_Vitals_GetHeartRate(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Vitals_GetBloodSugarClass>>> Portal_Vitals_GetBloodSugarClass(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Vitals_GetBodyTemprature>>> Portal_Vitals_GetBodyTemprature(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Vitals_GetBloodPressure>>> Portal_Vitals_GetBloodPressure(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Lab_GetLabOrders>>> Portal_Lab_GetLabOrders(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Lab_GetLabResults>>> Portal_Lab_GetLabResults(string OrderNo);
        public Task<ActionResult<IEnumerable<Portal_Booking_GetPatientClinics>>> Portal_Booking_GetPatientClinics(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Booking_GetClinicSlots>>> Portal_Booking_GetClinicSlots(int clinicID);
        public Task<ActionResult<IEnumerable<Portal_Booking_CheckSlot>>> Portal_Booking_CheckSlot(string nat_id, int clinicID);
        public Task<ActionResult<IEnumerable<Portal_Booking_BookSlot>>> Portal_Booking_BookSlot(string nat_id, int clinicID);
        public Task<ActionResult<IEnumerable<Portal_Appointments_GetPastAppointments>>> Portal_Appointments_GetPastAppointments(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Appointments_GetFutureAppointments>>> Portal_Appointments_GetFutureAppointments(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Appointments_GetFutureSpecialityAppointments>>> Portal_Appointments_GetFutureSpecialityAppointments(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Appointments_CancelFutureAppointments>>> Portal_Appointments_CancelFutureAppointments(string nat_id,int app_id);
        public Task<ActionResult<IEnumerable<Portal_Appointments_CancelFutureSpecialityAppointments>>> Portal_Appointments_CancelFutureSpecialityAppointments(string nat_id, int ID,string Source);
        public Task<ActionResult<IEnumerable<Portal_Medication_GetActiveClass>>> Portal_Medication_GetActiveClass(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Medication_GetRefill>>> Portal_Medication_GetRefill(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Medication_RequestRefill>>> Portal_Medication_RequestRefill(string nat_id,int id);
        public Task<ActionResult<IEnumerable<Portal_Main_UpdatePatientAddress>>> Portal_Main_UpdatePatientAddress(string nat_id, string address);
        public Task<ActionResult<IEnumerable<Portal_Prescription_Request>>> Portal_Prescription_Request(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Prescription_ViewRequests>>> Portal_Prescription_ViewRequests(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_ViewRequests>>> Portal_Reports_ViewRequests(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_ViewVisits>>> Portal_Reports_ViewVisits(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_Request>>> Portal_Reports_Request(int id, string req_reason);
        public Task<ActionResult<IEnumerable<Portal_Mobile_InsertCode>>> Portal_Mobile_InsertCode(string nat_id, string newMobile);
        public Task<ActionResult<IEnumerable<Portal_Mobile_CheckCode>>> Portal_Mobile_CheckCode(string nat_id, string newmobile,string auth_code);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetMedicalReports>>> Portal_Reports_GetMedicalReports(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetMedicalReportDetails>>> Portal_Reports_GetMedicalReportDetails(int report_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetSickleaves>>> Portal_Reports_GetSickleaves(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetSickleaveDetails>>> Portal_Reports_GetSickleaveDetails(int ID);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetOperativeReports>>> Portal_Reports_GetOperativeReports(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetOperativeReportDetails>>> Portal_Reports_GetOperativeReportDetails(int ID);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetDischargeSummaries>>> Portal_Reports_GetDischargeSummaries(string nat_id);
        public Task<ActionResult<IEnumerable<Portal_Reports_GetDischargeSummaryDetails>>> Portal_Reports_GetDischargeSummaryDetails(int ID);
        public Task<ActionResult<IEnumerable<Portal_TemporaryMobile_InsertRequest>>> Portal_TemporaryMobile_InsertRequest(string nat_id, string oldMobile, string newMobile);
        public Task<ActionResult<IEnumerable<Portal_TemporaryMobile_CheckCode>>> Portal_TemporaryMobile_CheckCode(string nat_id, string auth_code);




















    }
}
