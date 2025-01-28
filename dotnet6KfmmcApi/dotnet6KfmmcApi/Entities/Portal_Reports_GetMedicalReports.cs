using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_GetMedicalReports
    {
        public int? report_id { get; set; }
        public DateTime? requestDate { get; set; }
        public string? requestBy { get; set; }
        public string? language { get; set; }
        public DateTime? ReportDate { get; set; }
        public string? dr_no { get; set; }
        public string? med_rec_no { get; set; }
        public DateTime? ExaminationDate { get; set; }
        public string? status { get; set; }

    }
}
