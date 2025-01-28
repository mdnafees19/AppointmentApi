using Microsoft.EntityFrameworkCore;

namespace dotnet6KfmmcApi.Entities
{
    [Keyless]
    public class Portal_Main_GetPatientDetails
    {
        public string? med_rec_no { get; set; }
        public string? nat_id { get; set; }
        public string? jawal { get; set; }
        public string? lastname { get; set; }
        public string? firstname { get; set; }
        public string? faname { get; set; }
        public string? graname { get; set; }
        public string? sex { get; set; }
        public string? exp_date { get; set; }
        public string? afirstname { get; set; }
        public string? afaname { get; set; }
        public string? agraname { get; set; }
        public string? alastname { get; set; }
        public string? hh_no { get; set; }
        public string? elig_code { get; set; }
        public string? vip { get; set; }
        public string? dob { get; set; }
        public int? no_show { get; set; }
        public string? blood_type { get; set; }
        public string? kfmmcid { get; set; }
        public DateTime? lock_date { get; set; }
        public bool? limitedAccess { get; set; }
        public bool? status { get; set; }
        public string? arMsg { get; set; }
        public string? enMsg { get; set; }

    }
}
