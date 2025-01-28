using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Medication_RequestRefill
    {
        public int? status { get; set; }
        public string? details { get; set; }
        public string? nat_id { get; set; }
        public string? error { get; set; }
    }
}
