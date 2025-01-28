using Microsoft.EntityFrameworkCore;

namespace KfmmcAppointmentApi.Entities
{
    [Keyless]
    public class Portal_Lab_GetLabOrders
    {
        public int? id { get; set; }
        public string? orderno { get; set; }
        public DateTime? laborderdate { get; set; }
        public string? location { get; set; }
        public string? section { get; set; }
        public string? fluid { get; set; }
        public string? specimancomment { get; set; }
    }
}
