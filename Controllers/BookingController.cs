using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBookingWebApi.Data;
using RestaurantBookingWebApi.Models;

namespace RestaurantBookingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        public readonly RestaurantBookingContext context;
        public BookingController(RestaurantBookingContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route ("/booking")]
        public async Task<IActionResult> Book(RestaurantBookingDetails restaurantBookingDetails)
        {
            context.RestaurantBookingDetails.Add(restaurantBookingDetails);
            await context.SaveChangesAsync();
            return Ok("booked successfully");
        }
    }
}