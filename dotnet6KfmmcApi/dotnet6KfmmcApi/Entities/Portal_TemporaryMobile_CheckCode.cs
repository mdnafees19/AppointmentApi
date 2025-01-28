using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_TemporaryMobile_CheckCode
    {
        public string? status { get; set; }
        public string? nat_id { get; set; }

    }
}
