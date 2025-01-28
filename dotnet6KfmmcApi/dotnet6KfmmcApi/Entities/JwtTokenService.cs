using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
namespace KfmmcAppointmentApi.Entities
{
    public class JwtTokenService
    {
        private readonly IConfiguration _configuration;

        public JwtTokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //public string GenerateToken(string userId, string username)
        public string GenerateToken(string Username)
        {
            var jwtSettings = _configuration.GetSection("JwtSettings");

            // Retrieve the secret key
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
            //var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var securitykey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings["Key"]));
            var credentials = new SigningCredentials(securitykey, SecurityAlgorithms.HmacSha256);


            // Define the claims for the token
            //    var claims = new[]
            //    {
            //    new Claim(JwtRegisteredClaimNames.Sub, userId),
            //    new Claim(JwtRegisteredClaimNames.UniqueName, username),
            //    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            //    new Claim("role", "Admin") // Example custom claim
            //};

            // Create the JWT token
            //var token = new JwtSecurityToken(
            //    issuer: jwtSettings["Issuer"],
            //    audience: jwtSettings["Audience"],
            //    claims: claims,
            //    expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(jwtSettings["ExpirationMinutes"])),
            //    signingCredentials: credentials
            //);
            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], null,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials:credentials
                
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
