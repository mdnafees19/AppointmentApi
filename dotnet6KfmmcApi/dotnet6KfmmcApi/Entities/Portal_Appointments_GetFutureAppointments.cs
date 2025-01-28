using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Appointments_GetFutureAppointments
    {
        public int? app_id { get; set; }
        public DateTime? app_Date { get; set; }
        public DateTime? app_time { get; set; }
        public string? cancel { get; set; }
        public string? strArTitle { get; set; }
        public string? strTitle { get; set; }
        public string? cancelable { get; set; }
        
    }
}
