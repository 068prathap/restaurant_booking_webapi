using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBookingWebApi.Models
{
    public class RestaurantBookingDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int bookingId { get; set; }
        public string date { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int tableNo { get; set; }
        [ForeignKey("RestaurantList")]
        public int restaurantId { get; set; }
        public virtual RestaurantList? RestaurantList { get; set; }
        [ForeignKey("UserList")]
        public int userId { get; set; }
        public virtual UserList? UserList { get; set; }
    }
}