using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantBookingWebApi.Data;
using RestaurantBookingWebApi.Models;

namespace RestaurantBookingWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodOrdersController : ControllerBase
    {
        public readonly RestaurantBookingContext context;
        public FoodOrdersController(RestaurantBookingContext context)
        {
            this.context = context;
        }

        [HttpPost]
        [Route ("/addFoods")]
        public async Task<IActionResult> AddFoods(List<FoodOrdersList> foodOrdersList)
        {
            foreach(var  foodOrder in foodOrdersList)
            {
                context.FoodOrdersList.Add(foodOrder);
                await context.SaveChangesAsync();
            }
            return Ok("added successfully");
        }
    }
}