using System.ComponentModel.DataAnnotations;

namespace BasicCarRentalSystemCRUD.Models
{
    public class CarRenter
    {
        [Required]
        public string? CarModel { get; set; }
        [Required]
        public string? CustomerName { get; set; }

        [Required]
        public DateTime RentalDate { get; set; }
        [Required]
        public DateTime ReturnDate { get; set; }
    }
}
