using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Booking_GetPatientClinics
    {
        public int? clinicid { get; set; }
        public string? strTitle { get; set; }
        public string? strArTitle { get; set; }
        public bool? bitAllowFamily { get; set; }
        public int? intDayBefore { get; set; }
        public string? strTime { get; set; }
        public bool? bitVIP { get; set; }
        public string? strLocationAr { get; set; }
        public string? strLocationEn { get; set; }
        public string? strArabicNote { get; set; }
        public int? group { get; set; }
        public bool? isVirtual { get; set; }
        public int? cancelHour { get; set; }
        public int? intorder { get; set; }
        public bool? bitEmployee { get; set; }



    }
}
