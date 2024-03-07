using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Please provide your name.")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Please provide your street address.")]
        public string Address { get; set; } = default!;
        [Required(ErrorMessage = "Please provide your city.")]
        public string City { get; set; } = default!;
    }
}
