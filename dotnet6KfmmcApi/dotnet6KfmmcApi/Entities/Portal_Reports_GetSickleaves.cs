using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_GetSickleaves
    {
        public string? empnum { get; set; }
        public string? med_rec_no { get; set; }
        public string? DRNO { get; set; }
        public string? doctor { get; set; }
        public DateTime? sick_from { get; set; }
        public string? hijri_sick_from { get; set; }
        public DateTime? sick_to { get; set; }
        public string? hijri_sick_to { get; set; }
        public decimal? days { get; set; }
        public string? date_entered { get; set; }
        public string? action { get; set; }

    }
}
