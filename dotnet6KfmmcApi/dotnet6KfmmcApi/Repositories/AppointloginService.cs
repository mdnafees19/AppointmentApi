using dotnet6KfmmcApi.Data;
using dotnet6KfmmcApi.Entities;
using dotnet6KfmmcApi.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace dotnet6KfmmcApi.Repositories
{
    public class AppointloginService
    {
        private readonly DbContextClass _dbContext;
        public AppointloginService(DbContextClass dbContext)
        {
            _dbContext = dbContext;
        }
        //public async Task<ActionResult<IEnumerable<AppointLogin>>> AppointmentLogin(string nat_id)
        //{
        //    IEnumerable<AppointLogin> diabeticClassesObj = await _dbContext.AppointLogins.FromSqlRaw<AppointLogin>("Portal_Login_CheckNationalID").ToListAsync();
        //    var json = JsonConvert.SerializeObject(diabeticClassesObj);
        //    return new OkObjectResult(json);

        //}
    }
}
