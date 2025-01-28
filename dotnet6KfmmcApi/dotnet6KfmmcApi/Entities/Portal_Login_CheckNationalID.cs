using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace dotnet6KfmmcApi.Entities
{
    [Keyless]
    public class Portal_Login_CheckNationalID
    {
        //public int valid { get; set; }
        public bool? status { get; set; }
        public string? arMsg { get; set; }
        public string? enMsg { get; set; }
        //[Required]
        //[MinLength(10,ErrorMessage ="National Id has to be minium of 10 digit")]
        public string? nat_id { get; set; }
    }
}
