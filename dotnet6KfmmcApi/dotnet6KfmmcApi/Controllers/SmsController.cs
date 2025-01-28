using dotnet6KfmmcApi.Entity;
using KfmmcAppointmentApi.CustomActionFilters;
using KfmmcAppointmentApi.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Reflection;

namespace KfmmcAppointmentApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SmsController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public SmsController(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        [HttpPost("sendSMS")]
        [ValidateModel]
        public async Task<IActionResult> SendSms([FromQuery] string Mobile,string Sms)
        {
            // Retrieve configuration values
            //string _SMSBody = _configuration["BODY:SMSBody"];
            //string _LoginSMS = _configuration["TaqnyatLoginSMS:LoginSMS"];
            string apiBaseUrl = _configuration["TaqnyatSettings:ApiBaseUrl"];
            if (string.IsNullOrEmpty(Mobile) && string.IsNullOrEmpty(Sms))
            {
                return BadRequest("Invalid input data.");
            }
            try
            {
                // Make the HTTP GET request
                string url = $"{apiBaseUrl}{Mobile}&body={Sms}";
                //HttpResponseMessage response = await _httpClient.GetAsync(url);
                HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts");

                if (response.IsSuccessStatusCode)
                {
                    return Ok("SMS sent successfully.");
                }
                else
                {
                    string error = await response.Content.ReadAsStringAsync();
                    return StatusCode((int)response.StatusCode, $"Failed to send SMS: {error}");
                }
            }
            catch (HttpRequestException ex)
            {
                // Log the error 
                return StatusCode(500, $"An error occurred while sending the SMS: {ex.Message}");
            }
        }

        //[HttpPost("sendSMS")]
        //public async Task<IActionResult> SendSms([FromQuery] string nat_id)
        //{
        //    // Make the HTTP GET request
        //    string LoginURL= $"http://localhost:8011/api/Appointment/Portal_Login_InsertLogin?nat_id=";
        //    string _baseLoginURL = $"{LoginURL}{nat_id}";
        //    HttpResponseMessage Loginresponce = await _httpClient.GetAsync(_baseLoginURL);
        //    string apiReturn = await Loginresponce.Content.ReadAsStringAsync();
        //    List<SmsRecived> objData = JsonConvert.DeserializeObject<List<SmsRecived>>(apiReturn, new JsonSerializerSettings{NullValueHandling = NullValueHandling.Ignore});
        //    SmsRecived ss = new SmsRecived();
        //    foreach (var item in objData)
        //    {
        //        ss.mobile = item.mobile;
        //        ss.auth_code = item.auth_code;
        //    }
        //    // Retrieve configuration values
        //    string _SMSBody = _configuration["BODY:SMSBody"];
        //    string _LoginSMS = _configuration["TaqnyatLoginSMS:LoginSMS"];
        //    string apiBaseUrl = _configuration["TaqnyatSettings:ApiBaseUrl"];
        //    if (string.IsNullOrEmpty(ss.mobile) && string.IsNullOrEmpty(_SMSBody) && string.IsNullOrEmpty(ss.mobile))
        //    {
        //        return BadRequest("Invalid input data.");
        //    }

        //    try
        //    {
        //        // Make the HTTP GET request
        //        string url = $"{apiBaseUrl}{ss.mobile}&body={_SMSBody}{ss.auth_code}";
        //        HttpResponseMessage response = await _httpClient.GetAsync("");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            return Ok("SMS sent successfully.");
        //        }
        //        else
        //        {
        //            string error = await response.Content.ReadAsStringAsync();
        //            return StatusCode((int)response.StatusCode, $"Failed to send SMS: {error}");
        //        }
        //    }
        //    catch (HttpRequestException ex)
        //    {
        //        // Log the error 
        //        return StatusCode(500, $"An error occurred while sending the SMS: {ex.Message}");
        //    }
        //}
    }

    public class SmsRecived
    {
        public string? nat_id { get; set; }
        public string? auth_code { get; set; } 
        public string? mobile { get; set; }  
        public string? status { get; set; }
        public string? Sms { get; set; }

    }


    //    private readonly SmsService _smsService;
    //    private readonly string _SMSBODY;
    //    private readonly string _TaqnyatLoginSMS;

    //    public SmsController(SmsService smsService, IConfiguration configuration)
    //    {
    //        _smsService = smsService;
    //        _SMSBODY = configuration.GetSection("SMSBODY:LoginSMSBody").Value;
    //        _TaqnyatLoginSMS = configuration.GetSection("TaqnyatLoginSMS:LoginSMS").Value;
    //    }
    //   // <add key = "LoginSMS" value="taqnyat"/>
    ////<add key = "LoginSMSBody" value="رقم التوثيق الخاص بك هو code:"/>
    //    //public String LoginSMS = ConfigurationManager.AppSettings["LoginSMS"].ToString();
    //   // public String LoginSMSBody = ConfigurationManager.AppSettings["LoginSMSBody"].ToString();

    //    [HttpPost("send")]
    //    public async Task<IActionResult> SendSms([FromBody] SmsRequest request)
    //    {
    //        if (request == null || string.IsNullOrEmpty(request.Mobile) || string.IsNullOrEmpty(request.Message))
    //        {
    //            return BadRequest("Invalid input.");
    //        }
    //        // Retrieve bearer token securely (e.g., from app settings or environment variables)
    //        //string bearerToken = Environment.GetEnvironmentVariable("TAQNYAT_BEARER_TOKEN");
    //        //if (string.IsNullOrEmpty(bearerToken))
    //        //{
    //        //    return StatusCode(500, "Bearer token is missing.");
    //        //}

    //        // Call the SMS service to send the message

    //        if (_TaqnyatLoginSMS.Equals("taqnyat")) { 


    //        }
    //        bool isSuccess = await _smsService.SendSmsAsync(bearerToken, request.Sender, request.Mobile, request.Message);

    //        if (isSuccess)
    //        {
    //            return Ok("SMS sent successfully.");
    //        }
    //        else
    //        {
    //            return StatusCode(500, "Failed to send SMS.");
    //        }
    //    }
    //}
    //public class SmsRequest
    //{
    //    public string? Mobile { get; set; }
    //    public string? Message { get; set; }
    //    public string? Sender { get; set; } = "KFMMC"; // Default sender
    //}
}

