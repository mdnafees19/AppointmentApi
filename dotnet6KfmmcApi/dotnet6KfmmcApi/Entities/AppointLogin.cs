using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace dotnet6KfmmcApi.Entities
{
    [Keyless]
    public class AppointLogin
    {
        [Required(ErrorMessage = "National Id is required")]
        public string? nat_id { get; set; }

    }

}
