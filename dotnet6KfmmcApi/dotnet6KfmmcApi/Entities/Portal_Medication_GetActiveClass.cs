using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Medication_GetActiveClass
    {
        public string? medicine { get; set; }
        public string? enUsage { get; set; }
        public string? arUsage { get; set; }
        public string? inactiveOn { get; set; }
    }
}
