using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Booking_GetClinicSlots
    {
        public int? slotid { get; set; }
        public int? clinicid { get; set; }
        public int? doctorid { get; set; }
        public string? charGender { get; set; }
        public string? strArName { get; set; }
        public string? strEnName { get; set; }
        public bool? bitBooked { get; set; }
        public DateTime? dateStart { get; set; }
        public DateTime? dateEnd { get; set; }
       
    }
}
