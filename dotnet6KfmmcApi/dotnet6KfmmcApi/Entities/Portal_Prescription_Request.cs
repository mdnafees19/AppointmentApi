using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Prescription_Request
    {
        public bool? status { get; set; }
        public string? details { get; set; }
        public string? nat_id { get; set; }
        public string? error { get; set; }
    }
}
