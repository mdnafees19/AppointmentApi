using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Main_UpdatePatientAddress
    {
        public string? nat_id { get; set; }
        public string? status { get; set; }
    }
}
