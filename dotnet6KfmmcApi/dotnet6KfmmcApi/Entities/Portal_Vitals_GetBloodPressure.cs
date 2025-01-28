using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Vitals_GetBloodPressure
    {
        public string? bpsitmin { get; set; }
        public string? bpsitmax { get; set; }
        public DateTime? Enteringtime { get; set; }

    }
}
