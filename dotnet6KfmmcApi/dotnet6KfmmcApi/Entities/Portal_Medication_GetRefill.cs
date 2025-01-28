using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Medication_GetRefill
    {
        public int? id { get; set; }
        public string? medicinename { get; set; }
        public DateTime? nextrefilldate { get; set; }
        public int? visitno { get; set; }
        public bool? CanRequest { get; set; }
    }
}
