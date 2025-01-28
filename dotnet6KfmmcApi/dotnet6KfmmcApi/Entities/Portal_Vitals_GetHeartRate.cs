using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Vitals_GetHeartRate
    {
        public double? height { get; set; }
        public DateTime? Enteringtime { get; set; }
    }
}
