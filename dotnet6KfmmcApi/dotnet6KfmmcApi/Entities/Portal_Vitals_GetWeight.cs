using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Vitals_GetWeight
    {
        public double? weight { get; set; }
        public DateTime? Enteringtime { get; set; }

    }
}
