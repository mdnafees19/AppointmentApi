using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Mobile_InsertCode
    {
        public string? nat_id { get; set; }
        public string? auth_code { get; set; }
        public string? mobile { get; set; }
        public int? status { get; set; }
        public string? Sms { get; set; }
        

    }
}
