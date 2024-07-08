using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBookingWebApi.Data;
using RestaurantBookingWebApi.Models;

namespace RestaurantBookingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestaurantListController : ControllerBase
    {
        public readonly RestaurantBookingContext context;
        public RestaurantListController (RestaurantBookingContext context)
        {
            this.context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Add(RestaurantList restaurantList)
        {
            context.Add(restaurantList);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
