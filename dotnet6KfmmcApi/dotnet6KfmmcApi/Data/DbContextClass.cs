using dotnet6KfmmcApi.Entities;
using dotnet6KfmmcApi.Entity;
using KfmmcAppointmentApi.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace dotnet6KfmmcApi.Data
{
    public class DbContextClass: DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("AppointmentApiConn"));
        }
        //public DbSet<Controllers.Company> DrList { get; set; }
        public DbSet<DiabeticClass> MAIN_DIABETIC_REGObj { get; set; }
        public DbSet<Portal_Login_CheckNationalID> Portal_Login_CheckNationalIDs { get; set; }
        public DbSet<Portal_Login_InsertLogin> Portal_Login_InsertLogins { get; set; }
        public DbSet<Portal_Login_CheckLogin> Portal_Login_CheckLogins { get; set; }
        public DbSet<Portal_Main_GetPatientDetails> Portal_Main_GetPatientDetailss { get; set; }
        public DbSet<Portal_Main_GetPatientFamilyDetails> Portal_Main_GetPatientFamilyDetailss { get; set; }
        public DbSet<Portal_Vitals_GetWeight> Portal_Vitals_GetWeights { get; set; }
        public DbSet<Portal_Vitals_GetHeight> Portal_Vitals_GetHeights { get; set; }
        public DbSet<Portal_Vitals_GetHeartRate> Portal_Vitals_GetHeartRates { get; set; }
        public DbSet<Portal_Vitals_GetBloodSugarClass> Portal_Vitals_GetBloodSugarClasss { get; set; }
        public DbSet<Portal_Vitals_GetBodyTemprature> Portal_Vitals_GetBodyTempratures { get; set; }
        public DbSet<Portal_Vitals_GetBloodPressure> Portal_Vitals_GetBloodPressures { get; set; }
        public DbSet<Portal_Lab_GetLabOrders> Portal_Lab_GetLabOrderss { get; set; }
        public DbSet<Portal_Lab_GetLabResults> Portal_Lab_GetLabResultss { get; set; }
        public DbSet<Portal_Booking_GetPatientClinics> Portal_Booking_GetPatientClinicss { get; set; }
        public DbSet<Portal_Booking_GetClinicSlots> Portal_Booking_GetClinicSlotss { get; set; }
        public DbSet<Portal_Booking_CheckSlot> Portal_Booking_CheckSlotss { get; set; }
        public DbSet<Portal_Booking_BookSlot> Portal_Booking_BookSlots { get; set; }
        public DbSet<Portal_Appointments_GetPastAppointments> Portal_Appointments_GetPastAppointmentss { get; set; }
        public DbSet<Portal_Appointments_GetFutureAppointments> Portal_Appointments_GetFutureAppointmentss { get; set; }
        public DbSet<Portal_Appointments_GetFutureSpecialityAppointments> Portal_Appointments_GetFutureSpecialityAppointmentss { get; set; }
        public DbSet<Portal_Appointments_CancelFutureAppointments> Portal_Appointments_CancelFutureAppointmentss { get; set; }
        public DbSet<Portal_Appointments_CancelFutureSpecialityAppointments> Portal_Appointments_CancelFutureSpecialityAppointmentss { get; set; }
        public DbSet<Portal_Medication_GetActiveClass> Portal_Medication_GetActiveClasss { get; set; }
        public DbSet<Portal_Medication_GetRefill> Portal_Medication_GetRefills { get; set; }
        public DbSet<Portal_Medication_RequestRefill> Portal_Medication_RequestRefills { get; set; }
        public DbSet<Portal_Main_UpdatePatientAddress> Portal_Main_UpdatePatientAddresss { get; set; }
        public DbSet<Portal_Prescription_Request> Portal_Prescription_Requests { get; set; }
        public DbSet<Portal_Prescription_ViewRequests> Portal_Prescription_ViewRequestss { get; set; }
        public DbSet<Portal_Reports_ViewRequests> Portal_Reports_ViewRequestss { get; set; }
        public DbSet<Portal_Reports_ViewVisits> Portal_Reports_ViewVisitss { get; set; }
        public DbSet<Portal_Reports_Request> Portal_Reports_Requests { get; set; }
        public DbSet<Portal_Mobile_InsertCode> Portal_Mobile_InsertCodes { get; set; }
        public DbSet<Portal_Mobile_CheckCode> Portal_Mobile_CheckCodes { get; set; }
        public DbSet<Portal_Reports_GetMedicalReports> Portal_Reports_GetMedicalReportss { get; set; }
        public DbSet<Portal_Reports_GetMedicalReportDetails> Portal_Reports_GetMedicalReportDetailss { get; set; }
        public DbSet<Portal_Reports_GetSickleaves> Portal_Reports_GetSickleavess { get; set; }
        public DbSet<Portal_Reports_GetSickleaveDetails> Portal_Reports_GetSickleaveDetailss { get; set; }
        public DbSet<Portal_Reports_GetOperativeReports> Portal_Reports_GetOperativeReportss { get; set; }
        public DbSet<Portal_Reports_GetOperativeReportDetails> Portal_Reports_GetOperativeReportDetailss { get; set; }
        public DbSet<Portal_Reports_GetDischargeSummaries> Portal_Reports_GetDischargeSummariess { get; set; }
        public DbSet<Portal_Reports_GetDischargeSummaryDetails> Portal_Reports_GetDischargeSummaryDetailss { get; set; }
        public DbSet<Portal_TemporaryMobile_InsertRequest> Portal_TemporaryMobile_InsertRequests { get; set; }
        public DbSet<Portal_TemporaryMobile_CheckCode> Portal_TemporaryMobile_CheckCodes { get; set; }
        


















    }
}

