using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_ViewRequests
    {
        public int? id { get; set; }
        public DateTime? date { get; set; }
        public string? detail { get; set; }
        public string? adetail { get; set; }
    }
}
