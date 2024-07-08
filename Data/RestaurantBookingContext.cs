using Microsoft.EntityFrameworkCore;
using RestaurantBookingWebApi.Models;

namespace RestaurantBookingWebApi.Data
{
    public class RestaurantBookingContext : DbContext
    {
        public RestaurantBookingContext(DbContextOptions<RestaurantBookingContext> Options): base(Options){}

        public DbSet<UserList> UserList { get; set; }
        public DbSet<RestaurantList> RestaurantList { get; set; }
        public DbSet<RestaurantBookingDetails> RestaurantBookingDetails { get; set; }
        public DbSet<FoodOrdersList> FoodOrdersList { get; set; }
    }
}