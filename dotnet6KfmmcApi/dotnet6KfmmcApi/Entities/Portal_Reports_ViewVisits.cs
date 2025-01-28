using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_ViewVisits
    {
        public int? id { get; set; }
        public string? clinicname { get; set; }
        public string? AClinicName { get; set; }
        public DateTime? Visiteddate { get; set; }
        public string? dr_name { get; set; }

    }
}
