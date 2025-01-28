using dotnet6KfmmcApi.Entities;
using dotnet6KfmmcApi.Entity;
using Microsoft.AspNetCore.Mvc;

namespace dotnet6KfmmcApi.Repositories
{
    public interface IAppointLogin
    {
        public Task<ActionResult<IEnumerable<AppointLogin>>> AppointmentLogin(string nat_id);


    }
}
