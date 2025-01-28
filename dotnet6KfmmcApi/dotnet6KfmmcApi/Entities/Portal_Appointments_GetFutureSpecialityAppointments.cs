using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Appointments_GetFutureSpecialityAppointments
    {
        public int? ID { get; set; }
        public DateTime? ADate { get; set; }
        public DateTime? StartTime { get; set; }
        public string? ClinicName { get; set; }
        public string? AClinicName { get; set; }
        public string? Source { get; set; }
        public bool? PhoneConsultation { get; set; }
        public bool? cancelable { get; set; }

    }
}
