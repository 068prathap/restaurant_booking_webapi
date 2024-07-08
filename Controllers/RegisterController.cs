using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBookingWebApi.Data;
using RestaurantBookingWebApi.Models;

namespace RestaurantBookingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public readonly RestaurantBookingContext context;
        public RegisterController(RestaurantBookingContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route ("/register")]
        public async Task<IActionResult> Register(UserList userList)
        {
            try
            {
                context.UserList.AddAsync(userList);
                await context.SaveChangesAsync();
                return StatusCode(201, "successfully registered");
            }
            catch (Exception)
            {
                return StatusCode(500, "something went wrong in the server");
            }
        }
    }
}