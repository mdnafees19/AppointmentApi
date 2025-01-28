using dotnet6KfmmcApi.Controllers;
using dotnet6KfmmcApi.Data;
using dotnet6KfmmcApi.Entity;
using dotnet6KfmmcApi.Repositories;
using KfmmcAppointmentApi.Controllers;
using KfmmcAppointmentApi.Entities;
using KfmmcAppointmentApi.Middlewares;
using KfmmcAppointmentApi.Repositories;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IAppointmentService, AppointmentService>();
builder.Services.AddDbContext<DbContextClass>();
//Portal_Login_InsertLoginRepository
builder.Services.AddSingleton(new Portal_Login_InsertLoginRepository(builder.Configuration.GetConnectionString("AppointmentApiConn")));
builder.Services.AddTransient<SmsController>();
builder.Services.AddControllers();
builder.Services.AddScoped<JwtTokenService>();
builder.Services.AddHttpClient<SmsService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
    option.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidIssuer = builder.Configuration["jwtSettings:Issuer"],
        ValidAudience = builder.Configuration["jwtSettings:Audience"],
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["jwtSettings:Key"]))
    };
});


builder.Services.AddCors(p => p.AddPolicy("corspolicy", build =>
{
    build.WithOrigins("https://kfmmc.med.sa/HISApointmentAPI/", "http://localhost/KfmmcAppointmentApi/").AllowAnyMethod().AllowAnyHeader();
}));

//builder.Services.AddCors(options => options.AddPolicy("corspolicy",
//    policy =>
//    {
//        policy.AllowAnyOrigin()
//            .AllowAnyHeader()
//            .AllowAnyMethod();
//    }));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors("corspolicy");
//app.UseAuthentication();
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //app.UseExceptionHandler("/error");
    app.UseHsts();
}
app.UseMiddleware<ExceptionHandlerMiddleware>();
//app.UseAuthorization();
//app.UseCors(options =>
//{
//    options.AllowAnyHeader();
//    options.AllowAnyOrigin();
//    options.AllowAnyMethod();
//});
//app.Use(async (context, next) =>
//{
//    context.Response.Headers.Add("Referrer-Policy", "strict-origin-when-cross-origin");
//    await next();
//});
//app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
