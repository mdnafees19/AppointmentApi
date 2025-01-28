using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Vitals_GetBloodSugarClass
    {
        public string? bloodsugar { get; set; }
        public string? fasting { get; set; }
        public DateTime? Enteringtime { get; set; }

    }
}
