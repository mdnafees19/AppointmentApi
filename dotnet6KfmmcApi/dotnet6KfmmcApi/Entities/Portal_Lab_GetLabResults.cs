using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Lab_GetLabResults
    {
        public string? TestOrder { get; set; }
        public DateTime? ReleaseTime { get; set; }
        public string? Section { get; set; }
        public string? Result { get; set; }
        public string? RefRange { get; set; }
        public string? unit { get; set; }
        public string? ErrorFlag { get; set; }
        public string? status { get; set; }
    }
}
