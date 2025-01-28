using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_GetOperativeReportDetails
    {
        public int? ID { get; set; }
        public string? Sex { get; set; }
        public string? MedRecNo { get; set; }
        public string? PatName { get; set; }
        public DateTime? AdmDate { get; set; }
        public DateTime? AdmTime { get; set; }
        public string? WardName { get; set; }
        public string? BedNo { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DateProc { get; set; }
        public DateTime? opdate { get; set; }
        public DateTime? OprRptAppDt { get; set; }
        public string? ConsultantName { get; set; }
        public string? MD { get; set; }
        public string? RefNo { get; set; }
        public string? JobNo { get; set; }
        public string? DictBy { get; set; }
        public DateTime? DictDate { get; set; }
        public DateTime? DictTime { get; set; }
        public string? OprRptBy { get; set; }
        public int? Admno { get; set; }
        public string? OprRptAppBy { get; set; }
        public DateTime? OprRptApptm { get; set; }
        public string? dr_drno { get; set; }
        public string? dr_surnam { get; set; }
        public string? dr_frstnam { get; set; }
        public string? dr_jtitle { get; set; }
        public string? PreOprDiag { get; set; }
        public string? PostOprDiag { get; set; }
        public string? NameOpr { get; set; }
        public string? PrevOpr { get; set; }
        public string? OprFind { get; set; }
        public string? OprSurg { get; set; }
        public string? OprSurgAsst { get; set; }
        public string? Anest { get; set; }
        public string? AnestAsst { get; set; }
        public string? Specimen { get; set; }
        public string? EstBldLoss { get; set; }
        public string? BldTransfus { get; set; }
        public string? Complc { get; set; }
        public string? OprProc { get; set; }
        public string? OprReport { get; set; }
        public string? TypOfSurg { get; set; }











    }
}
