using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_GetMedicalReportDetails
    {
        public int? report_id { get; set; }
        public DateTime? requestDate { get; set; }
        public string? requestBy { get; set; }
        public string? language { get; set; }
        public DateTime? ReportDate { get; set; }
        public string? dr_no { get; set; }
        public string? med_rec_no { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public DateTime? ExaminationDate { get; set; }
        public string? PresentComp { get; set; }
        public string? History { get; set; }
        public string? Exam { get; set; }
        public string? Invest { get; set; }
        public string? Diagnosis { get; set; }
        public string? Management { get; set; }
        public string? PeriodOfHealing { get; set; }
        public string? comment { get; set; }
        public string? nationaID { get; set; }

    }
}
