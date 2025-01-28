using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Booking_BookSlot
    {
        public bool? status { get; set; }
        public string? details { get; set; }
        public string? nat_id { get; set; }
        public string? mobile { get; set; }
        public string? Sms { get; set; }
        public string? error { get; set; }

    }
}
