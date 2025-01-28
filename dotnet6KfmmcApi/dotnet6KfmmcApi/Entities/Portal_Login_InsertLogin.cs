using Microsoft.EntityFrameworkCore;
using System.Numerics;

namespace dotnet6KfmmcApi.Entities
{
    [Keyless]
    public class Portal_Login_InsertLogin
    {
        public string? nat_id { get; set; }
        public string? auth_code { get; set; }
        public string? mobile { get; set; }
        public string? status { get; set; }
        public string? Sms { get; set; }
    }
}
