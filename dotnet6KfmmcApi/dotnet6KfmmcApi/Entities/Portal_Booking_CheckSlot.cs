using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Booking_CheckSlot
    {
        public string? nat_id { get; set; }
        public bool?  valid { get; set; }
        public string? details { get; set; }
    }
}
