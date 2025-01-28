using dotnet6KfmmcApi.Entities;
using KfmmcAppointmentApi.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace dotnet6KfmmcApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : Controller
    {
        private readonly JwtTokenService _jwtTokenService;
        private readonly IConfiguration _configuration;
        public AuthenticationController(JwtTokenService jwtTokenService,IConfiguration configuration)
        {
            _jwtTokenService = jwtTokenService;
            _configuration= configuration;

        }

        //[AllowAnonymous]
        //[HttpPost("login")]
        //public IActionResult Login([FromQuery] string Username, string Password)
        //{

        //    if (Username == "TEST" && Password == "123456")
        //    {
        //        var token = _jwtTokenService.GenerateToken("1", Username); // Simulated UserId
        //        return Ok(new { Token = token });
        //    }

        //    return Unauthorized("Invalid username or password.");
        //}
        [AllowAnonymous]
        [HttpPost("login")]
        public IActionResult Login([FromBody] Users user)
        {
            IActionResult responce = Unauthorized();
            var user_ = AuthenticateUser(user);
            if (user_ != null)
            {
                //#pragma warning disable CS8604 // Possible null reference argument.
                //    var token = _jwtTokenService.GenerateToken(user_.Username); // Simulated UserId
                //#pragma warning restore CS8604 // Possible null reference argument.
                //    return Ok(new { Token = token });
                var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub,_configuration["jwtSettings:Subject"]),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim("UserId",user.Username.ToString()),
                new Claim("Password",user.Password.ToString())
            };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwtSettings:key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _configuration["jwtSettings:Issuer"],
                    _configuration["jwtSettings:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddMinutes(60),
                    signingCredentials: signIn
                    );
                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);
                return Ok(new { Token = tokenValue, User = user_ });
            }

            return NoContent();
        }
        private Users AuthenticateUser(Users user)
        {
            Users _user = null;
            if (user.Username == "KFMMC" && user.Password == "KFMMC@123")
            {
                _user = new Users() { Username = "KFMMC",Password= "KFMMC@123" };
            }
        #pragma warning disable CS8603 // Possible null reference return.
            return _user;
        #pragma warning restore CS8603 // Possible null reference return.

        }

        //    private readonly UserManager<IdentityUser> _userManager;
        //    private readonly RoleManager<IdentityRole> _roleManager;
        //    private readonly IConfiguration _configuration;
        //    public AuthenticationController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        //    {
        //        _userManager = userManager;
        //        _roleManager = roleManager;
        //        _configuration = configuration;
        //    }
        //    [HttpGet]
        //    [Route("login")]
        //    public async Task<IActionResult> Login([FromBody] LoginModel model)
        //    {
        //        var user = await _userManager.FindByNameAsync(model.Username);
        //        if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
        //        {
        //            var userRoles = await _userManager.GetRolesAsync(user);

        //            var authClaims = new List<Claim>
        //            {
        //                new Claim(ClaimTypes.Name, user.UserName),
        //                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        //            };

        //            foreach (var userRole in userRoles)
        //            {
        //                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
        //            }

        //            var token = GetToken(authClaims);

        //            return Ok(new
        //            {
        //                token = new JwtSecurityTokenHandler().WriteToken(token),
        //                expiration = token.ValidTo
        //            });
        //        }
        //        return Unauthorized();
        //    }
        //    private JwtSecurityToken GetToken(List<Claim> authClaims)
        //    {
        //        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

        //        var token = new JwtSecurityToken(
        //            issuer: _configuration["JWT:ValidIssuer"],
        //            audience: _configuration["JWT:ValidAudience"],
        //            expires: DateTime.Now.AddHours(3),
        //            claims: authClaims,
        //            signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
        //            );

        //        return token;
        //    }

        //    public IActionResult Index()
        //    {

        //        return View();
        //    }
    }
    public class Users
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
    }
}
