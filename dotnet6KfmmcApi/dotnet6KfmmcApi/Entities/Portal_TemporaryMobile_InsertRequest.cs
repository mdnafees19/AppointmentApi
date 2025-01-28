using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_TemporaryMobile_InsertRequest
    {
        public string? nat_id { get; set; }
        public string? auth_code { get; set; }
        public string? mobile { get; set; }
        public string? status { get; set; }
        public string? Sms { get; set; }
        

    }
}
