using dotnet6KfmmcApi.Entities;
using dotnet6KfmmcApi.Entity;
using dotnet6KfmmcApi.Repositories;
using KfmmcAppointmentApi.Controllers;
using KfmmcAppointmentApi.CustomActionFilters;
using KfmmcAppointmentApi.Entities;
using KfmmcAppointmentApi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection;
using System.Xml.Linq;

namespace dotnet6KfmmcApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService MAIN_DIABETIC_REGService;
        private readonly Portal_Login_InsertLoginRepository _repository;
        private readonly IConfiguration _configuration;
        private readonly SmsController _SmsController;
        public AppointmentController(IAppointmentService MAIN_DIABETIC_REGService, Portal_Login_InsertLoginRepository InsertLoginRepository, IConfiguration configuration, SmsController SmsController)
        {
            this.MAIN_DIABETIC_REGService = MAIN_DIABETIC_REGService;
            _repository = InsertLoginRepository;
            _configuration = configuration;
            _SmsController = SmsController;
        }
        //[HttpGet("Getdata")]
        //public IActionResult Getdata()
        //{
        //    var data = new Company
        //    {
        //        Doctors=  MAIN_DIABETIC_REGService.get;
        //        //Doctors = new List<Dr> {
        //        //new Dr{ dr_drno="17659",dr_dept=9130,dr_surnam="Mohd Nafees"},
        //        //new Dr{ dr_drno="16584",dr_dept=9130,dr_surnam="zakir khan"}
        //    }
        //    };
        //    return Ok(JsonConvert.SerializeObject(data));

        //    //var company = new Company { 
        //    //Employees=new List<Employee> { 
        //    //    new Employee{ Id=1,Name="mohd nafees",Salary=1000},
        //    //    new Employee{ Id=1,Name="sammy catrege",Salary=2000}
        //    //}
        //    //};
        //    //return Ok(JsonConvert.SerializeObject(company));
        //    //new Department{
        //    //    Id = 1,
        //    //    Name="HR",
        //    //    Employees=new List<Employee>{
        //    //    new Employee{Id = 1,Name="mohd nafees",Salary=100},
        //    //     new Employee{Id = 2,Name="mohd",Salary=200},
        //    //    }
        //    //},
        //    //new Department{
        //    //    Id = 1,
        //    //    Name="IT",
        //    //    Employees=new List<Employee>{
        //    //    new Employee{Id = 1,Name="Robert",Salary=100},
        //    //     new Employee{Id = 2,Name="Jones",Salary=200},
        //    //    }
        //    //}

        //    //return Ok(JsonConvert.SerializeObject(company));
        //}

        //[HttpGet("Testlogin")]
        //public IActionResult Testlogin()
        //{
        //    var data = new Login() { ID = 17659, Paasword = "123456" };
        //    return Ok(data);
        //}

        // **************** Log in API *****************************
        //[Authorize]
        //[HttpGet]
        //[ValidateModel]
        //[Route("Portal_Login_CheckNationalIDTest")]
        //public async Task<ActionResult<IEnumerable<Portal_Login_CheckNationalID>>> Portal_Login_CheckNationalIDTest([FromBody] Portal_Login_CheckNationalID data)
        //{
        //    var login = await MAIN_DIABETIC_REGService.Portal_Login_CheckNationalID(data.nat_id);
        //    if (login.Result == null)
        //    {
        //        return NotFound();
        //    }

        //    //return Ok(login);
        //    return await MAIN_DIABETIC_REGService.Portal_Login_CheckNationalID(data.nat_id);
        //}
        [Authorize]
        [HttpGet]
        [Route("Portal_Login_CheckNationalID")]
        public async Task<ActionResult<IEnumerable<Portal_Login_CheckNationalID>>> Portal_Login_CheckNationalID([FromQuery] string nat_id)
        {
          
            var login = await MAIN_DIABETIC_REGService.Portal_Login_CheckNationalID(nat_id);
            if (login.Result == null)
            {
                return NotFound();
                //throw new Exception("this is a new exception");
            }
           
            //return Ok(login);
            return await MAIN_DIABETIC_REGService.Portal_Login_CheckNationalID(nat_id);
        }

        [Authorize]
        [HttpGet("Portal_Login_InsertLogin")]
        public async Task<ActionResult<IEnumerable<Portal_Login_InsertLogin>>> Portal_Login_InsertLogin(string nat_id)
        {
            var InsertLogin = await MAIN_DIABETIC_REGService.Portal_Login_InsertLogin(nat_id);
            if (InsertLogin.Result == null)
            {
                return NotFound();
            }
            // Portal_Login_InsertLogin data = new Portal_Login_InsertLogin();
            // var _Login_InsertLogin = await _repository.Portal_Login_InsertLogin(nat_id);
            // foreach (var item in _Login_InsertLogin)
            // {
            //     data.nat_id = item.nat_id;
            //     data.mobile = item.mobile;
            //     data.auth_code = item.auth_code;
            //     data.Sms = item.Sms;
            // }
            //await _SmsController.SendSms(data.mobile, data.Sms);
            // return Ok(_Login_InsertLogin);
            return await MAIN_DIABETIC_REGService.Portal_Login_InsertLogin(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Login_CheckLogin")]
        public async Task<ActionResult<IEnumerable<Portal_Login_CheckLogin>>> Portal_Login_CheckLogin([FromQuery] string nat_id,string auth_code)
        {
            //var Login_CheckLogin = await MAIN_DIABETIC_REGService.Portal_Login_CheckLogin(nat_id, auth_code);
            //if (Login_CheckLogin.Result == null)
            //{
            //    return NotFound();
            //}
            return await MAIN_DIABETIC_REGService.Portal_Login_CheckLogin(nat_id, auth_code);
        }
        // **************** End *****************************************

        // **************** Patient Details API *************************
        [Authorize]
        [HttpGet("Portal_Main_GetPatientDetails")]
        public async Task<ActionResult<IEnumerable<Portal_Main_GetPatientDetails>>> Portal_Main_GetPatientDetails([FromQuery] string nat_id)
        {
            var Main_GetPatientDetails =  await MAIN_DIABETIC_REGService.Portal_Main_GetPatientDetails(nat_id);
            if (Main_GetPatientDetails.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Main_GetPatientDetails(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Main_GetPatientFamilyDetails")]
        public async Task<ActionResult<IEnumerable<Portal_Main_GetPatientFamilyDetails>>> Portal_Main_GetPatientFamilyDetails([FromQuery] string nat_id)
        {
            var GetPatientFamilyDetails = await MAIN_DIABETIC_REGService.Portal_Main_GetPatientFamilyDetails(nat_id);
            if (GetPatientFamilyDetails.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Main_GetPatientFamilyDetails(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Main_UpdatePatientAddress")]
        public async Task<ActionResult<IEnumerable<Portal_Main_UpdatePatientAddress>>> Portal_Main_UpdatePatientAddress([FromQuery] string nat_id, string address)
        {
            var UpdatePatientAddress = await MAIN_DIABETIC_REGService.Portal_Main_UpdatePatientAddress(nat_id, address);
            if (UpdatePatientAddress.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Main_UpdatePatientAddress(nat_id, address);
        }
        // **************** End *****************************************

        // **************** Booking API *********************************
        [Authorize]
        [HttpGet("Portal_Booking_GetPatientClinics")]
        public async Task<ActionResult<IEnumerable<Portal_Booking_GetPatientClinics>>> Portal_Booking_GetPatientClinics([FromQuery] string nat_id)
        {
            var GetPatientClinics = await MAIN_DIABETIC_REGService.Portal_Booking_GetPatientClinics(nat_id);
            if (GetPatientClinics.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Booking_GetPatientClinics(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Booking_GetClinicSlots")]
        public async Task<ActionResult<IEnumerable<Portal_Booking_GetClinicSlots>>> Portal_Booking_GetClinicSlots([FromQuery] int clinicID)
        {
            var GetClinicSlots = await MAIN_DIABETIC_REGService.Portal_Booking_GetClinicSlots(clinicID);
            if (GetClinicSlots.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Booking_GetClinicSlots(clinicID);
        }
        [Authorize]
        [HttpGet("Portal_Booking_CheckSlot")]
        public async Task<ActionResult<IEnumerable<Portal_Booking_CheckSlot>>> Portal_Booking_CheckSlot([FromQuery] string nat_id, int SlotID)
        {
            var Booking_CheckSlot = await MAIN_DIABETIC_REGService.Portal_Booking_CheckSlot(nat_id, SlotID);
            if (Booking_CheckSlot.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Booking_CheckSlot(nat_id, SlotID);
        }
        [Authorize]
        [HttpGet("Portal_Booking_BookSlot")]
        public async Task<ActionResult<IEnumerable<Portal_Booking_BookSlot>>> Portal_Booking_BookSlot([FromQuery] string nat_id, int SlotID)
        {
            var Booking_BookSlot = await MAIN_DIABETIC_REGService.Portal_Booking_BookSlot(nat_id, SlotID);
            if (Booking_BookSlot.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Booking_BookSlot(nat_id, SlotID);
        }
        // **************** End *****************************************

        // **************** Appointment Details API *********************
        [Authorize]
        [HttpGet("Portal_Appointments_GetPastAppointments")]
        public async Task<ActionResult<IEnumerable<Portal_Appointments_GetPastAppointments>>> Portal_Appointments_GetPastAppointments([FromQuery] string nat_id)
        {
            var GetPastAppointments = await MAIN_DIABETIC_REGService.Portal_Appointments_GetPastAppointments(nat_id);
            if (GetPastAppointments.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Appointments_GetPastAppointments(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Appointments_GetFutureAppointments")]
        public async Task<ActionResult<IEnumerable<Portal_Appointments_GetFutureAppointments>>> Portal_Appointments_GetFutureAppointments([FromQuery] string nat_id)
        {
            var GetFutureAppointments = await MAIN_DIABETIC_REGService.Portal_Appointments_GetFutureAppointments(nat_id);
            if (GetFutureAppointments.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Appointments_GetFutureAppointments(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Appointments_GetFutureSpecialityAppointments")]
        public async Task<ActionResult<IEnumerable<Portal_Appointments_GetFutureSpecialityAppointments>>> Portal_Appointments_GetFutureSpecialityAppointments([FromQuery] string nat_id)
        {
            var GetFutureSpecialityAppointments = await MAIN_DIABETIC_REGService.Portal_Appointments_GetFutureSpecialityAppointments(nat_id);
            if (GetFutureSpecialityAppointments.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Appointments_GetFutureSpecialityAppointments(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Appointments_CancelFutureAppointments")]
        public async Task<ActionResult<IEnumerable<Portal_Appointments_CancelFutureAppointments>>> Portal_Appointments_CancelFutureAppointments([FromQuery] string nat_id, int app_id)
        {
            var CancelFutureAppointments = await MAIN_DIABETIC_REGService.Portal_Appointments_CancelFutureAppointments(nat_id, app_id);
            if (CancelFutureAppointments.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Appointments_CancelFutureAppointments(nat_id, app_id);
        }
        [Authorize]
        [HttpGet("Portal_Appointments_CancelFutureSpecialityAppointments")]
        public async Task<ActionResult<IEnumerable<Portal_Appointments_CancelFutureSpecialityAppointments>>> Portal_Appointments_CancelFutureSpecialityAppointments([FromQuery] string nat_id, int ID, string Source)
        {
            var CancelFutureSpecialityAppointments = await MAIN_DIABETIC_REGService.Portal_Appointments_CancelFutureSpecialityAppointments(nat_id, ID, Source);
            if (CancelFutureSpecialityAppointments.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Appointments_CancelFutureSpecialityAppointments(nat_id, ID, Source);
        }
        // **************** End *****************************************
        // **************** Medications Details API *********************
        [Authorize]
        [HttpGet("Portal_Medication_GetActiveClass")]
        public async Task<ActionResult<IEnumerable<Portal_Medication_GetActiveClass>>> Portal_Medication_GetActiveClass([FromQuery] string nat_id)
        {
            var Medication_GetActiveClass = await MAIN_DIABETIC_REGService.Portal_Medication_GetActiveClass(nat_id);
            if (Medication_GetActiveClass.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Medication_GetActiveClass(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Medication_GetRefill")]
        public async Task<ActionResult<IEnumerable<Portal_Medication_GetRefill>>> Portal_Medication_GetRefill([FromQuery] string nat_id)
        {
            var Medication_GetRefill = await MAIN_DIABETIC_REGService.Portal_Medication_GetRefill(nat_id);
            if (Medication_GetRefill.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Medication_GetRefill(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Medication_RequestRefill")]
        public async Task<ActionResult<IEnumerable<Portal_Medication_RequestRefill>>> Portal_Medication_RequestRefill([FromQuery] string nat_id, int id)
        {
            var Medication_RequestRefill = await MAIN_DIABETIC_REGService.Portal_Medication_RequestRefill(nat_id, id);
            if (Medication_RequestRefill.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Medication_RequestRefill(nat_id, id);
        }
        // **************** End *****************************************
        // **************** Prescription Details API ********************
        [Authorize]
        [HttpGet("Portal_Prescription_Request")]
        public async Task<ActionResult<IEnumerable<Portal_Prescription_Request>>> Portal_Prescription_Request([FromQuery] string nat_id)
        {
            var Prescription_Request = await MAIN_DIABETIC_REGService.Portal_Prescription_Request(nat_id);
            if (Prescription_Request.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Prescription_Request(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Prescription_ViewRequests")]
        public async Task<ActionResult<IEnumerable<Portal_Prescription_ViewRequests>>> Portal_Prescription_ViewRequests([FromQuery] string nat_id)
        {
            var Prescription_ViewRequests = await MAIN_DIABETIC_REGService.Portal_Prescription_ViewRequests(nat_id);
            if (Prescription_ViewRequests.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Prescription_ViewRequests(nat_id);
        }
        // **************** End *************************************
        // **************** Report  API *****************************
        [Authorize]
        [HttpGet("Portal_Reports_ViewVisits")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_ViewVisits>>> Portal_Reports_ViewVisits([FromQuery] string nat_id)
        {
            var Reports_ViewVisits = await MAIN_DIABETIC_REGService.Portal_Reports_ViewVisits(nat_id);
            if (Reports_ViewVisits.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_ViewVisits(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Reports_Request")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_Request>>> Portal_Reports_Request([FromQuery] int id, string req_reason)
        {
            var Reports_Request = await MAIN_DIABETIC_REGService.Portal_Reports_Request(id, req_reason);
            if (Reports_Request.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_Request(id, req_reason);
        }
        [Authorize]
        [HttpGet("Portal_Reports_ViewRequests")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_ViewRequests>>> Portal_Reports_ViewRequests([FromQuery] string nat_id)
        {
            var Reports_ViewRequests = await MAIN_DIABETIC_REGService.Portal_Reports_ViewRequests(nat_id);
            if (Reports_ViewRequests.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_ViewRequests(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Reports_GetMedicalReports")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetMedicalReports>>> Portal_Reports_GetMedicalReports([FromQuery] string nat_id)
        {
            var GetMedicalReports = await MAIN_DIABETIC_REGService.Portal_Reports_GetMedicalReports(nat_id);
            if (GetMedicalReports.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetMedicalReports(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Reports_GetMedicalReportDetails")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetMedicalReportDetails>>> Portal_Reports_GetMedicalReportDetails([FromQuery] int report_id)
        {
            var GetMedicalReportDetails = await MAIN_DIABETIC_REGService.Portal_Reports_GetMedicalReportDetails(report_id);
            if (GetMedicalReportDetails.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetMedicalReportDetails(report_id);
        }
        // **************** End *****************************************
        // **************** Sick leaves API *****************************
        [Authorize]
        [HttpGet("Portal_Reports_GetSickleaves")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetSickleaves>>> Portal_Reports_GetSickleaves([FromQuery] string nat_id)
        {
            var Reports_GetSickleaves = await MAIN_DIABETIC_REGService.Portal_Reports_GetSickleaves(nat_id);
            if (Reports_GetSickleaves.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetSickleaves(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Reports_GetSickleaveDetails")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetSickleaveDetails>>> Portal_Reports_GetSickleaveDetails([FromQuery] int ID)
        {
            var GetSickleaveDetails = await MAIN_DIABETIC_REGService.Portal_Reports_GetSickleaveDetails(ID);
            if (GetSickleaveDetails.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetSickleaveDetails(ID);
        }
        // **************** End *********************************************
        // **************** Oprative Report API *****************************
        [Authorize]
        [HttpGet("Portal_Reports_GetOperativeReports")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetOperativeReports>>> Portal_Reports_GetOperativeReports([FromQuery] string nat_id)
        {
            var GetOperativeReport = await MAIN_DIABETIC_REGService.Portal_Reports_GetOperativeReports(nat_id);
            if (GetOperativeReport.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetOperativeReports(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Reports_GetOperativeReportDetails")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetOperativeReportDetails>>> Portal_Reports_GetOperativeReportDetails([FromQuery] int ID)
        {
            var GetOperativeReportDetails = await MAIN_DIABETIC_REGService.Portal_Reports_GetOperativeReportDetails(ID);
            if (GetOperativeReportDetails.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetOperativeReportDetails(ID);
        }
        // **************** End ************************************************
        // **************** Discharge Summary  API *****************************
        [Authorize]
        [HttpGet("Portal_Reports_GetDischargeSummaries")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetDischargeSummaries>>> Portal_Reports_GetDischargeSummaries([FromQuery] string nat_id)
        {
            var GetDischargeSummaries = await MAIN_DIABETIC_REGService.Portal_Reports_GetDischargeSummaries(nat_id);
            if (GetDischargeSummaries.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetDischargeSummaries(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Reports_GetDischargeSummaryDetails")]
        public async Task<ActionResult<IEnumerable<Portal_Reports_GetDischargeSummaryDetails>>> Portal_Reports_GetDischargeSummaryDetails([FromQuery] int ID)
        {
            var GetDischargeSummaryDetails = await MAIN_DIABETIC_REGService.Portal_Reports_GetDischargeSummaryDetails(ID);
            if (GetDischargeSummaryDetails.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Reports_GetDischargeSummaryDetails(ID);
        }
        // **************** End ***********************************************
        // **************** Vitals  API ***************************************
        [Authorize]
        [HttpGet("Portal_Vitals_GetWeight")]
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetWeight>>> Portal_Vitals_GetWeight([FromQuery] string nat_id)
        {
            var Vitals_GetWeight = await MAIN_DIABETIC_REGService.Portal_Vitals_GetWeight(nat_id);
            if (Vitals_GetWeight.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Vitals_GetWeight(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Vitals_GetHeight")]
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetHeight>>> Portal_Vitals_GetHeight([FromQuery] string nat_id)
        {
            var Vitals_GetHeight = await MAIN_DIABETIC_REGService.Portal_Vitals_GetHeight(nat_id);
            if (Vitals_GetHeight.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Vitals_GetHeight(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Vitals_GetHeartRate")]
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetHeartRate>>> Portal_Vitals_GetHeartRate([FromQuery] string nat_id)
        {
            var Vitals_GetHeartRate = await MAIN_DIABETIC_REGService.Portal_Vitals_GetHeartRate(nat_id);
            if (Vitals_GetHeartRate.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Vitals_GetHeartRate(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Vitals_GetBloodSugarClass")]
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetBloodSugarClass>>> Portal_Vitals_GetBloodSugarClass([FromQuery] string nat_id)
        {
            var GetBloodSugarClass = await MAIN_DIABETIC_REGService.Portal_Vitals_GetBloodSugarClass(nat_id);
            if (GetBloodSugarClass.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Vitals_GetBloodSugarClass(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Vitals_GetBodyTemprature")]
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetBodyTemprature>>> Portal_Vitals_GetBodyTemprature([FromQuery] string nat_id)
        {
            var Vitals_GetBodyTemprature = await MAIN_DIABETIC_REGService.Portal_Vitals_GetBodyTemprature(nat_id);
            if (Vitals_GetBodyTemprature.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Vitals_GetBodyTemprature(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Vitals_GetBloodPressure")]
        public async Task<ActionResult<IEnumerable<Portal_Vitals_GetBloodPressure>>> Portal_Vitals_GetBloodPressure([FromQuery] string nat_id)
        {
            var Vitals_GetBloodPressure = await MAIN_DIABETIC_REGService.Portal_Vitals_GetBloodPressure(nat_id);
            if (Vitals_GetBloodPressure.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Vitals_GetBloodPressure(nat_id);
        }
        // **************** End ************************************************
        // **************** Lab  API *******************************************
        [Authorize]
        [HttpGet("Portal_Lab_GetLabOrders")]
        public async Task<ActionResult<IEnumerable<Portal_Lab_GetLabOrders>>> Portal_Lab_GetLabOrders([FromQuery] string nat_id)
        {
            var Lab_GetLabOrders = await MAIN_DIABETIC_REGService.Portal_Lab_GetLabOrders(nat_id);
            if (Lab_GetLabOrders.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Lab_GetLabOrders(nat_id);
        }
        [Authorize]
        [HttpGet("Portal_Lab_GetLabResults")]
        public async Task<ActionResult<IEnumerable<Portal_Lab_GetLabResults>>> Portal_Lab_GetLabResults([FromQuery] string OrderNo)
        {
            var Lab_GetLabResults = await MAIN_DIABETIC_REGService.Portal_Lab_GetLabResults(OrderNo);
            if (Lab_GetLabResults.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Lab_GetLabResults(OrderNo);
        }
        // **************** End ************************************************

        // **************** Mobile  API ****************************************
        [Authorize]
        [HttpGet("Portal_Mobile_InsertCode")]
        public async Task<ActionResult<IEnumerable<Portal_Mobile_InsertCode>>> Portal_Mobile_InsertCode([FromQuery] string nat_id, string newMobile)
        {
            //Portal_Mobile_InsertCode data = new Portal_Mobile_InsertCode();
            //var _Portal_Mobile_InsertCode = await _repository.Portal_Mobile_InsertCode(nat_id, newMobile);
            //foreach (var item in _Portal_Mobile_InsertCode)
            //{
            //    data.nat_id = item.nat_id;
            //    data.mobile = item.mobile;
            //    data.auth_code = item.auth_code;
            //    data.Sms = item.Sms;
            //}
            //await _SmsController.SendSms(data.mobile, data.Sms);
            //return Ok(_Portal_Mobile_InsertCode);
            var Mobile_InsertCode = await MAIN_DIABETIC_REGService.Portal_Mobile_InsertCode(nat_id, newMobile);
            if (Mobile_InsertCode.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Mobile_InsertCode(nat_id, newMobile);
        }
        [Authorize]
        [HttpGet("Portal_Mobile_CheckCode")]
        public async Task<ActionResult<IEnumerable<Portal_Mobile_CheckCode>>> Portal_Mobile_CheckCode([FromQuery] string nat_id, string newmobile, string auth_code)
        {
            var Mobile_CheckCode = await MAIN_DIABETIC_REGService.Portal_Mobile_CheckCode(nat_id, newmobile, auth_code);
            if (Mobile_CheckCode.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_Mobile_CheckCode(nat_id, newmobile, auth_code);
        }
        // **************** End ************************************************

        // **************** Temprory Mobile  API *******************************************
        [Authorize]
        [HttpGet("Portal_TemporaryMobile_InsertRequest")]
        public async Task<ActionResult<IEnumerable<Portal_TemporaryMobile_InsertRequest>>> Portal_TemporaryMobile_InsertRequest([FromQuery] string nat_id, string oldMobile, string newMobile)
        {
            //Portal_TemporaryMobile_InsertRequest data = new Portal_TemporaryMobile_InsertRequest();
            //var _TemporaryMobile_InsertRequest = await _repository.Portal_TemporaryMobile_InsertRequest(nat_id, oldMobile, newMobile);
            //foreach (var item in _TemporaryMobile_InsertRequest)
            //{
            //    data.nat_id = item.nat_id;
            //    data.mobile = item.mobile;
            //    data.auth_code = item.auth_code;
            //    data.Sms = item.Sms;
            //}
            //await _SmsController.SendSms(data.mobile, data.Sms);
            //return Ok(_TemporaryMobile_InsertRequest);
            var TemporaryMobile_InsertRequest = await MAIN_DIABETIC_REGService.Portal_TemporaryMobile_InsertRequest(nat_id, oldMobile, newMobile);
            if (TemporaryMobile_InsertRequest.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_TemporaryMobile_InsertRequest(nat_id, oldMobile, newMobile);
        }
        [Authorize]
        [HttpGet("Portal_TemporaryMobile_CheckCode")]
        public async Task<ActionResult<IEnumerable<Portal_TemporaryMobile_CheckCode>>> Portal_TemporaryMobile_CheckCode([FromQuery] string nat_id, string auth_code)
        {
            var TemporaryMobile_CheckCode = await MAIN_DIABETIC_REGService.Portal_TemporaryMobile_CheckCode(nat_id, auth_code);
            if (TemporaryMobile_CheckCode.Result == null)
            {
                return NotFound();
            }
            return await MAIN_DIABETIC_REGService.Portal_TemporaryMobile_CheckCode(nat_id, auth_code);
        }
        // **************** End ************************************************

    }
    public class Dr
    {
        public string? dr_drno { get; set; }
        public decimal? dr_dept { get; set; }
        public string? dr_surnam { get; set; }

    }

    //public class Department
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public List<Employee>? Employees { get; set; }
    //}
    //public class Department
    //{
    //    public List<Employee>? Employees { get; set; }
    //}
    public class Company
    {
        public List<Dr>? Doctors { get; set; }
    }
}
