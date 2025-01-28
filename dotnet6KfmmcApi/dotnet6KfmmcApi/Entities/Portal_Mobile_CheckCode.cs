using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Mobile_CheckCode
    {
        public int? status { get; set; }
        public string? details { get; set; }
        public string? ardetails { get; set; }
        public string? nat_id { get; set; }
        

    }
}
