using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Reports_GetSickleaveDetails
    {
        public int? id { get; set; }
        public int? sn { get; set; }
        public string? empnum { get; set; }
        public string? med_rec_no { get; set; }
        public string? dr_drno { get; set; }
        public string? doctor { get; set; }
        public string? entry { get; set; }
        public string? Hentry { get; set; }
        public string? admis { get; set; }
        public string? discharge { get; set; }
        public string? hadmis { get; set; }
        public string? hdischarge { get; set; }
        public string? hijri_sick_from { get; set; }
        public string? hijri_sick_to { get; set; }
        public decimal days { get; set; }
        public string? meddir { get; set; }
        public string? progdir { get; set; }
        public bool? military { get; set; }
        public bool? civilian { get; set; }
        public bool? employee { get; set; }
        public string? remarks { get; set; }
        public string? whoenter { get; set; }
        public string? date_entered { get; set; }
        public string? timeenter { get; set; }
        public bool? svalid { get; set; }
        public string? elig_code { get; set; }
        public string? arank { get; set; }
        public string? aunit { get; set; }
        public string? dr_drno2 { get; set; }
        public string? sstatus { get; set; }
        public string? ip { get; set; }
        public string? sltype { get; set; }
        public string? recomded { get; set; }
        public bool? recchk1 { get; set; }
        public bool? recchk2 { get; set; }
        public bool? recchk3 { get; set; }
        public bool? recchk4 { get; set; }
        public bool? recchk5 { get; set; }
        public bool? recchk6 { get; set; }
        public bool? recchk7 { get; set; }
        public string? excus { get; set; }
        public string? ediag { get; set; }
        public decimal? slcode { get; set; }
        public string? milciv { get; set; }
        public string? medrep { get; set; }
        public string? action { get; set; }
        public string? natid { get; set; }
        public string? workPlace { get; set; }
        public string? Occupation { get; set; }
        public string? visitno { get; set; }
        public DateTime? VisitTime { get; set; }
        public string? VisitDate { get; set; }
        public string? HVisitDate { get; set; }
        public string? Diagnosis { get; set; }
        public DateTime? sick_from { get; set; }
        public DateTime? sick_to { get; set; }








    }
}
