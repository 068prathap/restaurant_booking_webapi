using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBookingWebApi.Models
{
    public class FoodOrdersList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int foodOrderId { get; set; }
        public string foodName { get; set; }
        public string foodPrice { get; set;}
        public string foodQuantity { get; set;}
        [ForeignKey("RestaurantBookingDetails")]
        public int bookingId { get; set;}
        public virtual RestaurantBookingDetails? RestaurantBookingDetails { get; set; }
    }
}