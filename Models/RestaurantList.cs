using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantBookingWebApi.Models
{
    public class RestaurantList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int restaurantId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string about { get; set; }
        public float rating { get; set; } = 0.0f;
    }
}