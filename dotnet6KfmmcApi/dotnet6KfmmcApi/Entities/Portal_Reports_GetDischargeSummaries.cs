using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_GetDischargeSummaries
    {
        public int? ID { get; set; }
        public string? wardname { get; set; }
        public string? admdrname { get; set; }
        public DateTime? admdate { get; set; }
        public DateTime? dischdate { get; set; }

    }
}
