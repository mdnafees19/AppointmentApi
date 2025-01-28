using Microsoft.EntityFrameworkCore;

namespace dotnet6KfmmcApi.Entities
{
    [Keyless]
    public class Portal_Login_CheckLogin
    {
        public string? nat_id { get; set; }
        public string? status { get; set; }
    }
}
