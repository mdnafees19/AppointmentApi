using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Vitals_GetBodyTemprature
    {
        public string? oraltemp { get; set; }
        public DateTime? Enteringtime { get; set; }
    }
}
