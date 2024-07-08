using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RestaurantBookingWebApi.Data;
using RestaurantBookingWebApi.Models;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RestaurantBookingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public readonly RestaurantBookingContext context;
        public readonly IConfiguration configuration;
        public LoginController (RestaurantBookingContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route ("/login")]
        public async Task<IActionResult> Login(LoginModel loginModel)
        {
            try
            {
                int userId = CheckUser(loginModel);
                if (userId != 0)
                {
                    string token = GenrateToken(userId);
                    return Ok(new { token, userId });
                }
                else
                {
                    return NotFound("user not fount");
                }
            }
            catch (Exception)
            {
                return StatusCode(500, "something went wrong in server");
            }
        }

        private int CheckUser(LoginModel loginModel)
        {
            var user = context.UserList.FirstOrDefault(user => user.phone == loginModel.phone && user.password == loginModel.password);
            if(user!=null)
            {
                return user.userId;
            }
            else
            {
                return 0;
            }
        }

        private string GenrateToken(int userId)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, $"{userId}")
            };

            var Sectoken = new JwtSecurityToken(
                configuration["Jwt:Issuer"],
                configuration["Jwt:Issuer"],
                claims,
                expires: DateTime.Now.AddDays(10),
                signingCredentials: credentials
                );

            var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);

            return token;
        }
    }
}